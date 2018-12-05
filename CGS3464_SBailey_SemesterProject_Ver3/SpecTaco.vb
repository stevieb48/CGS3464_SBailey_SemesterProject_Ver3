'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecTaco.vb
'@version: 1.0
'
'Description
' This SpecTaco Class inherits from the Pizza Class, which inherits from the Item Class.
Public Class SpecTaco
    Inherits Pizza

    ' CONSTANT
    Private Const SPECTACO_PRICE As Decimal = 21.99

    ' constructor default
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(SPECTACO_PRICE, pizzaType, counterValue)
        PName = pizzaType.ToString & counterValue
        PType = PizzaTypeList.Taco
        PSize = PizzaSizeList.Large
        PCrust = New Crust(Crust.THIN_PRICE, CrustTypeList.Thin)
        PSauce = New Sauce(Sauce.ZESTYSALSA_PRICE, SauceTypeList.ZestySalsa)
        PCheese = New Cheese(Cheese.CHEDDAR_PRICE, CheeseTypeList.Cheddar)
        PToppingList = SetUpDefaultToppingsList()                                      'set toppings
        OToppingCost = Nothing
        PBakeType = BakeTypeList.Normal
    End Sub

    ' method to setup toppings list 
    Private Function SetUpDefaultToppingsList() As List(Of Topping)
        ' add base toppings to toppings list
        Dim tempToppingList = New List(Of Topping) From {
            New Topping(Topping.BEEF_PRICE, ToppingTypeList.Beef),
            New Topping(Topping.BELLPEPPER_PRICE, ToppingTypeList.BellPepper),
            New Topping(Topping.JALAPENO_PRICE, ToppingTypeList.Jalapeno),
            New Topping(Topping.LETTUCE_PRICE, ToppingTypeList.Lettuce),
            New Topping(Topping.OLIVE_PRICE, ToppingTypeList.Olive),
            New Topping(Topping.ONION_PRICE, ToppingTypeList.Onion),
            New Topping(Topping.TOMATO_PRICE, ToppingTypeList.Tomato)
        }

        '
        Return tempToppingList
    End Function

    ' method to calculate the cost of additional toppings
    Public Overrides Sub CalcToppingCost()

    End Sub

    '
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class