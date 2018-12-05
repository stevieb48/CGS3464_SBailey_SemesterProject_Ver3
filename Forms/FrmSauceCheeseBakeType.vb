'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmSauceCheeseBakeType.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmSauceCheeseBakeType is to help user decide which Sauce type, Cheese type, bake Type.
Imports Classes
Imports EnumLists

Public Class FrmSauceCheeseBakeType
    '****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmCarryoutOrDelivery1 As FrmCarryoutOrDelivery = New FrmCarryoutOrDelivery()

    ' property to store the previous form
    Public FrmSizeCrustType1 As FrmSizeCrustType

    ' property to store the previous form
    Public FrmToppings1 As FrmToppings
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
    ' event
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmCarryoutOrDelivery1.tempOrder.OType = OrderTypeList.Delivery
        End If

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub

    ' event
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        '
        ChangePizzaOptions()

        ' create new form and set properties for new form
        FrmToppings1 = New FrmToppings() With {
                .FrmSauceCheeseBakeType1 = Me
            }

        '
        PrepareShowNextForm(FrmToppings1)
    End Sub

    ' event
    Private Sub CboPizzaType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPizzaType.SelectedIndexChanged
        If CboPizzaType.SelectedItem = PizzaTypeList.Custom Then
            FrmCarryoutOrDelivery1.tempPizza = New SpecCustom(PizzaTypeList.Custom, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Meatzo Then
            FrmCarryoutOrDelivery1.tempPizza = New SpecMeatzo(PizzaTypeList.Meatzo, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Supremo Then
            FrmCarryoutOrDelivery1.tempPizza = New SpecSupremo(PizzaTypeList.Supremo, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp Then
            FrmCarryoutOrDelivery1.tempPizza = New SpecSurfsUp(PizzaTypeList.SurfsUp, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Taco Then
            FrmCarryoutOrDelivery1.tempPizza = New SpecTaco(PizzaTypeList.Taco, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Veggie Then
            FrmCarryoutOrDelivery1.tempPizza = New SpecVeggie(PizzaTypeList.Veggie, FrmCarryoutOrDelivery1.tempOrder.OPizzaList.Count + FrmCarryoutOrDelivery1.tempOrder.ONE_PIZZA)
        End If

        ' set main forms combobox
        FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem = CboPizzaType.SelectedItem

        ' refresh pizza options
        SetupCurrentPizzaOptions()
    End Sub

    ' event
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        '
        ChangePizzaOptions()

        ' create new form and set properties for new form
        FrmSizeCrustType1 = New FrmSizeCrustType() With {
                .FrmSauceCheeseBakeType1 = Me
            }

        '
        PrepareShowNextForm(FrmSizeCrustType1)
    End Sub
    ' ******************** EVENT LISTENERS END ********************

    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method setup the form
    Public Sub PrepareForm()
        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmCarryoutOrDelivery1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmCarryoutOrDelivery1.LblOrderNumber.Text

        ' set pizza type
        CboPizzaType.SelectedItem = FrmCarryoutOrDelivery1.CboPizzaType.SelectedItem

        ' method to setup the form
        SetupCurrentPizzaOptions()
    End Sub

    ' method
    Private Sub ChangePizzaOptions()
        ' change sauce type
        ChangePizzaSauceType()

        ' change cheese type
        ChangePizzaCheeseType()

        ' change bake type
        ChangePizzaBakeType()
    End Sub

    ' method
    Private Sub SetupCurrentPizzaOptions()
        ' sauce
        SetupCurrentSauceType()

        ' cheese type
        SetupCurrentCheeseType()

        ' bake type
        SetupCurrentBakeType()
    End Sub

    ' method
    Private Sub SetupCurrentBakeType()
        '
        If FrmCarryoutOrDelivery1.tempPizza.PBakeType = BakeTypeList.Normal Then
            RbNormal.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PBakeType = BakeTypeList.Well Then
            RbWell.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PBakeType = BakeTypeList.Under Then
            RbUnder.Checked = True
        End If
    End Sub

    ' method
    Private Sub SetupCurrentCheeseType()
        '
        If FrmCarryoutOrDelivery1.tempPizza.PCheese.ChType = CheeseTypeList.Mozzarella Then
            RbMozzarella.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PCheese.ChType = CheeseTypeList.Mix Then
            RbMix.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PCheese.ChType = CheeseTypeList.Cheddar Then
            RbCheddar.Checked = True
        End If
    End Sub

    ' method
    Private Sub SetupCurrentSauceType()
        '
        If FrmCarryoutOrDelivery1.tempPizza.PSauce.SType = SauceTypeList.Traditional Then
            RbTraditional.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PSauce.SType = SauceTypeList.ZestySalsa Then
            RbZestySalsa.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PSauce.SType = SauceTypeList.White Then
            RbWhite.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PSauce.SType = SauceTypeList.BBQ Then
            RbBBQ.Checked = True
        ElseIf FrmCarryoutOrDelivery1.tempPizza.PSauce.SType = SauceTypeList.Buffalo Then
            RbBuffalo.Checked = True
        End If
    End Sub

    ' method
    Private Sub ChangePizzaSauceType()
        ' grab sauce values
        If RbTraditional.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PSauce = New Sauce(SauceTypeList.Traditional, Sauce.TRADITIONAL_PRICE)
        ElseIf RbZestySalsa.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PSauce = New Sauce(SauceTypeList.ZestySalsa, Sauce.ZESTYSALSA_PRICE)
        ElseIf RbBuffalo.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PSauce = New Sauce(SauceTypeList.Buffalo, Sauce.BUFFALO_PRICE)
        ElseIf RbBBQ.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PSauce = New Sauce(SauceTypeList.BBQ, Sauce.BBQ_PRICE)
        ElseIf RbWhite.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PSauce = New Sauce(SauceTypeList.White, Sauce.WHITE_PRICE)
        End If
    End Sub

    ' method
    Private Sub ChangePizzaCheeseType()
        ' grab cheese values
        If RbMozzarella.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PCheese = New Cheese(CheeseTypeList.Mozzarella, Cheese.MOZZARELLA_PRICE)
        ElseIf RbMix.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PCheese = New Cheese(CheeseTypeList.Mix, Cheese.MIX_PRICE)
        ElseIf RbCheddar.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PCheese = New Cheese(CheeseTypeList.Cheddar, Cheese.CHEDDAR_PRICE)
        End If
    End Sub

    ' method
    Private Sub ChangePizzaBakeType()
        ' grab bake type values
        If RbNormal.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PBakeType = BakeTypeList.Normal
        ElseIf RbWell.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PBakeType = BakeTypeList.Well
        ElseIf RbUnder.Checked = True Then
            FrmCarryoutOrDelivery1.tempPizza.PBakeType = BakeTypeList.Under
        End If
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