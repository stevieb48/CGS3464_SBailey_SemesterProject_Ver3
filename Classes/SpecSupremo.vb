'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecSupremo.vb
'@version: 1.0
'
'Description
' This 'SpecSupremo' Class inherits from the 'Pizza' Class, which inherits from the 'Item' Class. Describes a Supreme Pizza.

Imports EnumLists

Public Class SpecSupremo
    Inherits Pizza

    ' constructor default
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(pizzaType, counterValue)
        PName = pizzaType.ToString & counterValue
        PType = PizzaTypeList.Supremo
        PSize = PizzaSizeList.Large
        PCrust = New Crust(Crust.PAN_PRICE, CrustTypeList.Pan)
        PSauce = New Sauce(Sauce.TRADITIONAL_PRICE, SauceTypeList.Traditional)
        PCheese = New Cheese(Cheese.MIX_PRICE, CheeseTypeList.Mix)
        PToppingList = SetUpDefaultToppingsList()                                      'set toppings
        PBakeType = BakeTypeList.Normal
    End Sub

    ' method to setup toppings list 
    Private Function SetUpDefaultToppingsList() As List(Of Topping)
        ' add base toppings to toppings list
        Dim tempToppingList = New List(Of Topping) From {
            New Topping(Topping.BEEF_PRICE, ToppingTypeList.Beef),
            New Topping(Topping.BELLPEPPER_PRICE, ToppingTypeList.BellPepper),
            New Topping(Topping.MUSHROOM_PRICE, ToppingTypeList.Mushroom),
            New Topping(Topping.ONION_PRICE, ToppingTypeList.Onion),
            New Topping(Topping.PEPPERONI_PRICE, ToppingTypeList.Pepperoni),
            New Topping(Topping.SAUSAGE_PRICE, ToppingTypeList.Sausage)
        }

        '
        Return tempToppingList
    End Function

    ' output object contents
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class