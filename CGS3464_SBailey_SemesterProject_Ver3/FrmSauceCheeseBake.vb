﻿Imports Classes
Imports EnumLists

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmSauceCheeseBakeType.vb
'@version: 1.0
'
'Description
' The Purpose of this Form 'FrmSauceCheeseBakeType' is to help user decide which Sauce type, Cheese type, bake Type.
Public Class FrmSauceCheeseBake
    '****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public Property FrmMain1 As FrmMain = New FrmMain()

    ' property to store the previous form
    Public Property FrmSizeCrustType1 As FrmSizeCrustType

    ' property to store the previous form
    Public Property FrmToppings1 As FrmToppings
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
    ' event when CarryoutOrDelivery combox is changed
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmMain1.TempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmMain1.TempOrder.OType = OrderTypeList.Delivery
        End If

        ' set main forms combobox
        FrmMain1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub

    ' event when next button is clicked
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        '
        ChangePizzaOptions()

        ' create new form and set properties for new form
        FrmToppings1 = New FrmToppings() With {
                .FrmSauceCheeseBake1 = Me
            }

        '
        PrepareShowNextForm(FrmToppings1)
    End Sub

    ' event when the pizzatype combo box is changed
    Private Sub CboPizzaType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPizzaType.SelectedIndexChanged
        ' when pizza type changes
        If CboPizzaType.SelectedItem = PizzaTypeList.Custom Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Custom
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Meatzo Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Meatzo
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Supremo Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Supremo
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp Then
            FrmMain1.TempPizza.PType = PizzaTypeList.SurfsUp
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Taco Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Taco
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Veggie Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Veggie
        End If

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = CboPizzaType.SelectedItem

        ' refresh pizza options
        SetupCurrentPizzaOptions()
    End Sub

    ' event when previous button is clicked
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        ' get current user changes
        ChangePizzaOptions()

        ' create new form and set properties for new form
        FrmSizeCrustType1 = New FrmSizeCrustType() With {
                .FrmSauceCheeseBake1 = Me
            }

        ' prepare next form
        PrepareShowNextForm(FrmSizeCrustType1)
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method setup the form
    Public Sub PrepareForm()
        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmMain1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmMain1.LblOrderNumber.Text

        ' set pizza type
        CboPizzaType.SelectedItem = FrmMain1.CboPizzaType.SelectedItem

        ' method to setup the form
        SetupCurrentPizzaOptions()
    End Sub

    ' method to change the pizza options
    Private Sub ChangePizzaOptions()
        ' change sauce type
        ChangePizzaSauceType()

        ' change cheese type
        ChangePizzaCheeseType()

        ' change bake type
        ChangePizzaBakeType()
    End Sub

    ' method to setup form controls with current pizza options
    Private Sub SetupCurrentPizzaOptions()
        ' sauce
        SetupCurrentSauceType()

        ' cheese type
        SetupCurrentCheeseType()

        ' bake type
        SetupCurrentBakeType()
    End Sub

    ' method to set form controls for bake type
    Private Sub SetupCurrentBakeType()
        ' 
        If FrmMain1.TempPizza.PBakeType = BakeTypeList.Normal Then
            RbNormal.Checked = True
        ElseIf FrmMain1.TempPizza.PBakeType = BakeTypeList.Well Then
            RbWell.Checked = True
        ElseIf FrmMain1.TempPizza.PBakeType = BakeTypeList.Under Then
            RbUnder.Checked = True
        End If
    End Sub

    ' method to setup form controls for cheese type
    Private Sub SetupCurrentCheeseType()
        '
        If FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Mozzarella Then
            RbMozzarella.Checked = True
        ElseIf FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Mix Then
            RbMix.Checked = True
        ElseIf FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Cheddar Then
            RbCheddar.Checked = True
        End If
    End Sub

    ' method to setup form controls for sauce type
    Private Sub SetupCurrentSauceType()
        '
        If FrmMain1.TempPizza.PSauce.SType = SauceTypeList.Traditional Then
            RbTraditional.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.ZestySalsa Then
            RbZestySalsa.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.White Then
            RbWhite.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.BBQ Then
            RbBBQ.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.Buffalo Then
            RbBuffalo.Checked = True
        End If
    End Sub

    ' method to change the pizza sauce type
    Private Sub ChangePizzaSauceType()
        ' grab sauce values
        If RbTraditional.Checked = True Then
            FrmMain1.TempPizza.PSauce.SType = SauceTypeList.Traditional
            FrmMain1.TempPizza.PSauce.IPrice = Sauce.TRADITIONAL_PRICE
        ElseIf RbZestySalsa.Checked = True Then
            FrmMain1.TempPizza.PSauce.SType = SauceTypeList.ZestySalsa
            FrmMain1.TempPizza.PSauce.IPrice = Sauce.ZESTYSALSA_PRICE
        ElseIf RbBuffalo.Checked = True Then
            FrmMain1.TempPizza.PSauce.SType = SauceTypeList.Buffalo
            FrmMain1.TempPizza.PSauce.IPrice = Sauce.BUFFALO_PRICE
        ElseIf RbBBQ.Checked = True Then
            FrmMain1.TempPizza.PSauce.SType = SauceTypeList.BBQ
            FrmMain1.TempPizza.PSauce.IPrice = Sauce.BBQ_PRICE
        ElseIf RbWhite.Checked = True Then
            FrmMain1.TempPizza.PSauce.SType = SauceTypeList.White
            FrmMain1.TempPizza.PSauce.IPrice = Sauce.WHITE_PRICE
        End If
    End Sub

    ' method to change the cheese type
    Private Sub ChangePizzaCheeseType()
        ' grab cheese values
        If RbMozzarella.Checked = True Then
            FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Mozzarella
            FrmMain1.TempPizza.PCheese.IPrice = Cheese.MOZZARELLA_PRICE
        ElseIf RbMix.Checked = True Then
            FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Mix
            FrmMain1.TempPizza.PCheese.IPrice = Cheese.MIX_PRICE
        ElseIf RbCheddar.Checked = True Then
            FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Cheddar
            FrmMain1.TempPizza.PCheese.IPrice = Cheese.CHEDDAR_PRICE
        End If
    End Sub

    ' method to change the bake type
    Private Sub ChangePizzaBakeType()
        ' grab bake type values
        If RbNormal.Checked = True Then
            FrmMain1.TempPizza.PBakeType = BakeTypeList.Normal
        ElseIf RbWell.Checked = True Then
            FrmMain1.TempPizza.PBakeType = BakeTypeList.Well
        ElseIf RbUnder.Checked = True Then
            FrmMain1.TempPizza.PBakeType = BakeTypeList.Under
        End If
    End Sub

    ' method to prepare to show next form
    Private Sub PrepareShowNextForm(nextForm As Object)
        ' set next forms main form to current forms main form
        nextForm.FrmMain1 = FrmMain1

        ' prepare the next form
        nextForm.PrepareForm()

        ' mimick location of current form
        nextForm.Location = Location

        ' show the next form
        nextForm.Show()

        ' hide current form
        Hide()
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class