'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Pizza.vb
'@version: 1.0
'
'Description
' This 'Pizza' Class is the Base Pizza Class. It inherits from the 'Item' Class. Describes a pizza.
Imports EnumLists

Public MustInherit Class Pizza
    Inherits Item

    ' CONSTANT
    Private Const BASE_PIZZA_PRICE As Double = 12.99

    ' instance properties
    Public Property PName As String
    Public Property PType As PizzaTypeList
    Public Property PSize As PizzaSizeList
    Public Property PCrust As Crust
    Public Property PSauce As Sauce
    Public Property PCheese As Cheese
    Public Property PToppingList As List(Of Topping)
    Public Property PBakeType As BakeTypeList

    ' constructor default
    Public Sub New()
        MyBase.New()
        PName = Nothing
        PType = Nothing
        PSize = Nothing
        PCrust = New Crust()
        PSauce = New Sauce()
        PCheese = New Cheese()
        PBakeType = Nothing
        PToppingList = New List(Of Topping)
    End Sub

    ' constructor pizzas
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(BASE_PIZZA_PRICE)
        PName = Nothing
        PType = pizzaType
        PSize = Nothing
        PCrust = New Crust()
        PSauce = New Sauce()
        PCheese = New Cheese()
        PBakeType = Nothing
        PToppingList = New List(Of Topping)
    End Sub

    ' method to calculate the cost of additional toppings
    Public Overridable Function CalcPizzaCost()
        ' reset pizza cost
        Dim PCost = 0.00

        ' get base pizza cost
        PCost = IPrice

        ' get crust price
        PCost += PCrust.IPrice

        ' get sauce price
        PCost += PSauce.IPrice

        ' get cheese price
        PCost += PCheese.IPrice

        ' call method to calculate toppings price
        PCost += CalcPToppingCost()

        ' return pizza cost
        Return PCost
    End Function

    ' method to calculate the pizza toppings cost
    Private Function CalcPToppingCost()
        ' toppings cost
        Dim PToppingCost = 0.00

        ' figure out the cost of the toppings
        For Each topping As Topping In PToppingList
            PToppingCost += topping.IPrice
        Next

        ' return cost of the toppings
        Return PToppingCost
    End Function

    ' output object contents
    Public Overrides Function ToString() As String
        ' 
        Dim toppingOutput As String = ""

        '
        For Each t As Topping In PToppingList
            toppingOutput = toppingOutput & t.ToString & ","
        Next

        '
        Return PName & " " & MyBase.ToString() & "," & PCrust.ToString() & "," & PSauce.ToString() & "," & PCheese.ToString() & "," & toppingOutput & "  Pizza Cost = " & CalcPizzaCost()
    End Function
End Class