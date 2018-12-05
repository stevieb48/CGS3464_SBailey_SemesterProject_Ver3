'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Order.vb
'@version: 1.0
'
'Description
' This Order Class describes a pizza order.
Imports EnumLists

Public Class Order

    ' ************************* CONSTANTS *************************
    Public ONE_PIZZA As Integer = 1
    Private Const TAX_RATE As Decimal = 0.075
    Private Const CARRYOUT_CHARGE As Decimal = 0.00
    Private Const DELIVERY_CHARGE As Decimal = 4.0

    ' instance variables
    Public Property OCustomer As Customer
    Public Property ONumOrders As Integer = 0
    Public Property OOrderNumber As Integer
    Public Property OType As OrderTypeList
    Public Property OPizzaList As List(Of Pizza)
    Public Property OSubtotal As Decimal
    Public Property OTax As Decimal
    Public Property ODeliveryCharge As Decimal
    Public Property OTotal As Decimal

    ' default constructor for new order
    Public Sub New(counter As Integer)
        ONumOrders = counter + 1
        OCustomer = Nothing
        OOrderNumber = ONumOrders
        OType = Nothing
        OPizzaList = New List(Of Pizza)
        OSubtotal = Nothing
        OTax = Nothing
        OTotal = Nothing
    End Sub

    ' method to prepare the order bill
    Public Sub PrepareOBill()
        ' call method to calculate subtotal
        Dim tempSubtotal = CalcSubtotal()

        ' call method to calculate delivery charge
        CalcDelCharge()

        ' call method to calculate tax
        CalcTax()

        ' call method to calculate total
        CalcTotal()
    End Sub

    ' method to calculate Subtotal
    Public Function CalcSubtotal()
        ' reset subtotal
        OSubtotal = 0.00

        ' loop through pizza list
        For i As Integer = 0 To OPizzaList.Count - 1
            ' add the price of the pizza to the subtotal
            OSubtotal += OPizzaList(i).CalcPizzaCost()
        Next

        '
        Return OSubtotal
    End Function

    ' method to calculate delivery charge
    Private Sub CalcDelCharge()
        ' determine order type
        If OType = OrderTypeList.Carryout Then
            ' set the charge
            ODeliveryCharge = CARRYOUT_CHARGE
        ElseIf OType = OrderTypeList.Delivery Then
            ' set the charge
            ODeliveryCharge = DELIVERY_CHARGE
        End If
    End Sub

    ' method to calculate order tax
    Private Sub CalcTax()
        ' reset tax
        OTax = 0.00

        ' figure tax based on subtotal
        OTax = (OSubtotal + ODeliveryCharge) * TAX_RATE
    End Sub

    ' method to calculate order total
    Private Sub CalcTotal()
        ' reset order total
        OTotal = 0.00

        ' calculate order toal by adding subtotal and tax and charges
        OTotal = OSubtotal + ODeliveryCharge + OTax
    End Sub
End Class