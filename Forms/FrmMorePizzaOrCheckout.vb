'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmMorePizzaOrCheckout.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmPizzaEdit is to ...
Imports EnumLists

Public Class FrmMorePizzaOrCheckout
    ' ************************* CONSTANT **************************
    Dim INDEX_MODIFIER As Integer = 1

    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmCarryoutOrDelivery1 As FrmCarryoutOrDelivery = New FrmCarryoutOrDelivery()

    ' property to store the previous form 
    Public FrmPizzaEdit1 As FrmPizzaEdit

    ' property to store the next form if order type is delivery
    Public FrmDeliveryInformation1 As FrmDeliveryInformation

    ' property to store the next form if order type is carryout
    Public FrmCarryoutInformation1 As FrmCarryoutInformation

    ' property to store the next form if user wants another pizza
    Public FrmCustomOrSpecialty1 As FrmCustomOrSpecialty
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
        ' create new form and set properties for new form
        FrmPizzaEdit1 = New FrmPizzaEdit() With {
                .FrmMorePizzaOrCheckout1 = Me
            }

        '
        PrepareShowNextForm(FrmPizzaEdit1)
    End Sub

    ' event
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
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

    ' event
    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        '
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            ' create new form and set properties for new form
            FrmCarryoutInformation1 = New FrmCarryoutInformation() With {
                .FrmMorePizzaOrCheckout1 = Me
            }

            '
            PrepareShowNextForm(FrmCarryoutInformation1)
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            ' create new form and set properties for new form
            FrmDeliveryInformation1 = New FrmDeliveryInformation() With {
                .FrmMorePizzaOrCheckout1 = Me
            }

            '
            PrepareShowNextForm(FrmDeliveryInformation1)
        End If
    End Sub

    ' event
    Private Sub BtnAddPizza_Click(sender As Object, e As EventArgs) Handles BtnAddPizza.Click
        ' reset pizza
        FrmCarryoutOrDelivery1.tempPizza = Nothing

        ' create new form and set properties for new form
        FrmCarryoutOrDelivery1.FrmCustomOrSpecialty1.FrmMorePizzaOrCheckout1 = Me
        FrmCarryoutOrDelivery1.FrmCustomOrSpecialty1.Location = Location

        '
        PrepareShowNextForm(FrmCarryoutOrDelivery1.FrmCustomOrSpecialty1)
    End Sub

    ' event
    Private Sub BtnEditPizza_Click(sender As Object, e As EventArgs) Handles BtnEditPizza.Click
        ' check selected item in lstbox
        FrmCarryoutOrDelivery1.tempPizza = LstOrder.SelectedItem

        ' remove selected pizza from the order
        FrmCarryoutOrDelivery1.tempOrder.OPizzaList.RemoveAt(LstOrder.SelectedIndex)

        '
        BtnPrevious.PerformClick()
    End Sub

    '
    Private Sub LstOrder_Click(sender As Object, e As EventArgs) Handles LstOrder.Click
        ' enable buttons
        BtnEditPizza.Enabled = True
        BtnDeletePizza.Enabled = True
    End Sub

    '
    Private Sub BtnDeletePizza_Click(sender As Object, e As EventArgs) Handles BtnDeletePizza.Click
        ' remove selected pizza from the order
        FrmCarryoutOrDelivery1.tempOrder.OPizzaList.RemoveAt(LstOrder.SelectedIndex)

        '
        LstOrder.Items.Clear()

        ' refresh current list to order list box
        LstOrder.Items.AddRange(FrmCarryoutOrDelivery1.tempOrder.OPizzaList.ToArray)
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method
    Public Sub PrepareForm()
        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmCarryoutOrDelivery1.LblOrderNumber.Text

        ' disable buttons until user clicks a list item
        BtnEditPizza.Enabled = False
        BtnDeletePizza.Enabled = False

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

    '
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