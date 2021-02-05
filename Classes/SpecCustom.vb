'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: SpecCustom.vb
'@version: 1.0
'
'Description
' This 'SpecCustom' Class inherits from the 'Pizza' Class, which inherits from the 'Item' Class. Describes a custom Pizza.

Imports EnumLists

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
        PBakeType = BakeTypeList.Normal
    End Sub

    ' output object contents
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
