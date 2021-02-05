Imports Classes
Imports EnumLists

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmReceipt.vb
'@version: 1.0
'
'Description
' The Purpose of this Form 'FrmReceipt' is to display the details of the completed 'Order'.
Public Class FrmReceipt
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form running
    Public Property FrmMain1 As FrmMain = New FrmMain()

    '
    Public Property FrmCheckout1 As FrmCheckout
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
        ' mimick location
        FrmMain1.Location = Location

        '
        FrmMain1.NumOrders += 1

        '
        FrmMain1.TempOrder = New Order(FrmMain1.NumOrders)

        '
        PrepareShowNextForm(FrmMain1)
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
    End Sub

    ' method
    Public Sub PrepareForm()
        ' if delivery set form controls with values the values
        If FrmMain1.TempOrder.OType = OrderTypeList.Delivery Then
            ' insert into listbox zipcode
            LstCustomerInformation.Items.Insert(0, FrmMain1.TempOrder.OCustomer.CZipcode)

            ' city
            LstCustomerInformation.Items.Insert(0, FrmMain1.TempOrder.OCustomer.CCity)

            ' street
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

    ' method to prepare the bill
    Private Sub PrepareBill()
        ' setup subtotal label
        lblSubtotal.Text = FormatCurrency(FrmMain1.TempOrder.OSubtotal)

        ' tax label
        lblTax.Text = FormatCurrency(FrmMain1.TempOrder.OTax)

        ' delivery charge
        lblDeliveryCharge.Text = FormatCurrency(FrmMain1.TempOrder.ODeliveryCharge)

        ' total
        lblTotal.Text = FormatCurrency(FrmMain1.TempOrder.OTotal)
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class