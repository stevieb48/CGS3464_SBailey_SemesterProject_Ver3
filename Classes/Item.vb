'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Item.vb
'@version: 1.0
'
'Description
' This 'Item' Class is a Base Class. The main purpose is to store Price for various Types of Items.
Public MustInherit Class Item

    ' property
    Public Property IPrice As Double

    ' constructor default
    Public Sub New()
        IPrice = Nothing
    End Sub

    ' constructor item parameter price
    Public Sub New(price As Double)
        IPrice = price
    End Sub

    ' output object contents
    Public Overrides Function ToString() As String
        Return String.Format(IPrice.ToString("C2"))
    End Function
End Class