'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecVeggie.vb
'@version: 1.0
'
'Description
' This SpecVeggie Class inherits from the Pizza Class, which inherits from the Item Class.
Imports EnumLists

Public Class SpecVeggie
    Inherits Pizza

    ' constructor default
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(pizzaType, counterValue)
        PName = pizzaType.ToString & counterValue
        PType = PizzaTypeList.Veggie
        PSize = PizzaSizeList.Large
        PCrust = New Crust(Crust.WHEAT_PRICE, CrustTypeList.Wheat)
        PSauce = New Sauce(Sauce.WHITE_PRICE, SauceTypeList.White)
        PCheese = New Cheese(Cheese.MOZZARELLA_PRICE, CheeseTypeList.Mozzarella)
        PToppingList = SetUpDefaultToppingsList()                                      'set toppings
        PBakeType = BakeTypeList.Normal
    End Sub

    ' method to setup toppings list 
    Private Function SetUpDefaultToppingsList() As List(Of Topping)
        ' add base toppings to toppings list
        Dim tempToppingList = New List(Of Topping) From {
            New Topping(Topping.ARTICHOKE_PRICE, ToppingTypeList.Artichoke),
            New Topping(Topping.BANANAPEPPER_PRICE, ToppingTypeList.BananaPepper),
            New Topping(Topping.BELLPEPPER_PRICE, ToppingTypeList.BellPepper),
            New Topping(Topping.MUSHROOM_PRICE, ToppingTypeList.Mushroom),
            New Topping(Topping.OLIVE_PRICE, ToppingTypeList.Olive),
            New Topping(Topping.ONION_PRICE, ToppingTypeList.Onion),
            New Topping(Topping.TOMATO_PRICE, ToppingTypeList.Tomato)
        }

        '
        Return tempToppingList
    End Function

    ' output object contents
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class