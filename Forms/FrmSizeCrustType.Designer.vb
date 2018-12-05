<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSizeCrustType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSizeCrustType))
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.GrpCrustType = New System.Windows.Forms.GroupBox()
        Me.RbWheat = New System.Windows.Forms.RadioButton()
        Me.RbThin = New System.Windows.Forms.RadioButton()
        Me.RbRegular = New System.Windows.Forms.RadioButton()
        Me.RbPan = New System.Windows.Forms.RadioButton()
        Me.GrpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.RbLarge = New System.Windows.Forms.RadioButton()
        Me.RbMedium = New System.Windows.Forms.RadioButton()
        Me.RbSmall = New System.Windows.Forms.RadioButton()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.CboPizzaType = New System.Windows.Forms.ComboBox()
        Me.GrpCrustType.SuspendLayout()
        Me.GrpPizzaSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboCarryoutOrDelivery
        '
        Me.CboCarryoutOrDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCarryoutOrDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCarryoutOrDelivery.FormattingEnabled = True
        Me.CboCarryoutOrDelivery.Location = New System.Drawing.Point(12, 12)
        Me.CboCarryoutOrDelivery.Name = "CboCarryoutOrDelivery"
        Me.CboCarryoutOrDelivery.Size = New System.Drawing.Size(121, 28)
        Me.CboCarryoutOrDelivery.TabIndex = 19
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
        Me.GrpCrustType.Location = New System.Drawing.Point(531, 202)
        Me.GrpCrustType.Name = "GrpCrustType"
        Me.GrpCrustType.Size = New System.Drawing.Size(126, 127)
        Me.GrpCrustType.TabIndex = 18
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
        'GrpPizzaSize
        '
        Me.GrpPizzaSize.AutoSize = True
        Me.GrpPizzaSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpPizzaSize.Controls.Add(Me.RbLarge)
        Me.GrpPizzaSize.Controls.Add(Me.RbMedium)
        Me.GrpPizzaSize.Controls.Add(Me.RbSmall)
        Me.GrpPizzaSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpPizzaSize.Location = New System.Drawing.Point(276, 223)
        Me.GrpPizzaSize.Name = "GrpPizzaSize"
        Me.GrpPizzaSize.Size = New System.Drawing.Size(119, 106)
        Me.GrpPizzaSize.TabIndex = 17
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
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(12, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 16
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(800, 513)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(120, 48)
        Me.BtnNext.TabIndex = 20
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(334, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(267, 33)
        Me.LblTitle.TabIndex = 37
        Me.LblTitle.Text = "Edit Size and Crust"
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
        Me.LblOrderNumber.TabIndex = 39
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
        Me.LblOrderNumberTitle.TabIndex = 38
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
        Me.CboPizzaType.TabIndex = 40
        '
        'FrmSizeCrustType
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
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.GrpCrustType)
        Me.Controls.Add(Me.GrpPizzaSize)
        Me.Name = "FrmSizeCrustType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Size/CrustType"
        Me.GrpCrustType.ResumeLayout(False)
        Me.GrpCrustType.PerformLayout()
        Me.GrpPizzaSize.ResumeLayout(False)
        Me.GrpPizzaSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents GrpCrustType As GroupBox
    Friend WithEvents RbWheat As RadioButton
    Friend WithEvents RbThin As RadioButton
    Friend WithEvents RbRegular As RadioButton
    Friend WithEvents RbPan As RadioButton
    Friend WithEvents GrpPizzaSize As GroupBox
    Friend WithEvents RbLarge As RadioButton
    Friend WithEvents RbMedium As RadioButton
    Friend WithEvents RbSmall As RadioButton
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents CboPizzaType As ComboBox
End Class
