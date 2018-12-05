'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Order.vb
'@version: 1.0
'
'Description
' This Order Class describes a pizza order.
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

    ' constructor
    Public Sub New(type As OrderTypeList)
        ONumOrders += 1
        OCustomer = Nothing
        OOrderNumber = ONumOrders
        OType = type
        OPizzaList = New List(Of Pizza)
        OSubtotal = Nothing
        OTax = Nothing
        OTotal = Nothing
    End Sub

    ' constructor
    Public Sub New(order1 As Order)
        ONumOrders += 1
        OCustomer = Nothing
        OOrderNumber = order1.OOrderNumber
        OType = order1.OType
        OPizzaList = New List(Of Pizza)
        OSubtotal = order1.OSubtotal
        OTax = order1.OTax
        OTotal = order1.OTotal
    End Sub

    '
    Public Sub PrepareODetails()
        '
        CalcSubtotal()

        '
        CalcTax()

        '
        CalcDelCharge()

        '
        CalcTotal()
    End Sub

    ' method to calculate Subtotal
    Private Sub CalcSubtotal()
        '
        OSubtotal = 0.00

        '
        For i As Integer = 0 To OPizzaList.Count - 1
            OPizzaList(i).CalcToppingCost
            OSubtotal = OSubtotal + OPizzaList(i).GetPrice() + OPizzaList(i).OToppingCost
        Next
    End Sub

    ' method to calculate order tax
    Private Sub CalcTax()
        '
        OTax = 0.00

        '
        OTax = OSubtotal * TAX_RATE
    End Sub

    '
    Private Sub CalcDelCharge()
        '
        If OType = OrderTypeList.Carryout Then
            ODeliveryCharge = CARRYOUT_CHARGE
        ElseIf OType = OrderTypeList.Delivery Then
            ODeliveryCharge = DELIVERY_CHARGE
        End If
    End Sub

    ' method to calculate order total
    Private Sub CalcTotal()
        '
        OTotal = 0.00

        '
        OTotal = OSubtotal + OTax + ODeliveryCharge
    End Sub

    '
    Public Overrides Function ToString() As String
        '
        Dim pizzas As String = Nothing
        For Each pizza As Pizza In OPizzaList
            pizzas &= pizza.ToString & vbCrLf
        Next

        '
        Return String.Format(vbCrLf & "Order Number = " & OOrderNumber &
                             vbCrLf & OCustomer.ToString &
                             vbCrLf & "Order Type = " & OType.ToString &
                             vbCrLf & "Pizza List : " & pizzas &
                             vbCrLf & "Order Subtotal = $" & OSubtotal &
                             vbCrLf & "Tax Rate = " & TAX_RATE & " %" &
                             vbCrLf & "Order Tax = $" & OTax &
                             vbCrLf & "Order Total = $" & OTotal)
    End Function
End Class