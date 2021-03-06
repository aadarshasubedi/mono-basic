'=============================================================================================
'Name:Manish Kumar Sinha 
'Email Address: manishkumarsinha@sify.com
'Test Case Name: Argument passing by Reference:
'APR-1.1.0: If variable elements is of value type, i.e. it contains only a value then procedure 
'		can change the variable or any of its members
'=============================================================================================

Imports System
Module APR_1_1_0
    Function F(ByRef p As String) As Object
        p = "Sinha"
    End Function

    Function Main() As Integer
        Dim a As String = "Manish"
        F(a)
        If (a = "Manish") Then
            System.Console.WriteLine("#A1, Unexcepted behaviour of ByRef of String Datatype") : Return 1
        End If
    End Function
End Module

'=============================================================================================