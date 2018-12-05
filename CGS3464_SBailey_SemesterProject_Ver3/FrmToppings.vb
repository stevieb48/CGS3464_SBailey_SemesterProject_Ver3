'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmToppings.vb
'@version: 1.0
'
'Description
' The Purpose of this Form FrmToppings is to help user decide which Toppings.
Imports Classes
Imports EnumLists

Public Class FrmToppings
    '****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public FrmMain1 As FrmMain = New FrmMain()

    ' property to store the previous form
    Public FrmSauceCheeseBake1 As FrmSauceCheeseBake

    ' property to store the next form
    Public FrmPizzaEdit1 As FrmPizzaEdit
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
        ' if ordertype changes
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmMain1.tempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmMain1.tempOrder.OType = OrderTypeList.Delivery
        End If

        ' set main forms combobox
        FrmMain1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub

    ' event
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        ' change toppings
        ChangePizzaToppings()

        ' create new form and set properties for new form
        FrmPizzaEdit1 = New FrmPizzaEdit() With {
                .FrmToppings1 = Me
            }

        ' call method to show next form and pass new form
        PrepareShowNextForm(FrmPizzaEdit1)
    End Sub

    ' event
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        ' change toppings
        ChangePizzaToppings()

        ' create new form and set properties for new form
        FrmSauceCheeseBake1 = New FrmSauceCheeseBake() With {
                .FrmToppings1 = Me
            }

        ' call method to show previous form and pass new form
        PrepareShowNextForm(FrmSauceCheeseBake1)
    End Sub

    ' event
    Private Sub CboPizzaType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPizzaType.SelectedIndexChanged
        ' when pizza type changes
        If CboPizzaType.SelectedItem = PizzaTypeList.Custom Then
            FrmMain1.tempPizza.PType = PizzaTypeList.Custom
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Meatzo Then
            FrmMain1.tempPizza.PType = PizzaTypeList.Meatzo
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Supremo Then
            FrmMain1.tempPizza.PType = PizzaTypeList.Supremo
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp Then
            FrmMain1.tempPizza.PType = PizzaTypeList.SurfsUp
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Taco Then
            FrmMain1.tempPizza.PType = PizzaTypeList.Taco
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Veggie Then
            FrmMain1.tempPizza.PType = PizzaTypeList.Veggie
        End If

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = CboPizzaType.SelectedItem

        ' uncheck all checkboxes
        For Each cb As Control In Me.Controls
            ' check form for all checkboxes and uncheck them
            If TypeOf cb Is CheckBox Then
                DirectCast(cb, CheckBox).Checked = False
            End If
        Next

        ' refresh pizza options
        SetupCurrentPizzaOptions()
    End Sub
    ' ******************** EVENT LISTENERS END ********************

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

    ' method
    Private Sub SetupCurrentPizzaOptions()
        ' temp index
        Dim toppingsindex As Integer = 0

        ' temp topping item
        Dim tempTopping As Topping = Nothing

        ' loop through checkboxes
        While (toppingsindex < FrmMain1.tempPizza.PToppingList.Count)
            ' grab the topping
            tempTopping = FrmMain1.tempPizza.PToppingList(toppingsindex)

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
        FrmMain1.tempPizza.PToppingList = tempToppingList
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