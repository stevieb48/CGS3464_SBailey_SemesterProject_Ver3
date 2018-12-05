'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmCarryoutOrDelivery.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmCarryoutOrDelivery is to start the application.
Imports Classes
Imports EnumLists

Public Class FrmMain
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the next form
    Public FrmCustomOrSpecialty1 As FrmCustomOrSpecialty

    ' keep track of number of orders
    Public Property NumOrders As Integer = 0

    ' create new order 
    Public tempOrder As Order = New Order(NumOrders)

    ' property to store a pizza
    Public tempPizza As Pizza
    ' ******************* PUBLIC PROPERTIES END *******************

    ' constructor default form
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' add values to Carryout Or Delivery combobox
        CboCarryoutOrDelivery.DataSource = [Enum].GetValues(GetType(OrderTypeList))

        ' add values to pizza type combobox
        CboPizzaType.DataSource = [Enum].GetValues(GetType(PizzaTypeList))

        ' call method to initialize Controls NOT visible
        SetControlsVisibilityFalse()
    End Sub

    ' ******************* EVENT LISTENERS BEGIN *******************
    ' event when carryout button is clicked
    Private Sub BtnCarryout_Click(sender As Object, e As EventArgs) Handles BtnCarryout.Click
        ' set new order to carryout
        tempOrder.OType = OrderTypeList.Carryout

        ' set the carryout or delivery combobox to carryout
        CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout

        ' call next form method
        CallNextForm()
    End Sub

    ' event when delivery button is clicked
    Private Sub BtnDelivery_Click(sender As Object, e As EventArgs) Handles BtnDelivery.Click
        ' set new order to Delivery 
        tempOrder.OType = OrderTypeList.Delivery

        ' set the carryout or delivery combobox to delivery
        CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery

        ' call next form method
        CallNextForm()
    End Sub

    ' event when carryout or delivery combobox is changed
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        'if carryout change to carryout elseif delivery
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            tempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            tempOrder.OType = OrderTypeList.Delivery
        End If
    End Sub

    ' event when the pizzatype combo box is changed
    Private Sub CboPizzaType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPizzaType.SelectedIndexChanged
        ' when pizza type changes
        If CboPizzaType.SelectedItem = PizzaTypeList.Custom Then
            tempPizza = New SpecCustom(PizzaTypeList.Custom, tempOrder.OPizzaList.Count + tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Meatzo Then
            tempPizza = New SpecMeatzo(PizzaTypeList.Meatzo, tempOrder.OPizzaList.Count + tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Supremo Then
            tempPizza = New SpecSupremo(PizzaTypeList.Supremo, tempOrder.OPizzaList.Count + tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp Then
            tempPizza = New SpecSurfsUp(PizzaTypeList.SurfsUp, tempOrder.OPizzaList.Count + tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Taco Then
            tempPizza = New SpecTaco(PizzaTypeList.Taco, tempOrder.OPizzaList.Count + tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Veggie Then
            tempPizza = New SpecVeggie(PizzaTypeList.Veggie, tempOrder.OPizzaList.Count + tempOrder.ONE_PIZZA)
        End If
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method to initialize Controls NOT visible
    Private Sub SetControlsVisibilityFalse()
        ' set CarryoutOrDelivery invisible
        CboCarryoutOrDelivery.Visible = False

        ' set PizzaType invisible
        CboPizzaType.Visible = False

        ' set OrderNumber Title invisible
        LblOrderNumberTitle.Visible = False

        ' set OrderNumber invisible
        LblOrderNumber.Visible = False
    End Sub

    ' method to call next form
    Private Sub CallNextForm()
        ' set order number
        LblOrderNumber.Text = tempOrder.OOrderNumber

        ' set existing next form and set properties for existing next form
        FrmCustomOrSpecialty1 = New FrmCustomOrSpecialty With {
            .FrmMain1 = Me
        }

        ' mimick location
        FrmCustomOrSpecialty1.Location = Location

        ' prepare the next form
        FrmCustomOrSpecialty1.PrepareForm()

        ' show the next form
        FrmCustomOrSpecialty1.Show()

        ' hide current form
        Hide()
    End Sub
    ' ******************** CUSTOM METHODS END *********************
    '
    '
    ' ***************** UTILITIES METHODS BEGIN *******************
    '
    ' method to validate string input
    Public Function IsValInputString(input As String) As Boolean
        ' see if valid
        If input = String.Empty Then                    ' if blank
            ' error to user
            BlankError()

            ' return false
            Return False
        ElseIf IsValidAlphaInput(input) Then
            ' return true
            Return True
        Else
            ' error to user
            SpecialCharacterError()

            ' return false
            Return False
        End If
    End Function

    ' method to validate string input against special characters
    Public Function IsValidAlphaInput(input As String) As Boolean
        ' loop through input string checking if each character is a letter
        For i = 0 To input.Length - 1
            If Char.IsLetter(input.Chars(i)) Then
                Return True
            End If
        Next

        ' return false
        Return False
    End Function

    ' method to validate numerical input
    Public Function IsValidNumericInput(input As String) As Boolean
        ' loop through input string checking if each character is a digit
        For i = 0 To input.Length - 1
            If Char.IsDigit(input.Chars(i)) Then
                Return True
            End If
        Next

        ' return false
        Return False
    End Function

    ' method to validate numerical input
    Public Function IsValInputNumber(input As String) As Boolean
        ' see if valid
        If String.IsNullOrEmpty(input) Then             ' if null or blank
            ' error to user
            BlankError()

            ' return false
            Return False
        ElseIf IsValidNumericInput(input) Then
            ' return true
            Return True
        Else
            ' error to user
            SpecialCharacterError()

            ' return true flag
            Return False
        End If
    End Function

    ' method to display error message to user regarding special characters
    Private Sub SpecialCharacterError()
        ' error to user
        MessageBox.Show("*** ERROR ****" & vbCrLf _
                        & vbCrLf _
                        & "**** CANNOT be a special characters - Please try again ****")
    End Sub

    ' method to display error message to user regarding blank input
    Private Sub BlankError()
        ' error to user
        MessageBox.Show("*** ERROR ****" & vbCrLf _
                        & vbCrLf _
                        & "**** CANNOT be blank - Please try again ****")
    End Sub
    ' ****************** UTILITIES METHODS END ********************
End Class
