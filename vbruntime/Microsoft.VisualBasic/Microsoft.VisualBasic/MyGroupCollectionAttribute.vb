'
' MyGroupCollectionAttribute.vb
'
' Author:
'   Mizrahi Rafael (rafim@mainsoft.com)
'

'
' Copyright (C) 2002-2006 Mainsoft Corporation.
' Copyright (C) 2004-2006 Novell, Inc (http://www.novell.com)
'
' Permission is hereby granted, free of charge, to any person obtaining
' a copy of this software and associated documentation files (the
' "Software"), to deal in the Software without restriction, including
' without limitation the rights to use, copy, modify, merge, publish,
' distribute, sublicense, and/or sell copies of the Software, and to
' permit persons to whom the Software is furnished to do so, subject to
' the following conditions:
' 
' The above copyright notice and this permission notice shall be
' included in all copies or substantial portions of the Software.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
' EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
' NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
' LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
' OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
' WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'
#If NET_2_0 Then
Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
'MONOTODO:("What should it do?")
Namespace Microsoft.VisualBasic
    <AttributeUsage(AttributeTargets.Class)> _
    Public NotInheritable Class MyGroupCollectionAttribute
        Inherits Attribute
        Public Sub New(ByVal typeToCollect As String, ByVal createInstanceMethodName As String, ByVal disposeInstanceMethodName As String, ByVal defaultInstanceAlias As String)
            Throw New NotImplementedException
        End Sub
        Public ReadOnly Property CreateMethod() As String
            Get
                Throw New NotImplementedException
            End Get
        End Property
        Public ReadOnly Property DefaultInstanceAlias() As String
            Get
                Throw New NotImplementedException
            End Get
        End Property
        Public ReadOnly Property DisposeMethod() As String
            Get
                Throw New NotImplementedException
            End Get
        End Property
        Public ReadOnly Property MyGroupName() As String
            Get
                Throw New NotImplementedException
            End Get
        End Property
    End Class
End Namespace
#End If