<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSauceCheeseBakeType
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSauceCheeseBakeType))
        Me.GrpCheeseType = New System.Windows.Forms.GroupBox()
        Me.RbMix = New System.Windows.Forms.RadioButton()
        Me.RbMozzarella = New System.Windows.Forms.RadioButton()
        Me.RbCheddar = New System.Windows.Forms.RadioButton()
        Me.GrpSauceType = New System.Windows.Forms.GroupBox()
        Me.RbWhite = New System.Windows.Forms.RadioButton()
        Me.RbBBQ = New System.Windows.Forms.RadioButton()
        Me.RbBuffalo = New System.Windows.Forms.RadioButton()
        Me.RbZestySalsa = New System.Windows.Forms.RadioButton()
        Me.RbTraditional = New System.Windows.Forms.RadioButton()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.GrpBakeType = New System.Windows.Forms.GroupBox()
        Me.RbWell = New System.Windows.Forms.RadioButton()
        Me.RbNormal = New System.Windows.Forms.RadioButton()
        Me.RbUnder = New System.Windows.Forms.RadioButton()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.CboPizzaType = New System.Windows.Forms.ComboBox()
        Me.GrpCheeseType.SuspendLayout()
        Me.GrpSauceType.SuspendLayout()
        Me.GrpBakeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpCheeseType
        '
        Me.GrpCheeseType.AutoSize = True
        Me.GrpCheeseType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpCheeseType.Controls.Add(Me.RbMix)
        Me.GrpCheeseType.Controls.Add(Me.RbMozzarella)
        Me.GrpCheeseType.Controls.Add(Me.RbCheddar)
        Me.GrpCheeseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCheeseType.Location = New System.Drawing.Point(413, 258)
        Me.GrpCheeseType.Name = "GrpCheeseType"
        Me.GrpCheeseType.Size = New System.Drawing.Size(134, 104)
        Me.GrpCheeseType.TabIndex = 5
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
        'GrpSauceType
        '
        Me.GrpSauceType.AutoSize = True
        Me.GrpSauceType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpSauceType.Controls.Add(Me.RbWhite)
        Me.GrpSauceType.Controls.Add(Me.RbBBQ)
        Me.GrpSauceType.Controls.Add(Me.RbBuffalo)
        Me.GrpSauceType.Controls.Add(Me.RbZestySalsa)
        Me.GrpSauceType.Controls.Add(Me.RbTraditional)
        Me.GrpSauceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSauceType.Location = New System.Drawing.Point(162, 213)
        Me.GrpSauceType.Name = "GrpSauceType"
        Me.GrpSauceType.Size = New System.Drawing.Size(149, 152)
        Me.GrpSauceType.TabIndex = 6
        Me.GrpSauceType.TabStop = False
        Me.GrpSauceType.Text = "Sauce Type"
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
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(12, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 20
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
        Me.CboCarryoutOrDelivery.TabIndex = 21
        '
        'GrpBakeType
        '
        Me.GrpBakeType.AutoSize = True
        Me.GrpBakeType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpBakeType.Controls.Add(Me.RbWell)
        Me.GrpBakeType.Controls.Add(Me.RbNormal)
        Me.GrpBakeType.Controls.Add(Me.RbUnder)
        Me.GrpBakeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBakeType.Location = New System.Drawing.Point(649, 255)
        Me.GrpBakeType.Name = "GrpBakeType"
        Me.GrpBakeType.Size = New System.Drawing.Size(122, 107)
        Me.GrpBakeType.TabIndex = 22
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
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(800, 513)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(120, 48)
        Me.BtnNext.TabIndex = 23
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(224, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(486, 33)
        Me.LblTitle.TabIndex = 34
        Me.LblTitle.Text = "Edit Sauce, Cheese, and Bake Type"
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
        Me.LblOrderNumber.TabIndex = 36
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
        Me.LblOrderNumberTitle.TabIndex = 35
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
        Me.CboPizzaType.TabIndex = 37
        '
        'FrmSauceCheeseBakeType
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
        Me.Controls.Add(Me.GrpBakeType)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.GrpCheeseType)
        Me.Controls.Add(Me.GrpSauceType)
        Me.Name = "FrmSauceCheeseBakeType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sauce/Cheese/Bake Type"
        Me.GrpCheeseType.ResumeLayout(False)
        Me.GrpCheeseType.PerformLayout()
        Me.GrpSauceType.ResumeLayout(False)
        Me.GrpSauceType.PerformLayout()
        Me.GrpBakeType.ResumeLayout(False)
        Me.GrpBakeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpCheeseType As GroupBox
    Friend WithEvents RbMix As RadioButton
    Friend WithEvents RbMozzarella As RadioButton
    Friend WithEvents RbCheddar As RadioButton
    Friend WithEvents GrpSauceType As GroupBox
    Friend WithEvents RbWhite As RadioButton
    Friend WithEvents RbBBQ As RadioButton
    Friend WithEvents RbBuffalo As RadioButton
    Friend WithEvents RbZestySalsa As RadioButton
    Friend WithEvents RbTraditional As RadioButton
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents GrpBakeType As GroupBox
    Friend WithEvents RbWell As RadioButton
    Friend WithEvents RbNormal As RadioButton
    Friend WithEvents RbUnder As RadioButton
    Friend WithEvents BtnNext As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents CboPizzaType As ComboBox
End Class
