Imports Classes
Imports EnumLists
Imports Utilities

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmMain.vb
'@version: 1.0
'
'Description
' The Purpose of this Form 'FrmMain' is to start the application.
Public Class FrmMain
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the next form
    Public Property FrmCustomOrSpecialty1 As FrmCustomOrSpecialty

    ' property to keep track of number of orders placed so far
    Public Property NumOrders As Integer = 0

    ' property to create new order 
    Public Property TempOrder As Order = New Order(NumOrders)

    ' property to create new pizza
    Public Property TempPizza As Pizza

    ' utility used for input validation
    Public Property Validator As ValidationTools = New ValidationTools()
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
        TempOrder.OType = OrderTypeList.Carryout

        ' set the carryout or delivery combobox to reflect carryout
        CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout

        ' call next form method
        CallNextForm()
    End Sub

    ' event when delivery button is clicked
    Private Sub BtnDelivery_Click(sender As Object, e As EventArgs) Handles BtnDelivery.Click
        ' set new order to Delivery 
        TempOrder.OType = OrderTypeList.Delivery

        ' set the carryout or delivery combobox to reflect delivery
        CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery

        ' call next form method
        CallNextForm()
    End Sub

    ' event when carryout or delivery combobox is changed
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        'if carryout change to carryout elseif delivery
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            TempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            TempOrder.OType = OrderTypeList.Delivery
        End If
    End Sub

    ' event when the pizzatype combo box is changed
    Private Sub CboPizzaType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPizzaType.SelectedIndexChanged
        ' when pizza type changes
        If CboPizzaType.SelectedItem = PizzaTypeList.Custom Then
            TempPizza = New SpecCustom(PizzaTypeList.Custom, TempOrder.OPizzaList.Count + TempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Meatzo Then
            TempPizza = New SpecMeatzo(PizzaTypeList.Meatzo, TempOrder.OPizzaList.Count + TempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Supremo Then
            TempPizza = New SpecSupremo(PizzaTypeList.Supremo, TempOrder.OPizzaList.Count + TempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp Then
            TempPizza = New SpecSurfsUp(PizzaTypeList.SurfsUp, TempOrder.OPizzaList.Count + TempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Taco Then
            TempPizza = New SpecTaco(PizzaTypeList.Taco, TempOrder.OPizzaList.Count + TempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Veggie Then
            TempPizza = New SpecVeggie(PizzaTypeList.Veggie, TempOrder.OPizzaList.Count + TempOrder.ONE_PIZZA)
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
        LblOrderNumber.Text = TempOrder.OOrderNumber

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

    ' method to show user an error occurred during user input carryout form and delivery form
    Public Sub ShowErrorMessage()
        MessageBox.Show("*** ERROR ****" & vbCrLf _
                        & vbCrLf _
                        & "**** CANNOT contain spaces or special characters ****")
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class
