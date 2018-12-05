'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Topping.vb
'@version: 1.0
'
'Description
' This Topping Class inherits from the Item Class.
Public Class Topping
    Inherits Item

    ' CONSTANTS
    Public Const PEPPERONI_PRICE As Decimal = 1.0
    Public Const HAM_PRICE As Decimal = 1.0
    Public Const SAUSAGE_PRICE As Decimal = 1.0
    Public Const BEEF_PRICE As Decimal = 1.0
    Public Const CHICKEN_PRICE As Decimal = 1.1
    Public Const BACON_PRICE As Decimal = 1.0
    Public Const ONION_PRICE As Decimal = 1.0
    Public Const BELLPEPPER_PRICE As Decimal = 1.0
    Public Const TOMATO_PRICE As Decimal = 1.1
    Public Const ARTICHOKE_PRICE As Decimal = 1.2
    Public Const MUSHROOM_PRICE As Decimal = 1.0
    Public Const OLIVE_PRICE As Decimal = 1.0
    Public Const LETTUCE_PRICE As Decimal = 1.2
    Public Const JALAPENO_PRICE As Decimal = 1.0
    Public Const BANANAPEPPER_PRICE As Decimal = 1.0
    Public Const PINEAPPLE_PRICE As Decimal = 1.1
    Public Const ANCHOVIE_PRICE As Decimal = 1.3

    ' instance property
    Public Property TType As ToppingTypeList

    ' constructor default
    Public Sub New()
        MyBase.New()
        TType = Nothing
    End Sub

    ' constructor topping parameters price, topping type
    Public Sub New(price As Decimal, type As ToppingTypeList)
        MyBase.New(price)
        TType = type
    End Sub

    '
    Public Overrides Function ToString() As String
        Return TType.ToString() & MyBase.ToString()
    End Function
End Class