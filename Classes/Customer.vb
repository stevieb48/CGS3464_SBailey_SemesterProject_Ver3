'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: Customer.vb
'@version: 1.0
'
'Description
' This 'Customer' Class describes a Customer.
Public Class Customer

    ' instance properties
    Public Property CName As String
    Public Property CStreet As String
    Public Property CCity As String
    Public Property CZipcode As Integer

    ' constructor default
    Public Sub New()
        CName = Nothing
        CStreet = Nothing
        CCity = Nothing
        CZipcode = Nothing
    End Sub

    ' constructor carryout customer
    Public Sub New(name As String)
        CName = name
        CStreet = Nothing
        CCity = Nothing
        CZipcode = Nothing
    End Sub

    ' constructor delivery customer
    Public Sub New(name As String, street As String, city As String, zipcode As Integer)
        CName = name
        CStreet = street
        CCity = city
        CZipcode = zipcode
    End Sub
End Class