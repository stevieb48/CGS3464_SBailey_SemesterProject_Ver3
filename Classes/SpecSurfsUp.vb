'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecSurfsUp.vb
'@version: 1.0
'
'Description
' This 'SpecSurfsUp' Class inherits from the 'Pizza' Class, which inherits from the 'Item' Class. Describes a Hawaiian Pizza.

Imports EnumLists

Public Class SpecSurfsUp
    Inherits Pizza

    ' constructor default
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(pizzaType, counterValue)
        PName = pizzaType.ToString & counterValue
        PType = PizzaTypeList.SurfsUp
        PSize = PizzaSizeList.Large
        PCrust = New Crust(Crust.THIN_PRICE, CrustTypeList.Thin)
        PSauce = New Sauce(Sauce.BBQ_PRICE, SauceTypeList.BBQ)
        PCheese = New Cheese(Cheese.MIX_PRICE, CheeseTypeList.Mix)
        PToppingList = SetUpDefaultToppingsList()                                      'set toppings
        PBakeType = BakeTypeList.Normal
    End Sub

    ' method to setup toppings list 
    Private Function SetUpDefaultToppingsList() As List(Of Topping)
        ' add base toppings to toppings list
        Dim tempToppingList = New List(Of Topping) From {
            New Topping(Topping.BACON_PRICE, ToppingTypeList.Bacon),
            New Topping(Topping.BELLPEPPER_PRICE, ToppingTypeList.BellPepper),
            New Topping(Topping.HAM_PRICE, ToppingTypeList.Ham),
            New Topping(Topping.ONION_PRICE, ToppingTypeList.Onion),
            New Topping(Topping.PINEAPPLE_PRICE, ToppingTypeList.Pineapple)
        }

        '
        Return tempToppingList
    End Function

    ' output object contents
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class