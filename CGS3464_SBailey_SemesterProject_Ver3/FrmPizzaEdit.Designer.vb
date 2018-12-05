<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPizzaEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPizzaEdit))
        Me.GrpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.RbLarge = New System.Windows.Forms.RadioButton()
        Me.RbMedium = New System.Windows.Forms.RadioButton()
        Me.RbSmall = New System.Windows.Forms.RadioButton()
        Me.GrpCrustType = New System.Windows.Forms.GroupBox()
        Me.RbWheat = New System.Windows.Forms.RadioButton()
        Me.RbThin = New System.Windows.Forms.RadioButton()
        Me.RbRegular = New System.Windows.Forms.RadioButton()
        Me.RbPan = New System.Windows.Forms.RadioButton()
        Me.GbSauceType = New System.Windows.Forms.GroupBox()
        Me.RbWhite = New System.Windows.Forms.RadioButton()
        Me.RbBBQ = New System.Windows.Forms.RadioButton()
        Me.RbBuffalo = New System.Windows.Forms.RadioButton()
        Me.RbZestySalsa = New System.Windows.Forms.RadioButton()
        Me.RbTraditional = New System.Windows.Forms.RadioButton()
        Me.GrpCheeseType = New System.Windows.Forms.GroupBox()
        Me.RbMix = New System.Windows.Forms.RadioButton()
        Me.RbMozzarella = New System.Windows.Forms.RadioButton()
        Me.RbCheddar = New System.Windows.Forms.RadioButton()
        Me.GrpBakeType = New System.Windows.Forms.GroupBox()
        Me.RbWell = New System.Windows.Forms.RadioButton()
        Me.RbNormal = New System.Windows.Forms.RadioButton()
        Me.RbUnder = New System.Windows.Forms.RadioButton()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.BtnAddPizza = New System.Windows.Forms.Button()
        Me.GrpVegetableToppings = New System.Windows.Forms.GroupBox()
        Me.ChkPineapple = New System.Windows.Forms.CheckBox()
        Me.ChkBananaPeppers = New System.Windows.Forms.CheckBox()
        Me.ChkJalapenos = New System.Windows.Forms.CheckBox()
        Me.ChkLettuce = New System.Windows.Forms.CheckBox()
        Me.ChkOlives = New System.Windows.Forms.CheckBox()
        Me.ChkMushrooms = New System.Windows.Forms.CheckBox()
        Me.ChkArtichokes = New System.Windows.Forms.CheckBox()
        Me.ChkTomatoes = New System.Windows.Forms.CheckBox()
        Me.ChkBellPeppers = New System.Windows.Forms.CheckBox()
        Me.ChkOnions = New System.Windows.Forms.CheckBox()
        Me.GrpMeatToppings = New System.Windows.Forms.GroupBox()
        Me.ChkAnchovies = New System.Windows.Forms.CheckBox()
        Me.ChkBacon = New System.Windows.Forms.CheckBox()
        Me.ChkChicken = New System.Windows.Forms.CheckBox()
        Me.ChkBeef = New System.Windows.Forms.CheckBox()
        Me.ChkSausage = New System.Windows.Forms.CheckBox()
        Me.ChkHam = New System.Windows.Forms.CheckBox()
        Me.ChkPepperoni = New System.Windows.Forms.CheckBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.CboPizzaType = New System.Windows.Forms.ComboBox()
        Me.GrpPizzaSize.SuspendLayout()
        Me.GrpCrustType.SuspendLayout()
        Me.GbSauceType.SuspendLayout()
        Me.GrpCheeseType.SuspendLayout()
        Me.GrpBakeType.SuspendLayout()
        Me.GrpVegetableToppings.SuspendLayout()
        Me.GrpMeatToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpPizzaSize
        '
        Me.GrpPizzaSize.AutoSize = True
        Me.GrpPizzaSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpPizzaSize.Controls.Add(Me.RbLarge)
        Me.GrpPizzaSize.Controls.Add(Me.RbMedium)
        Me.GrpPizzaSize.Controls.Add(Me.RbSmall)
        Me.GrpPizzaSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpPizzaSize.Location = New System.Drawing.Point(306, 71)
        Me.GrpPizzaSize.Name = "GrpPizzaSize"
        Me.GrpPizzaSize.Size = New System.Drawing.Size(119, 106)
        Me.GrpPizzaSize.TabIndex = 0
        Me.GrpPizzaSize.TabStop = False
        Me.GrpPizzaSize.Text = "Pizza Size"
        '
        'RbLarge
        '
        Me.RbLarge.AutoSize = True
        Me.RbLarge.Location = New System.Drawing.Point(39, 65)
        Me.RbLarge.Name = "RbLarge"
        Me.RbLarge.Size = New System.Drawing.Size(61, 20)
        Me.RbLarge.TabIndex = 2
        Me.RbLarge.TabStop = True
        Me.RbLarge.Text = "Large"
        Me.RbLarge.UseVisualStyleBackColor = True
        '
        'RbMedium
        '
        Me.RbMedium.AutoSize = True
        Me.RbMedium.Location = New System.Drawing.Point(39, 42)
        Me.RbMedium.Name = "RbMedium"
        Me.RbMedium.Size = New System.Drawing.Size(74, 20)
        Me.RbMedium.TabIndex = 1
        Me.RbMedium.TabStop = True
        Me.RbMedium.Text = "Medium"
        Me.RbMedium.UseVisualStyleBackColor = True
        '
        'RbSmall
        '
        Me.RbSmall.AutoSize = True
        Me.RbSmall.Location = New System.Drawing.Point(39, 19)
        Me.RbSmall.Name = "RbSmall"
        Me.RbSmall.Size = New System.Drawing.Size(60, 20)
        Me.RbSmall.TabIndex = 0
        Me.RbSmall.TabStop = True
        Me.RbSmall.Text = "Small"
        Me.RbSmall.UseVisualStyleBackColor = True
        '
        'GrpCrustType
        '
        Me.GrpCrustType.AutoSize = True
        Me.GrpCrustType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpCrustType.Controls.Add(Me.RbWheat)
        Me.GrpCrustType.Controls.Add(Me.RbThin)
        Me.GrpCrustType.Controls.Add(Me.RbRegular)
        Me.GrpCrustType.Controls.Add(Me.RbPan)
        Me.GrpCrustType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCrustType.Location = New System.Drawing.Point(501, 71)
        Me.GrpCrustType.Name = "GrpCrustType"
        Me.GrpCrustType.Size = New System.Drawing.Size(126, 127)
        Me.GrpCrustType.TabIndex = 3
        Me.GrpCrustType.TabStop = False
        Me.GrpCrustType.Text = "Crust Type"
        '
        'RbWheat
        '
        Me.RbWheat.AutoSize = True
        Me.RbWheat.Location = New System.Drawing.Point(46, 86)
        Me.RbWheat.Name = "RbWheat"
        Me.RbWheat.Size = New System.Drawing.Size(65, 20)
        Me.RbWheat.TabIndex = 3
        Me.RbWheat.TabStop = True
        Me.RbWheat.Text = "Wheat"
        Me.RbWheat.UseVisualStyleBackColor = True
        '
        'RbThin
        '
        Me.RbThin.AutoSize = True
        Me.RbThin.Location = New System.Drawing.Point(46, 63)
        Me.RbThin.Name = "RbThin"
        Me.RbThin.Size = New System.Drawing.Size(52, 20)
        Me.RbThin.TabIndex = 2
        Me.RbThin.TabStop = True
        Me.RbThin.Text = "Thin"
        Me.RbThin.UseVisualStyleBackColor = True
        '
        'RbRegular
        '
        Me.RbRegular.AutoSize = True
        Me.RbRegular.Location = New System.Drawing.Point(46, 40)
        Me.RbRegular.Name = "RbRegular"
        Me.RbRegular.Size = New System.Drawing.Size(74, 20)
        Me.RbRegular.TabIndex = 1
        Me.RbRegular.TabStop = True
        Me.RbRegular.Text = "Regular"
        Me.RbRegular.UseVisualStyleBackColor = True
        '
        'RbPan
        '
        Me.RbPan.AutoSize = True
        Me.RbPan.Location = New System.Drawing.Point(46, 17)
        Me.RbPan.Name = "RbPan"
        Me.RbPan.Size = New System.Drawing.Size(50, 20)
        Me.RbPan.TabIndex = 0
        Me.RbPan.TabStop = True
        Me.RbPan.Text = "Pan"
        Me.RbPan.UseVisualStyleBackColor = True
        '
        'GbSauceType
        '
        Me.GbSauceType.AutoSize = True
        Me.GbSauceType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbSauceType.Controls.Add(Me.RbWhite)
        Me.GbSauceType.Controls.Add(Me.RbBBQ)
        Me.GbSauceType.Controls.Add(Me.RbBuffalo)
        Me.GbSauceType.Controls.Add(Me.RbZestySalsa)
        Me.GbSauceType.Controls.Add(Me.RbTraditional)
        Me.GbSauceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbSauceType.Location = New System.Drawing.Point(205, 215)
        Me.GbSauceType.Name = "GbSauceType"
        Me.GbSauceType.Size = New System.Drawing.Size(149, 152)
        Me.GbSauceType.TabIndex = 4
        Me.GbSauceType.TabStop = False
        Me.GbSauceType.Text = "Sauce Type"
        '
        'RbWhite
        '
        Me.RbWhite.AutoSize = True
        Me.RbWhite.Location = New System.Drawing.Point(46, 111)
        Me.RbWhite.Name = "RbWhite"
        Me.RbWhite.Size = New System.Drawing.Size(60, 20)
        Me.RbWhite.TabIndex = 4
        Me.RbWhite.TabStop = True
        Me.RbWhite.Text = "White"
        Me.RbWhite.UseVisualStyleBackColor = True
        '
        'RbBBQ
        '
        Me.RbBBQ.AutoSize = True
        Me.RbBBQ.Location = New System.Drawing.Point(46, 88)
        Me.RbBBQ.Name = "RbBBQ"
        Me.RbBBQ.Size = New System.Drawing.Size(54, 20)
        Me.RbBBQ.TabIndex = 3
        Me.RbBBQ.TabStop = True
        Me.RbBBQ.Text = "BBQ"
        Me.RbBBQ.UseVisualStyleBackColor = True
        '
        'RbBuffalo
        '
        Me.RbBuffalo.AutoSize = True
        Me.RbBuffalo.Location = New System.Drawing.Point(46, 65)
        Me.RbBuffalo.Name = "RbBuffalo"
        Me.RbBuffalo.Size = New System.Drawing.Size(67, 20)
        Me.RbBuffalo.TabIndex = 2
        Me.RbBuffalo.TabStop = True
        Me.RbBuffalo.Text = "Buffalo"
        Me.RbBuffalo.UseVisualStyleBackColor = True
        '
        'RbZestySalsa
        '
        Me.RbZestySalsa.AutoSize = True
        Me.RbZestySalsa.Location = New System.Drawing.Point(46, 42)
        Me.RbZestySalsa.Name = "RbZestySalsa"
        Me.RbZestySalsa.Size = New System.Drawing.Size(97, 20)
        Me.RbZestySalsa.TabIndex = 1
        Me.RbZestySalsa.TabStop = True
        Me.RbZestySalsa.Text = "Zesty Salsa"
        Me.RbZestySalsa.UseVisualStyleBackColor = True
        '
        'RbTraditional
        '
        Me.RbTraditional.AutoSize = True
        Me.RbTraditional.Location = New System.Drawing.Point(46, 19)
        Me.RbTraditional.Name = "RbTraditional"
        Me.RbTraditional.Size = New System.Drawing.Size(90, 20)
        Me.RbTraditional.TabIndex = 0
        Me.RbTraditional.TabStop = True
        Me.RbTraditional.Text = "Traditional"
        Me.RbTraditional.UseVisualStyleBackColor = True
        '
        'GrpCheeseType
        '
        Me.GrpCheeseType.AutoSize = True
        Me.GrpCheeseType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpCheeseType.Controls.Add(Me.RbMix)
        Me.GrpCheeseType.Controls.Add(Me.RbMozzarella)
        Me.GrpCheeseType.Controls.Add(Me.RbCheddar)
        Me.GrpCheeseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCheeseType.Location = New System.Drawing.Point(413, 242)
        Me.GrpCheeseType.Name = "GrpCheeseType"
        Me.GrpCheeseType.Size = New System.Drawing.Size(134, 104)
        Me.GrpCheeseType.TabIndex = 3
        Me.GrpCheeseType.TabStop = False
        Me.GrpCheeseType.Text = "Cheese Type"
        '
        'RbMix
        '
        Me.RbMix.AutoSize = True
        Me.RbMix.Location = New System.Drawing.Point(37, 63)
        Me.RbMix.Name = "RbMix"
        Me.RbMix.Size = New System.Drawing.Size(46, 20)
        Me.RbMix.TabIndex = 2
        Me.RbMix.TabStop = True
        Me.RbMix.Text = "Mix"
        Me.RbMix.UseVisualStyleBackColor = True
        '
        'RbMozzarella
        '
        Me.RbMozzarella.AutoSize = True
        Me.RbMozzarella.Location = New System.Drawing.Point(37, 40)
        Me.RbMozzarella.Name = "RbMozzarella"
        Me.RbMozzarella.Size = New System.Drawing.Size(91, 20)
        Me.RbMozzarella.TabIndex = 1
        Me.RbMozzarella.TabStop = True
        Me.RbMozzarella.Text = "Mozzarella"
        Me.RbMozzarella.UseVisualStyleBackColor = True
        '
        'RbCheddar
        '
        Me.RbCheddar.AutoSize = True
        Me.RbCheddar.Location = New System.Drawing.Point(37, 17)
        Me.RbCheddar.Name = "RbCheddar"
        Me.RbCheddar.Size = New System.Drawing.Size(78, 20)
        Me.RbCheddar.TabIndex = 0
        Me.RbCheddar.TabStop = True
        Me.RbCheddar.Text = "Cheddar"
        Me.RbCheddar.UseVisualStyleBackColor = True
        '
        'GrpBakeType
        '
        Me.GrpBakeType.AutoSize = True
        Me.GrpBakeType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpBakeType.Controls.Add(Me.RbWell)
        Me.GrpBakeType.Controls.Add(Me.RbNormal)
        Me.GrpBakeType.Controls.Add(Me.RbUnder)
        Me.GrpBakeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBakeType.Location = New System.Drawing.Point(606, 241)
        Me.GrpBakeType.Name = "GrpBakeType"
        Me.GrpBakeType.Size = New System.Drawing.Size(122, 107)
        Me.GrpBakeType.TabIndex = 4
        Me.GrpBakeType.TabStop = False
        Me.GrpBakeType.Text = "Bake Type"
        '
        'RbWell
        '
        Me.RbWell.AutoSize = True
        Me.RbWell.Location = New System.Drawing.Point(46, 66)
        Me.RbWell.Name = "RbWell"
        Me.RbWell.Size = New System.Drawing.Size(53, 20)
        Me.RbWell.TabIndex = 2
        Me.RbWell.TabStop = True
        Me.RbWell.Text = "Well"
        Me.RbWell.UseVisualStyleBackColor = True
        '
        'RbNormal
        '
        Me.RbNormal.AutoSize = True
        Me.RbNormal.Location = New System.Drawing.Point(46, 43)
        Me.RbNormal.Name = "RbNormal"
        Me.RbNormal.Size = New System.Drawing.Size(70, 20)
        Me.RbNormal.TabIndex = 1
        Me.RbNormal.TabStop = True
        Me.RbNormal.Text = "Normal"
        Me.RbNormal.UseVisualStyleBackColor = True
        '
        'RbUnder
        '
        Me.RbUnder.AutoSize = True
        Me.RbUnder.Location = New System.Drawing.Point(46, 20)
        Me.RbUnder.Name = "RbUnder"
        Me.RbUnder.Size = New System.Drawing.Size(63, 20)
        Me.RbUnder.TabIndex = 0
        Me.RbUnder.TabStop = True
        Me.RbUnder.Text = "Under"
        Me.RbUnder.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(12, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 15
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'CboCarryoutOrDelivery
        '
        Me.CboCarryoutOrDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCarryoutOrDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCarryoutOrDelivery.FormattingEnabled = True
        Me.CboCarryoutOrDelivery.Location = New System.Drawing.Point(12, 12)
        Me.CboCarryoutOrDelivery.Name = "CboCarryoutOrDelivery"
        Me.CboCarryoutOrDelivery.Size = New System.Drawing.Size(121, 28)
        Me.CboCarryoutOrDelivery.TabIndex = 16
        '
        'BtnAddPizza
        '
        Me.BtnAddPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPizza.Location = New System.Drawing.Point(800, 513)
        Me.BtnAddPizza.Name = "BtnAddPizza"
        Me.BtnAddPizza.Size = New System.Drawing.Size(120, 48)
        Me.BtnAddPizza.TabIndex = 25
        Me.BtnAddPizza.Text = "Add Pizza"
        Me.BtnAddPizza.UseVisualStyleBackColor = True
        '
        'GrpVegetableToppings
        '
        Me.GrpVegetableToppings.AutoSize = True
        Me.GrpVegetableToppings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpVegetableToppings.Controls.Add(Me.ChkPineapple)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkBananaPeppers)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkJalapenos)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkLettuce)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkOlives)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkMushrooms)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkArtichokes)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkTomatoes)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkBellPeppers)
        Me.GrpVegetableToppings.Controls.Add(Me.ChkOnions)
        Me.GrpVegetableToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpVegetableToppings.Location = New System.Drawing.Point(383, 392)
        Me.GrpVegetableToppings.Name = "GrpVegetableToppings"
        Me.GrpVegetableToppings.Size = New System.Drawing.Size(446, 107)
        Me.GrpVegetableToppings.TabIndex = 14
        Me.GrpVegetableToppings.TabStop = False
        Me.GrpVegetableToppings.Text = "Vegetable Toppings"
        '
        'ChkPineapple
        '
        Me.ChkPineapple.AutoSize = True
        Me.ChkPineapple.Location = New System.Drawing.Point(137, 66)
        Me.ChkPineapple.Name = "ChkPineapple"
        Me.ChkPineapple.Size = New System.Drawing.Size(89, 20)
        Me.ChkPineapple.TabIndex = 9
        Me.ChkPineapple.Text = "Pineapple"
        Me.ChkPineapple.UseVisualStyleBackColor = True
        '
        'ChkBananaPeppers
        '
        Me.ChkBananaPeppers.AutoSize = True
        Me.ChkBananaPeppers.Location = New System.Drawing.Point(137, 43)
        Me.ChkBananaPeppers.Name = "ChkBananaPeppers"
        Me.ChkBananaPeppers.Size = New System.Drawing.Size(129, 20)
        Me.ChkBananaPeppers.TabIndex = 8
        Me.ChkBananaPeppers.Text = "Banana Peppers"
        Me.ChkBananaPeppers.UseVisualStyleBackColor = True
        '
        'ChkJalapenos
        '
        Me.ChkJalapenos.AutoSize = True
        Me.ChkJalapenos.Location = New System.Drawing.Point(137, 20)
        Me.ChkJalapenos.Name = "ChkJalapenos"
        Me.ChkJalapenos.Size = New System.Drawing.Size(91, 20)
        Me.ChkJalapenos.TabIndex = 7
        Me.ChkJalapenos.Text = "Jalapenos"
        Me.ChkJalapenos.UseVisualStyleBackColor = True
        '
        'ChkLettuce
        '
        Me.ChkLettuce.AutoSize = True
        Me.ChkLettuce.Location = New System.Drawing.Point(269, 66)
        Me.ChkLettuce.Name = "ChkLettuce"
        Me.ChkLettuce.Size = New System.Drawing.Size(70, 20)
        Me.ChkLettuce.TabIndex = 6
        Me.ChkLettuce.Text = "Lettuce"
        Me.ChkLettuce.UseVisualStyleBackColor = True
        '
        'ChkOlives
        '
        Me.ChkOlives.AutoSize = True
        Me.ChkOlives.Location = New System.Drawing.Point(375, 20)
        Me.ChkOlives.Name = "ChkOlives"
        Me.ChkOlives.Size = New System.Drawing.Size(65, 20)
        Me.ChkOlives.TabIndex = 5
        Me.ChkOlives.Text = "Olives"
        Me.ChkOlives.UseVisualStyleBackColor = True
        '
        'ChkMushrooms
        '
        Me.ChkMushrooms.AutoSize = True
        Me.ChkMushrooms.Location = New System.Drawing.Point(269, 43)
        Me.ChkMushrooms.Name = "ChkMushrooms"
        Me.ChkMushrooms.Size = New System.Drawing.Size(97, 20)
        Me.ChkMushrooms.TabIndex = 4
        Me.ChkMushrooms.Text = "Mushrooms"
        Me.ChkMushrooms.UseVisualStyleBackColor = True
        '
        'ChkArtichokes
        '
        Me.ChkArtichokes.AutoSize = True
        Me.ChkArtichokes.Location = New System.Drawing.Point(269, 20)
        Me.ChkArtichokes.Name = "ChkArtichokes"
        Me.ChkArtichokes.Size = New System.Drawing.Size(90, 20)
        Me.ChkArtichokes.TabIndex = 3
        Me.ChkArtichokes.Text = "Artichokes"
        Me.ChkArtichokes.UseVisualStyleBackColor = True
        '
        'ChkTomatoes
        '
        Me.ChkTomatoes.AutoSize = True
        Me.ChkTomatoes.Location = New System.Drawing.Point(34, 66)
        Me.ChkTomatoes.Name = "ChkTomatoes"
        Me.ChkTomatoes.Size = New System.Drawing.Size(89, 20)
        Me.ChkTomatoes.TabIndex = 2
        Me.ChkTomatoes.Text = "Tomatoes"
        Me.ChkTomatoes.UseVisualStyleBackColor = True
        '
        'ChkBellPeppers
        '
        Me.ChkBellPeppers.AutoSize = True
        Me.ChkBellPeppers.Location = New System.Drawing.Point(34, 43)
        Me.ChkBellPeppers.Name = "ChkBellPeppers"
        Me.ChkBellPeppers.Size = New System.Drawing.Size(105, 20)
        Me.ChkBellPeppers.TabIndex = 1
        Me.ChkBellPeppers.Text = "Bell Peppers"
        Me.ChkBellPeppers.UseVisualStyleBackColor = True
        '
        'ChkOnions
        '
        Me.ChkOnions.AutoSize = True
        Me.ChkOnions.Location = New System.Drawing.Point(34, 20)
        Me.ChkOnions.Name = "ChkOnions"
        Me.ChkOnions.Size = New System.Drawing.Size(69, 20)
        Me.ChkOnions.TabIndex = 0
        Me.ChkOnions.Text = "Onions"
        Me.ChkOnions.UseVisualStyleBackColor = True
        '
        'GrpMeatToppings
        '
        Me.GrpMeatToppings.AutoSize = True
        Me.GrpMeatToppings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpMeatToppings.Controls.Add(Me.ChkAnchovies)
        Me.GrpMeatToppings.Controls.Add(Me.ChkBacon)
        Me.GrpMeatToppings.Controls.Add(Me.ChkChicken)
        Me.GrpMeatToppings.Controls.Add(Me.ChkBeef)
        Me.GrpMeatToppings.Controls.Add(Me.ChkSausage)
        Me.GrpMeatToppings.Controls.Add(Me.ChkHam)
        Me.GrpMeatToppings.Controls.Add(Me.ChkPepperoni)
        Me.GrpMeatToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMeatToppings.Location = New System.Drawing.Point(104, 392)
        Me.GrpMeatToppings.Name = "GrpMeatToppings"
        Me.GrpMeatToppings.Size = New System.Drawing.Size(273, 107)
        Me.GrpMeatToppings.TabIndex = 5
        Me.GrpMeatToppings.TabStop = False
        Me.GrpMeatToppings.Text = "Meat Toppings"
        '
        'ChkAnchovies
        '
        Me.ChkAnchovies.AutoSize = True
        Me.ChkAnchovies.Location = New System.Drawing.Point(122, 20)
        Me.ChkAnchovies.Name = "ChkAnchovies"
        Me.ChkAnchovies.Size = New System.Drawing.Size(90, 20)
        Me.ChkAnchovies.TabIndex = 6
        Me.ChkAnchovies.Text = "Anchovies"
        Me.ChkAnchovies.UseVisualStyleBackColor = True
        '
        'ChkBacon
        '
        Me.ChkBacon.AutoSize = True
        Me.ChkBacon.Location = New System.Drawing.Point(122, 43)
        Me.ChkBacon.Name = "ChkBacon"
        Me.ChkBacon.Size = New System.Drawing.Size(66, 20)
        Me.ChkBacon.TabIndex = 5
        Me.ChkBacon.Text = "Bacon"
        Me.ChkBacon.UseVisualStyleBackColor = True
        '
        'ChkChicken
        '
        Me.ChkChicken.AutoSize = True
        Me.ChkChicken.Location = New System.Drawing.Point(122, 66)
        Me.ChkChicken.Name = "ChkChicken"
        Me.ChkChicken.Size = New System.Drawing.Size(75, 20)
        Me.ChkChicken.TabIndex = 4
        Me.ChkChicken.Text = "Chicken"
        Me.ChkChicken.UseVisualStyleBackColor = True
        '
        'ChkBeef
        '
        Me.ChkBeef.AutoSize = True
        Me.ChkBeef.Location = New System.Drawing.Point(212, 20)
        Me.ChkBeef.Name = "ChkBeef"
        Me.ChkBeef.Size = New System.Drawing.Size(55, 20)
        Me.ChkBeef.TabIndex = 3
        Me.ChkBeef.Text = "Beef"
        Me.ChkBeef.UseVisualStyleBackColor = True
        '
        'ChkSausage
        '
        Me.ChkSausage.AutoSize = True
        Me.ChkSausage.Location = New System.Drawing.Point(34, 66)
        Me.ChkSausage.Name = "ChkSausage"
        Me.ChkSausage.Size = New System.Drawing.Size(82, 20)
        Me.ChkSausage.TabIndex = 2
        Me.ChkSausage.Text = "Sausage"
        Me.ChkSausage.UseVisualStyleBackColor = True
        '
        'ChkHam
        '
        Me.ChkHam.AutoSize = True
        Me.ChkHam.Location = New System.Drawing.Point(34, 43)
        Me.ChkHam.Name = "ChkHam"
        Me.ChkHam.Size = New System.Drawing.Size(56, 20)
        Me.ChkHam.TabIndex = 1
        Me.ChkHam.Text = "Ham"
        Me.ChkHam.UseVisualStyleBackColor = True
        '
        'ChkPepperoni
        '
        Me.ChkPepperoni.AutoSize = True
        Me.ChkPepperoni.Location = New System.Drawing.Point(34, 20)
        Me.ChkPepperoni.Name = "ChkPepperoni"
        Me.ChkPepperoni.Size = New System.Drawing.Size(90, 20)
        Me.ChkPepperoni.TabIndex = 0
        Me.ChkPepperoni.Text = "Pepperoni"
        Me.ChkPepperoni.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(286, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(362, 33)
        Me.LblTitle.TabIndex = 33
        Me.LblTitle.Text = "Edit Current Pizza Options"
        '
        'LblOrderNumber
        '
        Me.LblOrderNumber.AutoSize = True
        Me.LblOrderNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblOrderNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderNumber.Location = New System.Drawing.Point(72, 46)
        Me.LblOrderNumber.Name = "LblOrderNumber"
        Me.LblOrderNumber.Size = New System.Drawing.Size(38, 18)
        Me.LblOrderNumber.TabIndex = 35
        Me.LblOrderNumber.Text = "1001"
        '
        'LblOrderNumberTitle
        '
        Me.LblOrderNumberTitle.AutoSize = True
        Me.LblOrderNumberTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblOrderNumberTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblOrderNumberTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderNumberTitle.Location = New System.Drawing.Point(12, 46)
        Me.LblOrderNumberTitle.Name = "LblOrderNumberTitle"
        Me.LblOrderNumberTitle.Size = New System.Drawing.Size(54, 18)
        Me.LblOrderNumberTitle.TabIndex = 34
        Me.LblOrderNumberTitle.Text = "Order #"
        '
        'CboPizzaType
        '
        Me.CboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPizzaType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPizzaType.FormattingEnabled = True
        Me.CboPizzaType.Location = New System.Drawing.Point(800, 12)
        Me.CboPizzaType.Name = "CboPizzaType"
        Me.CboPizzaType.Size = New System.Drawing.Size(121, 28)
        Me.CboPizzaType.TabIndex = 36
        '
        'FrmPizzaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 573)
        Me.Controls.Add(Me.CboPizzaType)
        Me.Controls.Add(Me.LblOrderNumber)
        Me.Controls.Add(Me.LblOrderNumberTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnAddPizza)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.GrpVegetableToppings)
        Me.Controls.Add(Me.GrpMeatToppings)
        Me.Controls.Add(Me.GrpBakeType)
        Me.Controls.Add(Me.GrpCheeseType)
        Me.Controls.Add(Me.GbSauceType)
        Me.Controls.Add(Me.GrpCrustType)
        Me.Controls.Add(Me.GrpPizzaSize)
        Me.Name = "FrmPizzaEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pizza Edit"
        Me.GrpPizzaSize.ResumeLayout(False)
        Me.GrpPizzaSize.PerformLayout()
        Me.GrpCrustType.ResumeLayout(False)
        Me.GrpCrustType.PerformLayout()
        Me.GbSauceType.ResumeLayout(False)
        Me.GbSauceType.PerformLayout()
        Me.GrpCheeseType.ResumeLayout(False)
        Me.GrpCheeseType.PerformLayout()
        Me.GrpBakeType.ResumeLayout(False)
        Me.GrpBakeType.PerformLayout()
        Me.GrpVegetableToppings.ResumeLayout(False)
        Me.GrpVegetableToppings.PerformLayout()
        Me.GrpMeatToppings.ResumeLayout(False)
        Me.GrpMeatToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpPizzaSize As GroupBox
    Friend WithEvents RbLarge As RadioButton
    Friend WithEvents RbMedium As RadioButton
    Friend WithEvents RbSmall As RadioButton
    Friend WithEvents GrpCrustType As GroupBox
    Friend WithEvents RbThin As RadioButton
    Friend WithEvents RbRegular As RadioButton
    Friend WithEvents RbPan As RadioButton
    Friend WithEvents RbWheat As RadioButton
    Friend WithEvents GbSauceType As GroupBox
    Friend WithEvents RbWhite As RadioButton
    Friend WithEvents RbBBQ As RadioButton
    Friend WithEvents RbBuffalo As RadioButton
    Friend WithEvents RbZestySalsa As RadioButton
    Friend WithEvents RbTraditional As RadioButton
    Friend WithEvents GrpCheeseType As GroupBox
    Friend WithEvents RbMix As RadioButton
    Friend WithEvents RbMozzarella As RadioButton
    Friend WithEvents RbCheddar As RadioButton
    Friend WithEvents GrpBakeType As GroupBox
    Friend WithEvents RbWell As RadioButton
    Friend WithEvents RbNormal As RadioButton
    Friend WithEvents RbUnder As RadioButton
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents BtnAddPizza As Button
    Friend WithEvents GrpVegetableToppings As GroupBox
    Friend WithEvents ChkPineapple As CheckBox
    Friend WithEvents ChkBananaPeppers As CheckBox
    Friend WithEvents ChkJalapenos As CheckBox
    Friend WithEvents ChkLettuce As CheckBox
    Friend WithEvents ChkOlives As CheckBox
    Friend WithEvents ChkMushrooms As CheckBox
    Friend WithEvents ChkArtichokes As CheckBox
    Friend WithEvents ChkTomatoes As CheckBox
    Friend WithEvents ChkBellPeppers As CheckBox
    Friend WithEvents ChkOnions As CheckBox
    Friend WithEvents GrpMeatToppings As GroupBox
    Friend WithEvents ChkAnchovies As CheckBox
    Friend WithEvents ChkBacon As CheckBox
    Friend WithEvents ChkChicken As CheckBox
    Friend WithEvents ChkBeef As CheckBox
    Friend WithEvents ChkSausage As CheckBox
    Friend WithEvents ChkHam As CheckBox
    Friend WithEvents ChkPepperoni As CheckBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents CboPizzaType As ComboBox
End Class
