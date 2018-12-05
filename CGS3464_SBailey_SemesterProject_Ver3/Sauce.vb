'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Sauce.vb
'@version: 1.0
'
'Description
' This Sauce Class inherits from the Item Class.
Public Class Sauce
    Inherits Item

    ' CONSTANTS
    Public Const TRADITIONAL_PRICE As Decimal = 0.1
    Public Const ZESTYSALSA_PRICE As Decimal = 0.15
    Public Const BUFFALO_PRICE As Decimal = 0.2
    Public Const BBQ_PRICE As Decimal = 0.25
    Public Const WHITE_PRICE As Decimal = 0.3

    ' instance property
    Public Property SType As SauceTypeList

    ' constructor default
    Public Sub New()
        MyBase.New()
        SType = Nothing
    End Sub

    ' constructor sauce parameters price, sauce type
    Public Sub New(price As Decimal, type As SauceTypeList)
        MyBase.New(price)
        SType = type
    End Sub

    '
    Public Overrides Function ToString() As String
        Return SType.ToString() & MyBase.ToString()
    End Function
End Class