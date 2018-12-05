'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmCheckout.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmCheckout is to ...
Imports EnumLists

Public Class FrmCheckout
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmCarryoutOrDelivery1 As FrmCarryoutOrDelivery = New FrmCarryoutOrDelivery()

    ' property to store the previous form if order type is carryout
    Public FrmCarryoutInformation1 As FrmCarryoutInformation

    ' property to store the next form if order type is delivery
    Public FrmDeliveryInformation1 As FrmDeliveryInformation

    ' property to store the next form if confirmed order
    Public FrmReceipt1 As FrmReceipt
    ' ******************* PUBLIC PROPERTIES END *******************

    ' constructor default form
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' add values to Carryout Or Delivery combobox
        CboCarryoutOrDelivery.DataSource = [Enum].GetValues(GetType(OrderTypeList))
    End Sub

    ' ******************* EVENT LISTENERS BEGIN *******************
    ' event
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        '
        If FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Carryout Then
            ' create new form and set properties for new form
            FrmCarryoutInformation1 = New FrmCarryoutInformation() With {
                .FrmCheckout1 = Me
            }

            '
            PrepareShowNextForm(FrmCarryoutInformation1)
        ElseIf FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Delivery Then
            ' create new form and set properties for new form
            FrmDeliveryInformation1 = New FrmDeliveryInformation() With {
                .FrmCheckout1 = Me
            }

            '
            PrepareShowNextForm(FrmDeliveryInformation1)
        End If
    End Sub

    'event
    Private Sub BtnSubmitOrder_Click(sender As Object, e As EventArgs) Handles BtnSubmitOrder.Click
        '
        'FrmCarryoutOrDelivery1.tempOrder.OCustomer = New Customer(FrmCarryoutOrDelivery1.tempCustomer.CName)

        ' create new form and set properties for new form
        FrmReceipt1 = New FrmReceipt() With {
                .FrmCheckout1 = Me
            }

        '
        PrepareShowNextForm(FrmReceipt1)
    End Sub

    ' event
    Private Sub CboCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        '
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Delivery
        End If

        ' change order details
        PrepareBill()

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
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

        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem

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

    ' method
    Private Sub PrepareShowNextForm(nextForm As Object)
        '
        nextForm.FrmCarryoutOrDelivery1 = FrmCarryoutOrDelivery1

        ' prepare the next form
        nextForm.PrepareForm()

        '
        nextForm.Location = Location

        ' show the next form
        nextForm.Show()

        ' hide current form
        Hide()

        ' close current form
        'Close()
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class