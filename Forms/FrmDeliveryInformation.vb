'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmDeliveryInformation.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmDeliveryInformation is to ...
Imports Classes
Imports EnumLists

Public Class FrmDeliveryInformation
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmCarryoutOrDelivery1 As FrmCarryoutOrDelivery = New FrmCarryoutOrDelivery()

    ' property to store the next form if custom pizza 
    Public FrmMorePizzaOrCheckout1 As FrmMorePizzaOrCheckout

    ' property to store the next form if custom pizza 
    Public FrmCarryoutInformation1 As FrmCarryoutInformation

    ' property to store the next form if ready to check out
    Public FrmCheckout1 As FrmCheckout
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
                .FrmDeliveryInformation1 = Me
            }

        '
        FrmMorePizzaOrCheckout1.LstOrder.Items.Clear()

        ' call method to prepare next form
        PrepareShowNextForm(FrmMorePizzaOrCheckout1)
    End Sub

    ' event
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            ' validate input
            If AllInputsValid() Then
                ' if valid call next form checkout
                ' create new form and set properties for new form
                FrmCheckout1 = New FrmCheckout() With {
                        .FrmDeliveryInformation1 = Me
                    }
                ' set input variables to order customer variables
                FrmCarryoutOrDelivery1.tempOrder.OCustomer = New Customer(TxtDeliveryName.Text, TxtDeliveryStreet.Text, TxtDeliveryCity.Text, TxtZipcode.Text)

                ' call method to prepare next form
                PrepareShowNextForm(FrmCheckout1)
            Else
                ' tell user to try again
                MessageBox.Show("Please retype your information")

                '
                TxtDeliveryName.Clear()

                '
                TxtDeliveryStreet.Clear()

                '
                TxtDeliveryCity.Clear()

                '
                TxtZipcode.Clear()
            End If
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            '
            ChangeToCarryout()
        End If
    End Sub

    ' event
    Private Sub CboCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        '
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Delivery
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Carryout

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
    Private Sub ChangeToCarryout()
        ' create new form and set properties for new form
        FrmCarryoutInformation1 = New FrmCarryoutInformation() With {
                .FrmDeliveryInformation1 = Me
            }

        '
        PrepareShowNextForm(FrmCarryoutInformation1)
    End Sub

    ' method
    Private Function AllInputsValid() As Boolean
        ' validate name
        If Not IsValidName() Then
            Return False
        End If

        ' validate street
        If Not IsValidStreet() Then
            Return False
        End If

        ' validate city
        If Not IsValidCity() Then
            Return False
        End If

        ' validate zipcode
        If Not IsValidZipcode() Then
            Return False
        End If

        Return True
    End Function

    ' method
    Private Function IsValidZipcode() As Boolean
        ' is valid number
        If FrmCarryoutOrDelivery1.IsValInputNumber(TxtZipcode.Text) Then
            ' is valid zipcode
            If TxtZipcode.Text = 32533 Then
                Return True
            End If
        End If

        ' tell user to try again
        MessageBox.Show("Please retype your zipcode")

        '
        TxtZipcode.Clear()

        '
        Return False
    End Function

    ' method
    Private Function IsValidCity() As Boolean
        '
        If FrmCarryoutOrDelivery1.IsValInputString(TxtDeliveryCity.Text) Then
            Return True
        End If

        ' tell user to try again
        MessageBox.Show("Please retype your city")

        '
        TxtDeliveryCity.Clear()

        '
        Return False
    End Function

    ' method
    Private Function IsValidStreet() As Boolean
        '
        If FrmCarryoutOrDelivery1.IsValidAlphaInput(TxtDeliveryStreet.Text) Then
            Return True
        End If

        ' tell user to try again
        MessageBox.Show("Please retype your street address")

        '
        TxtDeliveryStreet.Clear()

        '
        Return False
    End Function

    ' method
    Private Function IsValidName() As Boolean
        '
        If FrmCarryoutOrDelivery1.IsValInputString(TxtDeliveryName.Text) Then
            Return True
        End If

        ' tell user to try again
        MessageBox.Show("Please retype your name")

        '
        TxtDeliveryName.Clear()

        '
        Return False
    End Function

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
    ' ******************** CUSTOM METHODS END *********************
End Class