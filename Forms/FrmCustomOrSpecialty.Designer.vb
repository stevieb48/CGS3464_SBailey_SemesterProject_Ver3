<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomOrSpecialty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomOrSpecialty))
        Me.BtnMeatzo = New System.Windows.Forms.Button()
        Me.BtnTaco = New System.Windows.Forms.Button()
        Me.BtnVeggie = New System.Windows.Forms.Button()
        Me.BtnCustom = New System.Windows.Forms.Button()
        Me.BtnSupremo = New System.Windows.Forms.Button()
        Me.BtnSurfsUp = New System.Windows.Forms.Button()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.CboPizzaType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnMeatzo
        '
        Me.BtnMeatzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMeatzo.Location = New System.Drawing.Point(87, 170)
        Me.BtnMeatzo.Name = "BtnMeatzo"
        Me.BtnMeatzo.Size = New System.Drawing.Size(177, 90)
        Me.BtnMeatzo.TabIndex = 1
        Me.BtnMeatzo.Text = "Meatzo"
        Me.BtnMeatzo.UseVisualStyleBackColor = True
        '
        'BtnTaco
        '
        Me.BtnTaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTaco.Location = New System.Drawing.Point(668, 312)
        Me.BtnTaco.Name = "BtnTaco"
        Me.BtnTaco.Size = New System.Drawing.Size(177, 90)
        Me.BtnTaco.TabIndex = 5
        Me.BtnTaco.Text = "Taco"
        Me.BtnTaco.UseVisualStyleBackColor = True
        '
        'BtnVeggie
        '
        Me.BtnVeggie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVeggie.Location = New System.Drawing.Point(668, 170)
        Me.BtnVeggie.Name = "BtnVeggie"
        Me.BtnVeggie.Size = New System.Drawing.Size(177, 90)
        Me.BtnVeggie.TabIndex = 2
        Me.BtnVeggie.Text = "Veggie"
        Me.BtnVeggie.UseVisualStyleBackColor = True
        '
        'BtnCustom
        '
        Me.BtnCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustom.Location = New System.Drawing.Point(373, 170)
        Me.BtnCustom.Name = "BtnCustom"
        Me.BtnCustom.Size = New System.Drawing.Size(177, 90)
        Me.BtnCustom.TabIndex = 0
        Me.BtnCustom.Text = "Custom"
        Me.BtnCustom.UseVisualStyleBackColor = True
        '
        'BtnSupremo
        '
        Me.BtnSupremo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupremo.Location = New System.Drawing.Point(373, 312)
        Me.BtnSupremo.Name = "BtnSupremo"
        Me.BtnSupremo.Size = New System.Drawing.Size(177, 90)
        Me.BtnSupremo.TabIndex = 4
        Me.BtnSupremo.Text = "Supremo"
        Me.BtnSupremo.UseVisualStyleBackColor = True
        '
        'BtnSurfsUp
        '
        Me.BtnSurfsUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSurfsUp.Location = New System.Drawing.Point(87, 312)
        Me.BtnSurfsUp.Name = "BtnSurfsUp"
        Me.BtnSurfsUp.Size = New System.Drawing.Size(177, 90)
        Me.BtnSurfsUp.TabIndex = 3
        Me.BtnSurfsUp.Text = "Surfs Up"
        Me.BtnSurfsUp.UseVisualStyleBackColor = True
        '
        'CboCarryoutOrDelivery
        '
        Me.CboCarryoutOrDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCarryoutOrDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCarryoutOrDelivery.FormattingEnabled = True
        Me.CboCarryoutOrDelivery.Location = New System.Drawing.Point(12, 12)
        Me.CboCarryoutOrDelivery.Name = "CboCarryoutOrDelivery"
        Me.CboCarryoutOrDelivery.Size = New System.Drawing.Size(121, 28)
        Me.CboCarryoutOrDelivery.TabIndex = 7
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(325, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(284, 33)
        Me.LblTitle.TabIndex = 8
        Me.LblTitle.Text = "Custom Or Specialty"
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
        Me.LblOrderNumberTitle.TabIndex = 9
        Me.LblOrderNumberTitle.Text = "Order #"
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
        Me.LblOrderNumber.TabIndex = 10
        Me.LblOrderNumber.Text = "1001"
        '
        'CboPizzaType
        '
        Me.CboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPizzaType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPizzaType.FormattingEnabled = True
        Me.CboPizzaType.Location = New System.Drawing.Point(799, 12)
        Me.CboPizzaType.Name = "CboPizzaType"
        Me.CboPizzaType.Size = New System.Drawing.Size(121, 28)
        Me.CboPizzaType.TabIndex = 38
        Me.CboPizzaType.Visible = False
        '
        'FrmCustomOrSpecialty
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
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.BtnSurfsUp)
        Me.Controls.Add(Me.BtnSupremo)
        Me.Controls.Add(Me.BtnCustom)
        Me.Controls.Add(Me.BtnVeggie)
        Me.Controls.Add(Me.BtnTaco)
        Me.Controls.Add(Me.BtnMeatzo)
        Me.Name = "FrmCustomOrSpecialty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Custom Or Specialty?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMeatzo As Button
    Friend WithEvents BtnTaco As Button
    Friend WithEvents BtnVeggie As Button
    Friend WithEvents BtnCustom As Button
    Friend WithEvents BtnSupremo As Button
    Friend WithEvents BtnSurfsUp As Button
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents CboPizzaType As ComboBox
End Class
