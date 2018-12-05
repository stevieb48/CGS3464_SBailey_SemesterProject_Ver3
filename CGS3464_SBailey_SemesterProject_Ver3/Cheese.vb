﻿'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Cheese.vb
'@version: 1.0
'
'Description
' This Cheese Class inherits from the Item Class.
Public Class Cheese
    Inherits Item

    ' CONSTANTS
    Public Const CHEDDAR_PRICE As Decimal = 0.8
    Public Const MOZZARELLA_PRICE As Decimal = 1.0
    Public Const MIX_PRICE As Decimal = 1.2

    ' instance property
    Public Property ChType As CheeseTypeList

    ' constructor default
    Public Sub New()
        MyBase.New()
        ChType = Nothing
    End Sub

    ' constructor cheese parameters price, cheese type
    Public Sub New(price As Decimal, type As CheeseTypeList)
        MyBase.New(price)
        ChType = type
    End Sub

    Public Overrides Function ToString() As String
        Return ChType.ToString() & MyBase.ToString()
    End Function
End Class