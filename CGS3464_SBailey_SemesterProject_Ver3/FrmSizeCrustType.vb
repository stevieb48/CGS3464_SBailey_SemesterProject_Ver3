Imports Classes
Imports EnumLists

'@author: Stephen Bailey
'course: CGS3464
'assignment: final project
'date: 10/08/2018
'file name: FrmSizeCrustType.vb
'@version: 1.0
'
'Description
' The Purpose of this Form 'FrmSizeCrustType' is to help user decide which size 'pizza' and which type of 'crust'.
Public Class FrmSizeCrustType
    ' ****************** PUBLIC PROPERTIES BEGIN ******************
    ' property to store the main form
    Public Property FrmMain1 As FrmMain = New FrmMain()

    ' property to store the previous form
    Public Property FrmCustomOrSpecialty1 As FrmCustomOrSpecialty

    ' property to store the next form
    Public Property FrmSauceCheeseBake1 As FrmSauceCheeseBake
    ' ******************* PUBLIC PROPERTIES END *******************

    ' constructor default form
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' add values to Carryout Or Delivery combobox
        CboCarryoutOrDelivery.DataSource = [Enum].GetValues(GetType(OrderTypeList))

        ' add values to pizza type combobox
        CboPizzaType.DataSource = [Enum].GetValues(GetType(PizzaTypeList))
    End Sub

    ' ******************* EVENT LISTENERS BEGIN *******************
    ' event when next button is clicked
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        ' get current user changes 
        ChangePizzaOptions()

        ' create new form and set properties for new form
        FrmSauceCheeseBake1 = New FrmSauceCheeseBake() With {
                .FrmSizeCrustType1 = Me
            }

        ' prepare next form
        PrepareShowNextForm(FrmSauceCheeseBake1)
    End Sub

    ' event when the pizzatype combo box is changed
    Private Sub CboPizzaType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPizzaType.SelectedIndexChanged
        ' when pizza type changes
        If CboPizzaType.SelectedItem = PizzaTypeList.Custom Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Custom
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Meatzo Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Meatzo
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Supremo Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Supremo
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.SurfsUp Then
            FrmMain1.TempPizza.PType = PizzaTypeList.SurfsUp
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Taco Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Taco
        ElseIf CboPizzaType.SelectedItem = PizzaTypeList.Veggie Then
            FrmMain1.TempPizza.PType = PizzaTypeList.Veggie
        End If

        ' set main forms combobox
        FrmMain1.CboPizzaType.SelectedItem = CboPizzaType.SelectedItem

        ' refresh pizza options
        SetupCurrentPizzaOptions()
    End Sub

    ' event when CarryoutOrDelivery combox is changed
    Private Sub CbxCarryoutOrDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCarryoutOrDelivery.SelectedIndexChanged
        ' carryout or delivery is selected
        If CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Carryout Then
            FrmMain1.TempOrder.OType = OrderTypeList.Carryout
        ElseIf CboCarryoutOrDelivery.SelectedItem = OrderTypeList.Delivery Then
            FrmMain1.TempOrder.OType = OrderTypeList.Delivery
        End If

        ' set main forms combobox
        FrmMain1.CboCarryoutOrDelivery.SelectedItem = CboCarryoutOrDelivery.SelectedItem
    End Sub

    ' event when previous button is clicked
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        ' get current user changes
        ChangePizzaOptions()

        ' create new form and set properties for new form
        FrmCustomOrSpecialty1 = New FrmCustomOrSpecialty() With {
                .FrmSizeCrustType1 = Me
            }

        ' prepare next form
        PrepareShowNextForm(FrmCustomOrSpecialty1)
    End Sub
    ' ******************** EVENT LISTENERS END ********************
    '
    '
    ' ******************* CUSTOM METHODS BEGIN ********************
    ' method setup the form
    Public Sub PrepareForm()
        ' set the combobox to reflect the order type from incoming order
        CboCarryoutOrDelivery.SelectedItem = FrmMain1.CboCarryoutOrDelivery.SelectedItem

        ' set the label on current form
        LblOrderNumber.Text = FrmMain1.LblOrderNumber.Text

        ' set pizza type
        CboPizzaType.SelectedItem = FrmMain1.CboPizzaType.SelectedItem

        ' call method to setup the form
        SetupCurrentPizzaOptions()
    End Sub

    ' method to change the pizza options
    Private Sub ChangePizzaOptions()
        ' change pizza size
        ChangePizzaSize()

        ' change pizza crust
        ChangePizzaCrustType()
    End Sub

    ' method to setup radio buttons with current pizza options
    Private Sub SetupCurrentPizzaOptions()
        ' size
        SetupCurrentSize()

        ' crust type
        SetupCurrentCrustType()
    End Sub

    ' method to setup radio buttons with current crust type
    Private Sub SetupCurrentCrustType()
        If FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Pan Then
            RbPan.Checked = True
        ElseIf FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Regular Then
            RbRegular.Checked = True
        ElseIf FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Thin Then
            RbThin.Checked = True
        ElseIf FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Wheat Then
            RbWheat.Checked = True
        End If
    End Sub

    ' method to setup radio buttons with current pizza size
    Private Sub SetupCurrentSize()
        If FrmMain1.TempPizza.PSize = PizzaSizeList.Large Then
            RbLarge.Checked = True
        ElseIf FrmMain1.TempPizza.PSize = PizzaSizeList.Medium Then
            RbMedium.Checked = True
        ElseIf FrmMain1.TempPizza.PSize = PizzaSizeList.Small Then
            RbSmall.Checked = True
        End If
    End Sub

    ' method to change size of pizza object
    Private Sub ChangePizzaSize()
        ' get size changes
        If RbLarge.Checked = True Then
            FrmMain1.TempPizza.PSize = PizzaSizeList.Large
        ElseIf RbMedium.Checked = True Then
            FrmMain1.TempPizza.PSize = PizzaSizeList.Medium
        ElseIf RbSmall.Checked = True Then
            FrmMain1.TempPizza.PSize = PizzaSizeList.Small
        End If
    End Sub

    ' method to change crust type of pizza object
    Private Sub ChangePizzaCrustType()
        ' get crust changes
        If RbPan.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Pan
            FrmMain1.TempPizza.PCrust.IPrice = Crust.PAN_PRICE
        ElseIf RbRegular.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Regular
            FrmMain1.TempPizza.PCrust.IPrice = Crust.REGULAR_PRICE
        ElseIf RbThin.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Thin
            FrmMain1.TempPizza.PCrust.IPrice = Crust.THIN_PRICE
        ElseIf RbWheat.Checked = True Then
            FrmMain1.TempPizza.PCrust.CrType = CrustTypeList.Wheat
            FrmMain1.TempPizza.PCrust.IPrice = Crust.WHEAT_PRICE
        End If
    End Sub

    ' method to prepare to show next form
    Private Sub PrepareShowNextForm(nextForm As Object)
        ' set next forms main form to current forms main form
        nextForm.FrmMain1 = FrmMain1

        ' prepare the next form
        nextForm.PrepareForm()

        ' mimick location of current form
        nextForm.Location = Location

        ' show the next form
        nextForm.Show()

        ' hide current form
        Hide()
    End Sub
    ' ******************** CUSTOM METHODS END *********************
End Class