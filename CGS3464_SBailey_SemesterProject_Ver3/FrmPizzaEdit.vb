Imports Classes
Imports EnumLists

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmPizzaEdit.vb
'@version: 1.0
'
'Description
' The Purpose of this Form 'FrmPizzaEdit' is to allow the user to modify pizza before submitting pizza to the order.
Public Class FrmPizzaEdit
    '****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public Property FrmMain1 As FrmMain = New FrmMain()

    ' property to store the previous form from specialty choice
    Public Property FrmCustomOrSpecialty1 As FrmCustomOrSpecialty

    ' property to store the previous form from custom choice
    Public Property FrmToppings1 As FrmToppings

    ' property to store the next form
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
    ' event when preiouc button was clicked
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        ' change current pizza options
        ChangePizzaOptions()

        ' if new order new next form
        If FrmToppings1 Is Nothing Then
            ' create new form and set properties for new form
            FrmCustomOrSpecialty1 = New FrmCustomOrSpecialty() With {
                .FrmPizzaEdit1 = Me
            }

            '
            PrepareShowNextForm(FrmCustomOrSpecialty1)
        Else
            ' create new form and set properties for new form
            FrmToppings1 = New FrmToppings() With {
                .FrmPizzaEdit1 = Me
            }

            '
            PrepareShowNextForm(FrmToppings1)
        End If
    End Sub

    ' event when carryout or delivery combobox is changed
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        ' if carryout change to carryout elseif delivery
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmMain1.TempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmMain1.TempOrder.OType = OrderTypeList.Delivery
        End If

        ' set main forms combobox
        FrmMain1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub

    ' event when pizza type is changed
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

        ' uncheck all checkboxes
        For Each cb As Control In Me.Controls
            If TypeOf cb Is CheckBox Then
                DirectCast(cb, CheckBox).Checked = False
            End If
        Next

        ' refresh pizza options
        SetupCurrentPizzaOptions()
    End Sub

    ' event add pizza button is clicked
    Private Sub BtnAddPizza_Click(sender As Object, e As EventArgs) Handles BtnAddPizza.Click
        ' grab values
        ChangePizzaOptions()

        ' create new form and set properties for new form
        FrmMorePizzaOrCheckout1 = New FrmMorePizzaOrCheckout() With {
                .FrmPizzaEdit1 = Me
            }

        '
        FrmMorePizzaOrCheckout1.LstOrder.Items.Clear()

        ' add the pizza to the pizza list of the order
        FrmMain1.TempOrder.OPizzaList.Insert(FrmMain1.TempOrder.OPizzaList.Count, FrmMain1.TempPizza)

        ' call method to prepare next form
        PrepareShowNextForm(FrmMorePizzaOrCheckout1)
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method to prepare form
    Public Sub PrepareForm()
        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmMain1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmMain1.LblOrderNumber.Text

        ' set pizza type
        CboPizzaType.SelectedItem = FrmMain1.CboPizzaType.SelectedItem

        ' set current pizza choices
        SetupCurrentPizzaOptions()
    End Sub

    ' method to setup current pizza choices
    Private Sub SetupCurrentPizzaOptions()
        ' size
        SetupCurrentSize()

        ' crust
        SetupCurrentCrustType()

        ' Sauce
        SetupCurrentSauceType()

        ' cheese
        SetupCurrentCheeseType()

        ' bake
        SetupCurrentBakeType()

        ' toppings
        SetupCurrentToppings()
    End Sub

    ' method method to setup current size
    Private Sub SetupCurrentSize()
        ' populate current size
        If FrmMain1.TempPizza.PSize = PizzaSizeList.Large Then
            RbLarge.Checked = True
        ElseIf FrmMain1.TempPizza.PSize = PizzaSizeList.Medium Then
            RbMedium.Checked = True
        ElseIf FrmMain1.TempPizza.PSize = PizzaSizeList.Small Then
            RbSmall.Checked = True
        End If
    End Sub

    ' method to setup current crust type
    Private Sub SetupCurrentCrustType()
        ' populate current crust
        If FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Pan Then
            RbPan.Checked = True
        ElseIf FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Regular Then
            RbRegular.Checked = True
        ElseIf FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Thin Then
            RbThin.Checked = True
        ElseIf FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Wheat Then
            RbWheat.Checked = True
        End If
    End Sub

    ' method to setup curent sauce type
    Private Sub SetupCurrentSauceType()
        ' populate current sauce
        If FrmMain1.TempPizza.PSauce.SType = SauceTypeList.Traditional Then
            RbTraditional.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.ZestySalsa Then
            RbZestySalsa.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.Buffalo Then
            RbBuffalo.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.BBQ Then
            RbBBQ.Checked = True
        ElseIf FrmMain1.TempPizza.PSauce.SType = SauceTypeList.White Then
            RbWhite.Checked = True
        End If
    End Sub

    ' method to setup current cheese type
    Private Sub SetupCurrentCheeseType()
        ' populate current cheese
        If FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Mozzarella Then
            RbMozzarella.Checked = True
        ElseIf FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Mix Then
            RbMix.Checked = True
        ElseIf FrmMain1.TempPizza.PCheese.ChType = CheeseTypeList.Cheddar Then
            RbCheddar.Checked = True
        End If
    End Sub

    ' method to setup current bake type
    Private Sub SetupCurrentBakeType()
        ' populate current bake type
        If FrmMain1.TempPizza.PBakeType = BakeTypeList.Normal Then
            RbNormal.Checked = True
        ElseIf FrmMain1.TempPizza.PBakeType = BakeTypeList.Well Then
            RbWell.Checked = True
        ElseIf FrmMain1.TempPizza.PBakeType = BakeTypeList.Under Then
            RbUnder.Checked = True
        End If
    End Sub

    ' method to setup current toppings
    Private Sub SetupCurrentToppings()
        ' temp index
        Dim toppingsindex As Integer = 0

        ' temp topping item
        Dim tempTopping As Topping = Nothing

        ' loop through checkboxes
        While (toppingsindex < FrmMain1.TempPizza.PToppingList.Count)
            ' grab the topping
            tempTopping = FrmMain1.TempPizza.PToppingList(toppingsindex)

            ' topping is pepperoni
            If tempTopping.TType = ToppingTypeList.Pepperoni Then
                ChkPepperoni.Checked = True
            End If

            ' topping is Ham
            If tempTopping.TType = ToppingTypeList.Ham Then
                ChkHam.Checked = True
            End If

            ' topping is Sausage
            If tempTopping.TType = ToppingTypeList.Sausage Then
                ChkSausage.Checked = True
            End If

            ' topping is Beef
            If tempTopping.TType = ToppingTypeList.Beef Then
                ChkBeef.Checked = True
            End If

            ' topping is Chicken
            If tempTopping.TType = ToppingTypeList.Chicken Then
                ChkChicken.Checked = True
            End If

            ' topping is Bacon
            If tempTopping.TType = ToppingTypeList.Bacon Then
                ChkBacon.Checked = True
            End If

            ' topping is Onions
            If tempTopping.TType = ToppingTypeList.Onion Then
                ChkOnions.Checked = True
            End If

            ' topping is BellPeppers
            If tempTopping.TType = ToppingTypeList.BellPepper Then
                ChkBellPeppers.Checked = True
            End If

            ' topping is Tomatoes
            If tempTopping.TType = ToppingTypeList.Tomato Then
                ChkTomatoes.Checked = True
            End If

            ' topping is Artichokes
            If tempTopping.TType = ToppingTypeList.Artichoke Then
                ChkArtichokes.Checked = True
            End If

            ' topping is Mushrooms
            If tempTopping.TType = ToppingTypeList.Mushroom Then
                ChkMushrooms.Checked = True
            End If

            ' topping is Olives
            If tempTopping.TType = ToppingTypeList.Olive Then
                ChkOlives.Checked = True
            End If

            ' topping is Lettuce
            If tempTopping.TType = ToppingTypeList.Lettuce Then
                ChkLettuce.Checked = True
            End If

            ' topping is Jalapenos
            If tempTopping.TType = ToppingTypeList.Jalapeno Then
                ChkJalapenos.Checked = True
            End If

            ' topping is BananaPeppers
            If tempTopping.TType = ToppingTypeList.BananaPepper Then
                ChkBananaPeppers.Checked = True
            End If

            ' topping is Pineapple
            If tempTopping.TType = ToppingTypeList.Pineapple Then
                ChkPineapple.Checked = True
            End If

            ' topping is Anchovies
            If tempTopping.TType = ToppingTypeList.Anchovie Then
                ChkAnchovies.Checked = True
            End If

            ' increment toppings index
            toppingsindex += 1
        End While
    End Sub

    ' method to change current options
    Private Sub ChangePizzaOptions()
        ' call method to change pizza size
        ChangePizzaSize()

        ' call method to change pizza crust type
        ChangePizzaCrustType()

        ' call method to change pizza sauce type
        ChangePizzaSauceType()

        ' call method to change pizza cheese type
        ChangePizzaCheeseType()

        ' call method to change pizza bake type
        ChangePizzaBakeType()

        ' call method to change pizza toppings
        ChangePizzaToppings()
    End Sub

    ' method to change current toppings
    Private Sub ChangePizzaToppings()
        ' temp array of toppings
        Dim tempToppingList = New List(Of Topping)

        ' grab topping input
        If ChkPepperoni.Checked = True Then
            ' add Pepperoni
            tempToppingList.Add(New Topping(Topping.PEPPERONI_PRICE, ToppingTypeList.Pepperoni))
        End If

        If ChkHam.Checked = True Then
            ' add Ham
            tempToppingList.Add(New Topping(Topping.HAM_PRICE, ToppingTypeList.Ham))
        End If

        If ChkSausage.Checked = True Then
            ' add Sausage
            tempToppingList.Add(New Topping(Topping.SAUSAGE_PRICE, ToppingTypeList.Sausage))
        End If

        If ChkBeef.Checked = True Then
            ' add Beef
            tempToppingList.Add(New Topping(Topping.BEEF_PRICE, ToppingTypeList.Beef))
        End If

        If ChkChicken.Checked = True Then
            ' add Chicken
            tempToppingList.Add(New Topping(Topping.CHICKEN_PRICE, ToppingTypeList.Chicken))
        End If

        If ChkBacon.Checked = True Then
            ' add Bacon
            tempToppingList.Add(New Topping(Topping.BACON_PRICE, ToppingTypeList.Bacon))
        End If

        If ChkOnions.Checked = True Then
            ' add Onions
            tempToppingList.Add(New Topping(Topping.ONION_PRICE, ToppingTypeList.Onion))
        End If

        If ChkBellPeppers.Checked = True Then
            ' add BellPeppers
            tempToppingList.Add(New Topping(Topping.BELLPEPPER_PRICE, ToppingTypeList.BellPepper))
        End If

        If ChkTomatoes.Checked = True Then
            ' add Tomatoes
            tempToppingList.Add(New Topping(Topping.TOMATO_PRICE, ToppingTypeList.Tomato))
        End If

        If ChkArtichokes.Checked = True Then
            ' add Artichokes
            tempToppingList.Add(New Topping(Topping.ARTICHOKE_PRICE, ToppingTypeList.Artichoke))
        End If

        If ChkMushrooms.Checked = True Then
            ' add Mushrooms
            tempToppingList.Add(New Topping(Topping.MUSHROOM_PRICE, ToppingTypeList.Mushroom))
        End If

        If ChkOlives.Checked = True Then
            ' add Olives
            tempToppingList.Add(New Topping(Topping.OLIVE_PRICE, ToppingTypeList.Olive))
        End If

        If ChkLettuce.Checked = True Then
            ' add Lettuce
            tempToppingList.Add(New Topping(Topping.LETTUCE_PRICE, ToppingTypeList.Lettuce))
        End If

        If ChkJalapenos.Checked = True Then
            ' add Jalapenos
            tempToppingList.Add(New Topping(Topping.JALAPENO_PRICE, ToppingTypeList.Jalapeno))
        End If

        If ChkBananaPeppers.Checked = True Then
            ' add BananaPeppers
            tempToppingList.Add(New Topping(Topping.BANANAPEPPER_PRICE, ToppingTypeList.BananaPepper))
        End If

        If ChkPineapple.Checked = True Then
            ' add Pineapple
            tempToppingList.Add(New Topping(Topping.PINEAPPLE_PRICE, ToppingTypeList.Pineapple))
        End If

        If ChkAnchovies.Checked = True Then
            ' add Anchovies
            tempToppingList.Add(New Topping(Topping.ANCHOVIE_PRICE, ToppingTypeList.Anchovie))
        End If

        ' change the current pizza's topping's list with temporary topping list
        FrmMain1.TempPizza.PToppingList = tempToppingList
    End Sub

    ' method to change pizza bake type
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

    ' method to change current cheese type
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

    ' method to change current sauce type
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

    ' method to change crust type of pizza object
    Private Sub ChangePizzaCrustType()
        ' get crust changes
        If RbPan.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Pan
            FrmMain1.TempPizza.PCrust.IPrice = Crust.PAN_PRICE
        ElseIf RbRegular.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Regular
            FrmMain1.TempPizza.PCrust.IPrice = Crust.REGULAR_PRICE
        ElseIf RbThin.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Thin
            FrmMain1.TempPizza.PCrust.IPrice = Crust.THIN_PRICE
        ElseIf RbWheat.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Wheat
            FrmMain1.TempPizza.PCrust.IPrice = Crust.WHEAT_PRICE
        End If
    End Sub

    ' method to change size of pizza object
    Private Sub ChangePizzaSize()
        ' grab size values
        If RbLarge.Checked = True Then
            FrmMain1.TempPizza.PSize = PizzaSizeList.Large
        ElseIf RbMedium.Checked = True Then
            FrmMain1.TempPizza.PSize = PizzaSizeList.Medium
        ElseIf RbSmall.Checked = True Then
            FrmMain1.TempPizza.PSize = PizzaSizeList.Small
        End If
    End Sub

    ' method
    Private Sub PrepareShowNextForm(nextForm As Object)
        ' set next main form to current main form
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
    ' ******************** CUSTOM METHODS END *********************
End Class