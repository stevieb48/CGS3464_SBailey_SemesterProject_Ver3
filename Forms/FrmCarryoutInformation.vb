'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmCarryoutInformation.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmCarryoutInformation is to ...
Imports Classes
Imports EnumLists

Public Class FrmCarryoutInformation
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmCarryoutOrDelivery1 As FrmCarryoutOrDelivery = New FrmCarryoutOrDelivery()

    '  property to store the previous form 
    Public FrmMorePizzaOrCheckout1 As FrmMorePizzaOrCheckout

    ' property to store the next form if switch to delivery
    Public FrmDeliveryInformation1 As FrmDeliveryInformation

    ' property to store the next form if ready to check out
    Public FrmCheckout1 As FrmCheckout

    Public Property NumOrders As Integer = 0
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
        FrmMorePizzaOrCheckout1 = New FrmMorePizzaOrCheckout() With {
                .FrmCarryoutInformation1 = Me
            }

        '
        FrmMorePizzaOrCheckout1.LstOrder.Items.Clear()

        ' call method to prepare next form
        PrepareShowNextForm(FrmMorePizzaOrCheckout1)
    End Sub

    ' event
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            ' validate input
            If FrmCarryoutOrDelivery1.IsValInputString(TxtCarryoutName.Text) Then
                '
                FrmCarryoutOrDelivery1.tempOrder.OCustomer = New Customer(TxtCarryoutName.Text)

                ' create new form and set properties for new form
                FrmCheckout1 = New FrmCheckout() With {
                        .FrmCarryoutInformation1 = Me
                    }

                ' call method to prepare next form
                PrepareShowNextForm(FrmCheckout1)
            Else
                ' tell user to try again
                MessageBox.Show("Please retype your name")

                '
                TxtCarryoutName.Clear()
            End If
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            '
            ChangeToDelivery()
        End If
    End Sub

    ' event
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        '
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Delivery

            '
            lblAlert.Visible = True

            '
            BtnNext.BackColor = Color.LightGreen
        End If

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
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

        '
        lblAlert.Visible = False

        '
        BtnNext.BackColor = DefaultBackColor
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

    ' method
    Private Sub ChangeToDelivery()
        ' create new form and set properties for new form
        FrmDeliveryInformation1 = New FrmDeliveryInformation() With {
                .FrmCarryoutInformation1 = Me
            }

        '
        PrepareShowNextForm(FrmDeliveryInformation1)
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class