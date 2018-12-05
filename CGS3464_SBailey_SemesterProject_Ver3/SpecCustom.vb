'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecCustom.vb
'@version: 1.0
'
'Description
' This SpecCustom Class inherits from the Pizza Class, which inherits from the Item Class. SpecCustom decsribes a custom Pizza.
Public Class SpecCustom
    Inherits Pizza

    ' constructor default
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(pizzaType, counterValue)
        PName = pizzaType.ToString() & counterValue
        PType = PizzaTypeList.Custom
        PSize = PizzaSizeList.Large
        PCrust = New Crust(Crust.PAN_PRICE, CrustTypeList.Pan)
        PSauce = New Sauce(Sauce.TRADITIONAL_PRICE, SauceTypeList.Traditional)
        PCheese = New Cheese(Cheese.MOZZARELLA_PRICE, CheeseTypeList.Mozzarella)
        PToppingList = New List(Of Topping)
        OToppingCost = Nothing
        PBakeType = BakeTypeList.Normal
    End Sub

    '
    Public Overrides Sub CalcToppingCost()
        ' build toppings cost
        OToppingCost = 0.00

        '
        For Each topping As Topping In PToppingList
            OToppingCost += topping.GetPrice
        Next
    End Sub

    '
    Public Overrides Function ToString() As String
        ' build toppings string
        Dim toppings As String = Nothing
        For Each topping As Topping In PToppingList
            toppings &= topping.ToString & " "
        Next

        Return MyBase.ToString() & "\n cr=" & PCrust.ToString & " sc=" & PSauce.ToString & " ch=" & PCheese.ToString & " tp=" & toppings
    End Function
End Class
