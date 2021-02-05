'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: ValidationTools.vb
'@version: 1.0
'
'Description
' This class has some use input validation utilities.
Public Class ValidationTools
    ' constructor default
    Public Sub New()

    End Sub

    ' public method to validate string input
    Public Function IsValInputString(input As String) As Boolean
        ' see if valid
        If input = String.Empty Then                ' if blank
            ' NOT VALID contains a blank 
            Return False
        ElseIf Not IsValidAlpha(input) Then    ' if special character
            ' NOT VALID contains a special character
            Return False
        Else
            ' VALID letter
            Return True
        End If
    End Function

    ' method to validate numerical input
    Public Function IsValInputNumber(input As String) As Boolean
        ' see if valid
        If String.IsNullOrEmpty(input) Then             ' if null or blank
            ' NOT VALID contains a blank
            Return False
        ElseIf Not IsValidNumber(input) Then      ' if special character
            ' NOT VALID contains a special character
            Return False
        Else
            ' VALID number
            Return True
        End If
    End Function

    ' private method to check if string is a letter
    Private Function IsValidAlpha(input As String) As Boolean
        ' loop through input string checking if each character is a letter
        For i = 0 To input.Length - 1
            If Char.IsLetter(input.Chars(i)) Then
                ' VALID letter
                Return True
            End If
        Next

        ' NOT VALID letter
        Return False
    End Function

    ' private method to check if string is a number
    Private Function IsValidNumber(input As String) As Boolean
        ' loop through input string checking if each character is a digit
        For i = 0 To input.Length - 1
            If Char.IsDigit(input.Chars(i)) Then
                ' VALID number
                Return True
            End If
        Next

        ' NOT VALID number
        Return False
    End Function
End Class