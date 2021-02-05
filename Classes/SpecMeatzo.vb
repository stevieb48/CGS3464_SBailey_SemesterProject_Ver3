'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecMeatzo.vb
'@version: 1.0
'
'Description
' This 'SpecMeatzo' Class inherits from the 'Pizza' Class, which inherits from the 'Item' Class. Describes an all meat Pizza.

Imports EnumLists

Public Class SpecMeatzo
    Inherits Pizza

    ' constructor default
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(pizzaType, counterValue)
        PName = pizzaType.ToString & counterValue
        PType = PizzaTypeList.Meatzo
        PSize = PizzaSizeList.Large
        PCrust = New Crust(Crust.REGULAR_PRICE, CrustTypeList.Regular)
        PSauce = New Sauce(Sauce.TRADITIONAL_PRICE, SauceTypeList.Traditional)
        PCheese = New Cheese(Cheese.MOZZARELLA_PRICE, CheeseTypeList.Mozzarella)
        PToppingList = SetUpDefaultToppingsList()                                      'set toppings
        PBakeType = BakeTypeList.Normal
    End Sub

    ' method to setup toppings list 
    Private Function SetUpDefaultToppingsList() As List(Of Topping)
        ' add base toppings to toppings list
        Dim tempToppingList = New List(Of Topping) From {
            New Topping(Topping.BACON_PRICE, ToppingTypeList.Bacon),
            New Topping(Topping.BEEF_PRICE, ToppingTypeList.Beef),
            New Topping(Topping.CHICKEN_PRICE, ToppingTypeList.Chicken),
            New Topping(Topping.HAM_PRICE, ToppingTypeList.Ham),
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