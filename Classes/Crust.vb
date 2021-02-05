'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Crust.vb
'@version: 1.0
'
'Description
' This 'Crust' Class inherits from the 'Item' Class. Describes crust on a pizza.

Imports EnumLists

Public Class Crust
    Inherits Item

    ' CONSTANTS
    Public Const PAN_PRICE As Double = 0.6
    Public Const REGULAR_PRICE As Double = 0.5
    Public Const THIN_PRICE As Double = 0.4
    Public Const WHEAT_PRICE As Double = 0.7

    ' instance property
    Public Property CrType As CrustTypeList

    ' constructor default
    Public Sub New()
        MyBase.New()
        CrType = Nothing
    End Sub

    ' constructor crust parameters price, crust type
    Public Sub New(price As Double, type As CrustTypeList)
        MyBase.New(price)
        CrType = type
    End Sub

    ' output object contents
    Public Overrides Function ToString() As String
        Return "cr " & MyBase.ToString()
    End Function
End Class