' 
' Visual Basic.Net Compiler
' Copyright (C) 2004 - 2007 Rolf Bjarne Kvinge, RKvinge@novell.com
' 
' This library is free software; you can redistribute it and/or
' modify it under the terms of the GNU Lesser General Public
' License as published by the Free Software Foundation; either
' version 2.1 of the License, or (at your option) any later version.
' 
' This library is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
' Lesser General Public License for more details.
' 
' You should have received a copy of the GNU Lesser General Public
' License along with this library; if not, write to the Free Software
' Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
' 

Public Class RShiftExpression
    Inherits BinaryExpression

    Protected Overrides Function GenerateCodeInternal(ByVal Info As EmitInfo) As Boolean
        Dim result As Boolean = True

        ValidateBeforeGenerateCode(Info)

        Dim expInfo As EmitInfo = Info.Clone(Me, True, False, OperandType)

        result = m_LeftExpression.GenerateCode(expInfo) AndAlso result
        result = m_RightExpression.GenerateCode(expInfo.Clone(Me, Compiler.TypeCache.System_Int32)) AndAlso result


        Select Case OperandTypeCode
            Case TypeCode.Int16, TypeCode.Int32, TypeCode.Int64, TypeCode.UInt16, TypeCode.UInt32, TypeCode.UInt64, TypeCode.Byte, TypeCode.SByte
                Dim shift As Integer
                Select Case OperandTypeCode
                    Case TypeCode.Byte, TypeCode.SByte
                        shift = 7
                    Case TypeCode.Int16, TypeCode.UInt16
                        shift = 15
                    Case TypeCode.Int32, TypeCode.UInt32
                        shift = 31
                    Case TypeCode.Int64, TypeCode.UInt64
                        shift = 63
                End Select
                Emitter.EmitLoadI4Value(Info, shift)
                Emitter.EmitAnd(Info, Info.Compiler.TypeCache.System_Int32)
                Emitter.EmitRShift(Info, OperandType)
            Case TypeCode.Object
                Helper.Assert(Helper.CompareType(OperandType, Compiler.TypeCache.System_Object))
                Emitter.EmitCall(Info, Compiler.TypeCache.MS_VB_CS_Operators__RightShiftObject_Object_Object)
            Case Else
                Throw New InternalException(Me)
        End Select

        Return result
    End Function

    Public Overrides ReadOnly Property RightOperandTypeCode() As System.TypeCode
        Get
            If MyBase.OperandTypeCode = TypeCode.Object Then
                Return TypeCode.Object
            Else
                Return TypeCode.Int32
            End If
        End Get
    End Property

    Sub New(ByVal Parent As ParsedObject, ByVal LExp As Expression, ByVal RExp As Expression)
        MyBase.New(Parent, LExp, RExp)
    End Sub

    Public Overrides ReadOnly Property Keyword() As KS
        Get
            Return KS.ShiftRight
        End Get
    End Property

    Public Overrides ReadOnly Property IsConstant() As Boolean
        Get
            Return MyBase.IsConstant 'CHECK: is this true?
        End Get
    End Property

    Public Overrides ReadOnly Property ConstantValue() As Object
        Get
            Dim rvalue, lvalue As Object
            lvalue = m_LeftExpression.ConstantValue
            rvalue = m_RightExpression.ConstantValue
            If lvalue Is Nothing Or rvalue Is Nothing Then
                Return Nothing
            Else

                Dim shifts As Integer 'This needs to be an integer.
                Dim tmpShifts As Object = Nothing
                If Compiler.TypeResolution.CheckNumericRange(rvalue, tmpShifts, Compiler.TypeCache.System_Int32) = False Then
                    Helper.Stop() 'Add error.
                Else
                    shifts = CInt(tmpShifts)
                End If

                Dim tlvalue As Type
                Dim clvalue As TypeCode
                tlvalue = lvalue.GetType
                clvalue = Helper.GetTypeCode(Compiler, tlvalue)

                Select Case clvalue
                    Case TypeCode.Byte
                        Return CByte(lvalue) >> shifts
                    Case TypeCode.SByte
                        Return CSByte(lvalue) >> shifts
                    Case TypeCode.Int16
                        Return CShort(lvalue) >> shifts
                    Case TypeCode.UInt16
                        Return CUShort(lvalue) >> shifts
                    Case TypeCode.Int32
                        Return CInt(lvalue) >> shifts
                    Case TypeCode.UInt32
                        Return CUInt(lvalue) >> shifts
                    Case TypeCode.Int64
                        Return CLng(lvalue) >> shifts
                    Case TypeCode.UInt64
                        Return CULng(lvalue) >> shifts
                    Case TypeCode.Double
                        Throw New InternalException(Me)
                    Case TypeCode.Single
                        Throw New InternalException(Me)
                    Case TypeCode.Decimal
                        Throw New InternalException(Me)
                    Case Else
                        Throw New InternalException(Me)
                End Select
            End If
        End Get
    End Property
End Class