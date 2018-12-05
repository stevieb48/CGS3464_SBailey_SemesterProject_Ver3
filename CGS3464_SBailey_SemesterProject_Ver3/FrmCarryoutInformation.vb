'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmCarryoutInformation.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmCarryoutInformation is to 
' HANDLE obtaining customer information for order type carryout
Imports Classes
Imports EnumLists

Public Class FrmCarryoutInformation
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmMain1 As FrmMain = New FrmMain()

    '  property to store the previous form 
    Public FrmMorePizzaOrCheckout1 As FrmMorePizzaOrCheckout

    ' property to store the next form if switch to delivery
    Public FrmDeliveryInformation1 As FrmDeliveryInformation

    ' property to store the next form if ready to check out
    Public FrmCheckout1 As FrmCheckout

    ' stores the number of orders placed
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
    ' event when previous button clicked
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        ' create new form and set properties for new form
        FrmMorePizzaOrCheckout1 = New FrmMorePizzaOrCheckout() With {
                .FrmCarryoutInformation1 = Me
            }

        ' clear the listbox on next form
        FrmMorePizzaOrCheckout1.LstOrder.Items.Clear()

        ' call method to prepare next form
        PrepareShowNextForm(FrmMorePizzaOrCheckout1)
    End Sub

    ' event when next button clicked
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            ' validate input
            If FrmMain1.IsValInputString(TxtCarryoutName.Text) Then
                ' create new customer set main form customer property
                FrmMain1.tempOrder.OCustomer = New Customer(TxtCarryoutName.Text)

                ' create new form and set properties for new form
                FrmCheckout1 = New FrmCheckout() With {
                        .FrmCarryoutInformation1 = Me
                    }

                ' call method to prepare next form
                PrepareShowNextForm(FrmCheckout1)
            Else
                ' tell user to try again
                MessageBox.Show("Please retype your name")

                ' set button to disabled
                BtnNext.Enabled = False

                ' clear textbox
                TxtCarryoutName.Clear()
            End If
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            ' call method to change to delivery
            ChangeToDelivery()
        End If
    End Sub

    ' event when carryout or delivery combobox is changed
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        'if carryout change to carryout elseif delivery
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmMain1.tempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmMain1.tempOrder.OType = OrderTypeList.Delivery

            ' set main forms combobox
            FrmMain1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem

            ' call method to change to delivery
            ChangeToDelivery()
        End If
    End Sub

    ' enable button when user enters information carryout name text box
    Private Sub TxtCarryoutName_TextChanged(sender As Object, e As EventArgs) Handles TxtCarryoutName.TextChanged
        ' enable button
        BtnNext.Enabled = True
    End Sub

    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method
    Public Sub PrepareForm()
        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmMain1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmMain1.LblOrderNumber.Text

        '
        If TxtCarryoutName.Text = "" Then
            '
            BtnNext.Enabled = False
        End If

        '
        BtnNext.BackColor = DefaultBackColor
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

    ' method
    Private Sub ChangeToDelivery()
        ' create new form and set properties for new form
        FrmDeliveryInformation1 = New FrmDeliveryInformation() With {
                .FrmCarryoutInformation1 = Me
            }

        '
        If TxtCarryoutName.Text <> "" And FrmMain1.IsValidAlphaInput(TxtCarryoutName.Text) Then
            ' set next forms text box
            FrmDeliveryInformation1.TxtDeliveryName.Text = TxtCarryoutName.Text
        Else
            TxtCarryoutName.Text = ""
        End If

        '
        PrepareShowNextForm(FrmDeliveryInformation1)
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class