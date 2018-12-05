'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Pizza.vb
'@version: 1.0
'
'Description
' This Pizza Class is the Base Pizza Class. It inherits from the Item Class.
Public MustInherit Class Pizza
    Inherits Item

    ' instance properties
    Public Property PName As String
    Public Property PType As PizzaTypeList
    Public Property PSize As PizzaSizeList
    Public Property PCrust As Crust
    Public Property PSauce As Sauce
    Public Property PCheese As Cheese
    Public Property PToppingList As List(Of Topping)
    Public Property OToppingCost As Decimal
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
        OToppingCost = Nothing
    End Sub

    ' constructor custom pizzas
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New()
        PName = Nothing
        PType = pizzaType
        PSize = Nothing
        PCrust = New Crust()
        PSauce = New Sauce()
        PCheese = New Cheese()
        PBakeType = Nothing
        PToppingList = New List(Of Topping)
        OToppingCost = Nothing
    End Sub

    ' constructor specialty pizzas
    Public Sub New(price As Decimal, pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(price)
        PName = Nothing
        PType = pizzaType
        PSize = Nothing
        PCrust = New Crust()
        PSauce = New Sauce()
        PCheese = New Cheese()
        PBakeType = Nothing
        PToppingList = New List(Of Topping)
        OToppingCost = Nothing
    End Sub

    '
    Public Overridable Sub CalcToppingCost()

    End Sub

    '
    Public Overrides Function ToString() As String
        Return vbCrLf & " Pizza Name = " & PName & " ---------------------------------------------" & MyBase.ToString() ' price $
    End Function
End Class