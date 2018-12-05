<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmToppings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmToppings))
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.BtnNext = New System.Windows.Forms.Button()
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
        Me.GrpVegetableToppings.SuspendLayout()
        Me.GrpMeatToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(12, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 18
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
        Me.CboCarryoutOrDelivery.TabIndex = 22
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(800, 513)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(120, 48)
        Me.BtnNext.TabIndex = 24
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
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
        Me.GrpVegetableToppings.Location = New System.Drawing.Point(386, 235)
        Me.GrpVegetableToppings.Name = "GrpVegetableToppings"
        Me.GrpVegetableToppings.Size = New System.Drawing.Size(472, 107)
        Me.GrpVegetableToppings.TabIndex = 17
        Me.GrpVegetableToppings.TabStop = False
        Me.GrpVegetableToppings.Text = "Vegetable Toppings"
        '
        'ChkPineapple
        '
        Me.ChkPineapple.AutoSize = True
        Me.ChkPineapple.Location = New System.Drawing.Point(166, 65)
        Me.ChkPineapple.Name = "ChkPineapple"
        Me.ChkPineapple.Size = New System.Drawing.Size(89, 20)
        Me.ChkPineapple.TabIndex = 9
        Me.ChkPineapple.Text = "Pineapple"
        Me.ChkPineapple.UseVisualStyleBackColor = True
        '
        'ChkBananaPeppers
        '
        Me.ChkBananaPeppers.AutoSize = True
        Me.ChkBananaPeppers.Location = New System.Drawing.Point(166, 42)
        Me.ChkBananaPeppers.Name = "ChkBananaPeppers"
        Me.ChkBananaPeppers.Size = New System.Drawing.Size(129, 20)
        Me.ChkBananaPeppers.TabIndex = 8
        Me.ChkBananaPeppers.Text = "Banana Peppers"
        Me.ChkBananaPeppers.UseVisualStyleBackColor = True
        '
        'ChkJalapenos
        '
        Me.ChkJalapenos.AutoSize = True
        Me.ChkJalapenos.Location = New System.Drawing.Point(166, 20)
        Me.ChkJalapenos.Name = "ChkJalapenos"
        Me.ChkJalapenos.Size = New System.Drawing.Size(91, 20)
        Me.ChkJalapenos.TabIndex = 7
        Me.ChkJalapenos.Text = "Jalapenos"
        Me.ChkJalapenos.UseVisualStyleBackColor = True
        '
        'ChkLettuce
        '
        Me.ChkLettuce.AutoSize = True
        Me.ChkLettuce.Location = New System.Drawing.Point(301, 66)
        Me.ChkLettuce.Name = "ChkLettuce"
        Me.ChkLettuce.Size = New System.Drawing.Size(70, 20)
        Me.ChkLettuce.TabIndex = 6
        Me.ChkLettuce.Text = "Lettuce"
        Me.ChkLettuce.UseVisualStyleBackColor = True
        '
        'ChkOlives
        '
        Me.ChkOlives.AutoSize = True
        Me.ChkOlives.Location = New System.Drawing.Point(401, 21)
        Me.ChkOlives.Name = "ChkOlives"
        Me.ChkOlives.Size = New System.Drawing.Size(65, 20)
        Me.ChkOlives.TabIndex = 5
        Me.ChkOlives.Text = "Olives"
        Me.ChkOlives.UseVisualStyleBackColor = True
        '
        'ChkMushrooms
        '
        Me.ChkMushrooms.AutoSize = True
        Me.ChkMushrooms.Location = New System.Drawing.Point(301, 43)
        Me.ChkMushrooms.Name = "ChkMushrooms"
        Me.ChkMushrooms.Size = New System.Drawing.Size(97, 20)
        Me.ChkMushrooms.TabIndex = 4
        Me.ChkMushrooms.Text = "Mushrooms"
        Me.ChkMushrooms.UseVisualStyleBackColor = True
        '
        'ChkArtichokes
        '
        Me.ChkArtichokes.AutoSize = True
        Me.ChkArtichokes.Location = New System.Drawing.Point(301, 21)
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
        Me.GrpMeatToppings.Location = New System.Drawing.Point(75, 235)
        Me.GrpMeatToppings.Name = "GrpMeatToppings"
        Me.GrpMeatToppings.Size = New System.Drawing.Size(283, 107)
        Me.GrpMeatToppings.TabIndex = 16
        Me.GrpMeatToppings.TabStop = False
        Me.GrpMeatToppings.Text = "Meat Toppings"
        '
        'ChkAnchovies
        '
        Me.ChkAnchovies.AutoSize = True
        Me.ChkAnchovies.Location = New System.Drawing.Point(126, 20)
        Me.ChkAnchovies.Name = "ChkAnchovies"
        Me.ChkAnchovies.Size = New System.Drawing.Size(90, 20)
        Me.ChkAnchovies.TabIndex = 6
        Me.ChkAnchovies.Text = "Anchovies"
        Me.ChkAnchovies.UseVisualStyleBackColor = True
        '
        'ChkBacon
        '
        Me.ChkBacon.AutoSize = True
        Me.ChkBacon.Location = New System.Drawing.Point(126, 43)
        Me.ChkBacon.Name = "ChkBacon"
        Me.ChkBacon.Size = New System.Drawing.Size(66, 20)
        Me.ChkBacon.TabIndex = 5
        Me.ChkBacon.Text = "Bacon"
        Me.ChkBacon.UseVisualStyleBackColor = True
        '
        'ChkChicken
        '
        Me.ChkChicken.AutoSize = True
        Me.ChkChicken.Location = New System.Drawing.Point(126, 66)
        Me.ChkChicken.Name = "ChkChicken"
        Me.ChkChicken.Size = New System.Drawing.Size(75, 20)
        Me.ChkChicken.TabIndex = 4
        Me.ChkChicken.Text = "Chicken"
        Me.ChkChicken.UseVisualStyleBackColor = True
        '
        'ChkBeef
        '
        Me.ChkBeef.AutoSize = True
        Me.ChkBeef.Location = New System.Drawing.Point(222, 20)
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
        Me.LblTitle.Location = New System.Drawing.Point(370, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(195, 33)
        Me.LblTitle.TabIndex = 38
        Me.LblTitle.Text = "Edit Toppings"
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
        Me.LblOrderNumber.TabIndex = 40
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
        Me.LblOrderNumberTitle.TabIndex = 39
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
        Me.CboPizzaType.TabIndex = 41
        '
        'FrmToppings
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
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.GrpVegetableToppings)
        Me.Controls.Add(Me.GrpMeatToppings)
        Me.Name = "FrmToppings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Toppings"
        Me.GrpVegetableToppings.ResumeLayout(False)
        Me.GrpVegetableToppings.PerformLayout()
        Me.GrpMeatToppings.ResumeLayout(False)
        Me.GrpMeatToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPrevious As Button
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents BtnNext As Button
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
