'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmCustomOrSpecialty.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmCustomOrSpecialty is to help user decide if its carryout or delivery.
Imports Classes
Imports EnumLists

Public Class FrmCustomOrSpecialty
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmCarryoutOrDelivery1 As FrmCarryoutOrDelivery = New FrmCarryoutOrDelivery()

    ' property to store the next form if custom pizza 
    Public FrmSizeCrustType1 As FrmSizeCrustType

    ' property to store the next form if specialty pizza
    Public FrmPizzaEdit1 As FrmPizzaEdit

    ' property to store the checkout form if adding new pizza to existing order
    Public FrmMorePizzaOrCheckout1 As FrmMorePizzaOrCheckout
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
    End Sub

    ' ******************* EVENT LISTENERS BEGIN *******************
    ' event when CarryoutOrDelivery combox was changed
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        ' carryout or delivery is selected
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Delivery
        End If

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub

    ' event when custom button was clicked
    Private Sub BtnCustom_Click(sender As Object, e As EventArgs) Handles BtnCustom.Click
        ' set current pizza to new custom pizza
        FrmCarryoutOrDelivery1.tempPizza = New SpecCustom(PizzaTypeList.Custom, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem = PizzaTypeList.Custom

        ' custom was clicked so call FrmSizeCrustType
        CallFrmSizeCrustType()
    End Sub

    ' event when meatzo button was clicked
    Private Sub BtnMeatzo_Click(sender As Object, e As EventArgs) Handles BtnMeatzo.Click
        ' set current pizza to new meatzo pizza
        FrmCarryoutOrDelivery1.tempPizza = New SpecMeatzo(PizzaTypeList.Meatzo, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem = PizzaTypeList.Meatzo

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when veggie button was clicked
    Private Sub BtnVeggie_Click(sender As Object, e As EventArgs) Handles BtnVeggie.Click
        ' set current pizza to new veggie pizza
        FrmCarryoutOrDelivery1.tempPizza = New SpecVeggie(PizzaTypeList.Veggie, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem = PizzaTypeList.Veggie

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when surfsup button was clicked
    Private Sub BtnSurfsUp_Click(sender As Object, e As EventArgs) Handles BtnSurfsUp.Click
        ' set current pizza to new surfsup pizza
        FrmCarryoutOrDelivery1.tempPizza = New SpecSurfsUp(PizzaTypeList.SurfsUp, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when supremo button was clicked
    Private Sub BtnSupremo_Click(sender As Object, e As EventArgs) Handles BtnSupremo.Click
        ' set current pizza to new supremo pizza
        FrmCarryoutOrDelivery1.tempPizza = New SpecSupremo(PizzaTypeList.Supremo, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem = PizzaTypeList.Supremo

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when taco button was clicked
    Private Sub BtnTaco_Click(sender As Object, e As EventArgs) Handles BtnTaco.Click
        ' set current pizza to new taco pizza
        FrmCarryoutOrDelivery1.tempPizza = New SpecTaco(PizzaTypeList.Taco, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem = PizzaTypeList.Taco

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method to prepare the form with options chosen so far
    Public Sub PrepareForm()
        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmCarryoutOrDelivery1.LblOrderNumber.Text
    End Sub

    ' method to call next form if custom was clicked
    Private Sub CallFrmSizeCrustType()
        ' create new form and set properties for new form
        FrmSizeCrustType1 = New FrmSizeCrustType() With {
                .FrmCustomOrSpecialty1 = Me,
                .Location = Location
            }

        ' set existing forms property
        FrmSizeCrustType1.FrmCarryoutOrDelivery1 = FrmCarryoutOrDelivery1

        ' prepare and show the next form
        PrepareShowNextForm(FrmSizeCrustType1)
    End Sub

    ' method to call next form if a specialty pizza was clicked
    Private Sub CallFrmPizzaEdit()
        ' create new form and set properties for new form
        FrmPizzaEdit1 = New FrmPizzaEdit() With {
                .FrmCustomOrSpecialty1 = Me,
                .Location = Location
            }

        ' set existing forms property
        FrmPizzaEdit1.FrmCarryoutOrDelivery1 = FrmCarryoutOrDelivery1

        ' prepare and show the next form
        PrepareShowNextForm(FrmPizzaEdit1)
    End Sub

    '
    Private Sub PrepareShowNextForm(nextForm As Object)
        ' prepare the next form
        nextForm.PrepareForm()

        ' show the next form
        nextForm.Show()

        ' hide current form
        Hide()

        ' close current form
        'Close()
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class