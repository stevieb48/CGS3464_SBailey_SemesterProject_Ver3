Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecMeatzo.vb
'@version: 1.0
'
'Description
' This SpecMeatzo Class inherits from the Pizza Class, which inherits from the Item Class.
Public Class SpecMeatzo
    Inherits Pizza

    ' CONSTANT
    Private Const SPECMEATZO_PRICE As Decimal = 20.99

    ' constructor default
    Public Sub New(pizzaType As PizzaTypeList, counterValue As Integer)
        MyBase.New(SPECMEATZO_PRICE, pizzaType, counterValue)
        PName = pizzaType.ToString & counterValue
        PType = PizzaTypeList.Meatzo
        PSize = PizzaSizeList.Large
        PCrust = New Crust(Crust.REGULAR_PRICE, CrustTypeList.Regular)
        PSauce = New Sauce(Sauce.TRADITIONAL_PRICE, SauceTypeList.Traditional)
        PCheese = New Cheese(Cheese.MOZZARELLA_PRICE, CheeseTypeList.Mozzarella)
        PToppingList = SetUpDefaultToppingsList()                                      'set toppings
        OToppingCost = Nothing
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

    ' method to calculate the cost of additional toppings
    Public Overrides Sub CalcToppingCost()
        ' build toppings cost
        OToppingCost = 0.00

        ' create 2 arrays lists
        'Dim DefaultToppingList = [Enum].GetValues(GetType(SpecMeatzoDefaultToppingsList))

        ' arraylist build default toppings for default pizza
        Dim DefaultToppingList = SetUpDefaultToppingsList()

        ' stores the difference in current toppings list and default toppings list
        Dim toppingDifference = New List(Of Topping)

        '
        For Each currentTopping As Topping In PToppingList
            For Each defaultTopping As Topping In DefaultToppingList
                If currentTopping.TType = defaultTopping.TType Then
                    For Each differentTopping As Topping In toppingDifference
                        '
                        If currentTopping.TType = differentTopping.TType Then
                            '
                            toppingDifference.Remove(currentTopping)
                        End If
                    Next
                Else
                    For Each differentTopping As Topping In toppingDifference
                        '
                        If currentTopping.TType <> differentTopping.TType Then
                            '
                            toppingDifference.Add(currentTopping)
                        End If
                    Next
                End If
            Next
        Next

        ' figure out the cost of the added toppings
        For Each topping As Topping In toppingDifference
            OToppingCost += topping.GetPrice
        Next
    End Sub

    '
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class