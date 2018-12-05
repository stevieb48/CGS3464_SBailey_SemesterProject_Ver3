'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmReceipt.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmReceipt is to ...
Imports Classes
Imports EnumLists

Public Class FrmReceipt
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form running
    Public FrmCarryoutOrDelivery1 As FrmCarryoutOrDelivery = New FrmCarryoutOrDelivery()

    '
    Public FrmCheckout1 As FrmCheckout
    ' ******************* PUBLIC PROPERTIES END *******************

    ' constructor default form
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    ' ******************* EVENT LISTENERS BEGIN *******************
    '
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        ' reset order and pizza and customer and form
        FrmCarryoutOrDelivery1.Location = Location

        '
        FrmCarryoutOrDelivery1.NumOrders += 1

        '
        FrmCarryoutOrDelivery1.tempOrder = New Order(FrmCarryoutOrDelivery1.NumOrders)

        '
        PrepareShowNextForm(FrmCarryoutOrDelivery1)
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method
    Private Sub PrepareShowNextForm(nextForm As Object)
        ' show the next form
        nextForm.Show()

        ' hide current form
        Hide()

        ' close current form
        'Close()
    End Sub

    ' method
    Public Sub PrepareForm()
        ' if delivery set the rest of the values
        If FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Delivery Then
            '
            LstCustomerInformation.Items.Insert(0, FrmCarryoutOrDelivery1.tempOrder.OCustomer.CZipcode)

            '
            LstCustomerInformation.Items.Insert(0, FrmCarryoutOrDelivery1.tempOrder.OCustomer.CCity)

            '
            LstCustomerInformation.Items.Insert(0, FrmCarryoutOrDelivery1.tempOrder.OCustomer.CStreet)
        End If

        ' set the order name
        LstCustomerInformation.Items.Insert(0, FrmCarryoutOrDelivery1.tempOrder.OCustomer.CName)

        ' set the label on current form
        LblOrderNumber.Text = FrmCarryoutOrDelivery1.LblOrderNumber.Text

        ' add pizza list to order list box
        LstOrder.Items.AddRange(FrmCarryoutOrDelivery1.tempOrder.OPizzaList.ToArray)

        ' add order details to bill
        PrepareBill()
    End Sub

    '
    Private Sub PrepareBill()
        '
        FrmCarryoutOrDelivery1.tempOrder.PrepareODetails()

        '
        lblSubtotal.Text = FormatCurrency(FrmCarryoutOrDelivery1.tempOrder.OSubtotal)

        '
        lblTax.Text = FormatCurrency(FrmCarryoutOrDelivery1.tempOrder.OTax)

        '
        lblDeliveryCharge.Text = FormatCurrency(FrmCarryoutOrDelivery1.tempOrder.ODeliveryCharge)

        '
        lblTotal.Text = FormatCurrency(FrmCarryoutOrDelivery1.tempOrder.OTotal)
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class