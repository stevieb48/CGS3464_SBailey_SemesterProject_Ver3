Imports EnumLists

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmCheckout.vb
'@version: 1.0
'
'Description
' The Purpose of this Form 'FrmCheckout' is to checkout the customer's order and display a receipt.
Public Class FrmCheckout
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public Property FrmMain1 As FrmMain = New FrmMain()

    ' property to store the previous form if order type is carryout
    Public Property FrmCarryoutInformation1 As FrmCarryoutInformation

    ' property to store the next form if order type is delivery
    Public Property FrmDeliveryInformation1 As FrmDeliveryInformation

    ' property to store the next form if confirmed order
    Public Property FrmReceipt1 As FrmReceipt
    ' ******************* PUBLIC PROPERTIES END *******************

    ' constructor default form
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ' ******************* EVENT LISTENERS BEGIN *******************
    ' event
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        '
        If FrmMain1.TempOrder.OType = OrderTypeList.Carryout Then
            ' create new form and set properties for new form
            FrmCarryoutInformation1 = New FrmCarryoutInformation() With {
                .FrmCheckout1 = Me
            }

            '
            FrmCarryoutInformation1.TxtCarryoutName.Text = FrmMain1.TempOrder.OCustomer.CName

            '

            '
            PrepareShowNextForm(FrmCarryoutInformation1)
        ElseIf FrmMain1.TempOrder.OType = OrderTypeList.Delivery Then
            ' create new form and set properties for new form
            FrmDeliveryInformation1 = New FrmDeliveryInformation() With {
                .FrmCheckout1 = Me
            }

            '
            FrmDeliveryInformation1.TxtDeliveryName.Text = FrmMain1.TempOrder.OCustomer.CName
            FrmDeliveryInformation1.TxtDeliveryStreet.Text = FrmMain1.TempOrder.OCustomer.CStreet
            FrmDeliveryInformation1.TxtDeliveryCity.Text = FrmMain1.TempOrder.OCustomer.CCity
            FrmDeliveryInformation1.TxtZipcode.Text = FrmMain1.TempOrder.OCustomer.CZipcode

            '
            PrepareShowNextForm(FrmDeliveryInformation1)
        End If
    End Sub

    'event
    Private Sub BtnSubmitOrder_Click(sender As Object, e As EventArgs) Handles BtnSubmitOrder.Click
        ' create new form and set properties for new form
        FrmReceipt1 = New FrmReceipt() With {
                .FrmCheckout1 = Me
            }

        '
        PrepareShowNextForm(FrmReceipt1)
    End Sub

    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method
    Public Sub PrepareForm()
        ' if delivery set the rest of the values
        If FrmMain1.TempOrder.OType = OrderTypeList.Delivery Then
            '
            LstCustomerInformation.Items.Insert(0, FrmMain1.TempOrder.OCustomer.CZipcode)

            '
            LstCustomerInformation.Items.Insert(0, FrmMain1.TempOrder.OCustomer.CCity)

            '
            LstCustomerInformation.Items.Insert(0, FrmMain1.TempOrder.OCustomer.CStreet)
        End If

        ' set the order name
        LstCustomerInformation.Items.Insert(0, FrmMain1.TempOrder.OCustomer.CName)

        ' set the combobox to reflect the order type from incoming order
        If FrmMain1.CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            lblOrderType.Text = OrderTypeList.Carryout.ToString
        Else
            lblOrderType.Text = OrderTypeList.Delivery.ToString
        End If

        ' set the label on current form
        LblOrderNumber.Text = FrmMain1.LblOrderNumber.Text

        ' add pizza list to order list box
        LstOrder.Items.AddRange(FrmMain1.TempOrder.OPizzaList.ToArray)

        ' add order details to bill
        PrepareBill()
    End Sub

    '
    Private Sub PrepareBill()
        '
        lblSubtotal.Text = FormatCurrency(FrmMain1.TempOrder.OSubtotal)

        '
        lblTax.Text = FormatCurrency(FrmMain1.TempOrder.OTax)

        '
        lblDeliveryCharge.Text = FormatCurrency(FrmMain1.TempOrder.ODeliveryCharge)

        '
        lblTotal.Text = FormatCurrency(FrmMain1.TempOrder.OTotal)
    End Sub

    ' method
    Private Sub PrepareShowNextForm(nextForm As Object)
        '
        nextForm.FrmMain1 = FrmMain1

        ' prepare the next form
        nextForm.PrepareForm()

        '
        nextForm.Location = Location

        ' show the next form
        nextForm.Show()

        ' hide current form
        Hide()
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class