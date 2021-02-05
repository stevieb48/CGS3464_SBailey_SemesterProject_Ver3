Imports Classes
Imports EnumLists

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmCustomOrSpecialty.vb
'@version: 1.0
'
'Description
' The Purpose of this Form 'FrmCustomOrSpecialty' is to help user decide if order is carryout or delivery.
Public Class FrmCustomOrSpecialty
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public Property FrmMain1 As FrmMain = New FrmMain()

    ' property to store the next form if custom pizza 
    Public Property FrmSizeCrustType1 As FrmSizeCrustType

    ' property to store the next form if specialty pizza
    Public Property FrmPizzaEdit1 As FrmPizzaEdit

    ' property to store the checkout form if adding new pizza to existing order
    Public Property FrmMorePizzaOrCheckout1 As FrmMorePizzaOrCheckout
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
            FrmMain1.TempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmMain1.TempOrder.OType = OrderTypeList.Delivery
        End If

        ' set main forms combobox
        FrmMain1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub

    ' event when custom button was clicked
    Private Sub BtnCustom_Click(sender As Object, e As EventArgs) Handles BtnCustom.Click
        ' set current pizza to new custom pizza
        FrmMain1.TempPizza = New SpecCustom(PizzaTypeList.Custom, FrmMain1.TempOrder.OPizzaList.Count + FrmMain1.TempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = PizzaTypeList.Custom

        ' custom was clicked so call FrmSizeCrustType
        CallFrmSizeCrustType()
    End Sub

    ' event when meatzo button was clicked
    Private Sub BtnMeatzo_Click(sender As Object, e As EventArgs) Handles BtnMeatzo.Click
        ' set current pizza to new meatzo pizza
        FrmMain1.TempPizza = New SpecMeatzo(PizzaTypeList.Meatzo, FrmMain1.TempOrder.OPizzaList.Count + FrmMain1.TempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = PizzaTypeList.Meatzo

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when veggie button was clicked
    Private Sub BtnVeggie_Click(sender As Object, e As EventArgs) Handles BtnVeggie.Click
        ' set current pizza to new veggie pizza
        FrmMain1.TempPizza = New SpecVeggie(PizzaTypeList.Veggie, FrmMain1.TempOrder.OPizzaList.Count + FrmMain1.TempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = PizzaTypeList.Veggie

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when surfsup button was clicked
    Private Sub BtnSurfsUp_Click(sender As Object, e As EventArgs) Handles BtnSurfsUp.Click
        ' set current pizza to new surfsup pizza
        FrmMain1.TempPizza = New SpecSurfsUp(PizzaTypeList.SurfsUp, FrmMain1.TempOrder.OPizzaList.Count + FrmMain1.TempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when supremo button was clicked
    Private Sub BtnSupremo_Click(sender As Object, e As EventArgs) Handles BtnSupremo.Click
        ' set current pizza to new supremo pizza
        FrmMain1.TempPizza = New SpecSupremo(PizzaTypeList.Supremo, FrmMain1.TempOrder.OPizzaList.Count + FrmMain1.TempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = PizzaTypeList.Supremo

        ' any other pizza button was clicked
        CallFrmPizzaEdit()
    End Sub

    ' event when taco button was clicked
    Private Sub BtnTaco_Click(sender As Object, e As EventArgs) Handles BtnTaco.Click
        ' set current pizza to new taco pizza
        FrmMain1.TempPizza = New SpecTaco(PizzaTypeList.Taco, FrmMain1.TempOrder.OPizzaList.Count + FrmMain1.TempOrder.ONE_PIZZA)

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = PizzaTypeList.Taco

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
        CboCarryoutOrDelivery.SelectedItem = FrmMain1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmMain1.LblOrderNumber.Text
    End Sub

    ' method to call next form if custom was clicked
    Private Sub CallFrmSizeCrustType()
        ' create new form and set properties for new form
        FrmSizeCrustType1 = New FrmSizeCrustType() With {
                .FrmCustomOrSpecialty1 = Me,
                .Location = Location
            }

        ' set existing forms property
        FrmSizeCrustType1.FrmMain1 = FrmMain1

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
        FrmPizzaEdit1.FrmMain1 = FrmMain1

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
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class