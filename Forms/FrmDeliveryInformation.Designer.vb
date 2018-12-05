<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeliveryInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeliveryInformation))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.LblDeliveryName = New System.Windows.Forms.Label()
        Me.LblDeliveryStreet = New System.Windows.Forms.Label()
        Me.LblDeliveryCity = New System.Windows.Forms.Label()
        Me.LblDeliveryZipcode = New System.Windows.Forms.Label()
        Me.GrpDeliveryInformation = New System.Windows.Forms.GroupBox()
        Me.TxtZipcode = New System.Windows.Forms.TextBox()
        Me.TxtDeliveryCity = New System.Windows.Forms.TextBox()
        Me.TxtDeliveryStreet = New System.Windows.Forms.TextBox()
        Me.TxtDeliveryName = New System.Windows.Forms.TextBox()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.GrpDeliveryInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(328, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(278, 33)
        Me.LblTitle.TabIndex = 39
        Me.LblTitle.Text = "Delivery Information"
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(798, 513)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(120, 48)
        Me.BtnNext.TabIndex = 41
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(12, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 40
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'LblDeliveryName
        '
        Me.LblDeliveryName.AutoSize = True
        Me.LblDeliveryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryName.Location = New System.Drawing.Point(38, 31)
        Me.LblDeliveryName.Name = "LblDeliveryName"
        Me.LblDeliveryName.Size = New System.Drawing.Size(86, 25)
        Me.LblDeliveryName.TabIndex = 42
        Me.LblDeliveryName.Text = "Name :"
        '
        'LblDeliveryStreet
        '
        Me.LblDeliveryStreet.AutoSize = True
        Me.LblDeliveryStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryStreet.Location = New System.Drawing.Point(35, 67)
        Me.LblDeliveryStreet.Name = "LblDeliveryStreet"
        Me.LblDeliveryStreet.Size = New System.Drawing.Size(89, 25)
        Me.LblDeliveryStreet.TabIndex = 43
        Me.LblDeliveryStreet.Text = "Street :"
        '
        'LblDeliveryCity
        '
        Me.LblDeliveryCity.AutoSize = True
        Me.LblDeliveryCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryCity.Location = New System.Drawing.Point(57, 103)
        Me.LblDeliveryCity.Name = "LblDeliveryCity"
        Me.LblDeliveryCity.Size = New System.Drawing.Size(67, 25)
        Me.LblDeliveryCity.TabIndex = 44
        Me.LblDeliveryCity.Text = "City :"
        '
        'LblDeliveryZipcode
        '
        Me.LblDeliveryZipcode.AutoSize = True
        Me.LblDeliveryZipcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryZipcode.Location = New System.Drawing.Point(14, 139)
        Me.LblDeliveryZipcode.Name = "LblDeliveryZipcode"
        Me.LblDeliveryZipcode.Size = New System.Drawing.Size(110, 25)
        Me.LblDeliveryZipcode.TabIndex = 45
        Me.LblDeliveryZipcode.Text = "Zipcode :"
        '
        'GrpDeliveryInformation
        '
        Me.GrpDeliveryInformation.AutoSize = True
        Me.GrpDeliveryInformation.Controls.Add(Me.TxtZipcode)
        Me.GrpDeliveryInformation.Controls.Add(Me.TxtDeliveryCity)
        Me.GrpDeliveryInformation.Controls.Add(Me.TxtDeliveryStreet)
        Me.GrpDeliveryInformation.Controls.Add(Me.TxtDeliveryName)
        Me.GrpDeliveryInformation.Controls.Add(Me.LblDeliveryName)
        Me.GrpDeliveryInformation.Controls.Add(Me.LblDeliveryZipcode)
        Me.GrpDeliveryInformation.Controls.Add(Me.LblDeliveryStreet)
        Me.GrpDeliveryInformation.Controls.Add(Me.LblDeliveryCity)
        Me.GrpDeliveryInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDeliveryInformation.Location = New System.Drawing.Point(259, 190)
        Me.GrpDeliveryInformation.Name = "GrpDeliveryInformation"
        Me.GrpDeliveryInformation.Size = New System.Drawing.Size(415, 192)
        Me.GrpDeliveryInformation.TabIndex = 46
        Me.GrpDeliveryInformation.TabStop = False
        Me.GrpDeliveryInformation.Text = "Delivery to :"
        '
        'TxtZipcode
        '
        Me.TxtZipcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtZipcode.Location = New System.Drawing.Point(130, 136)
        Me.TxtZipcode.Name = "TxtZipcode"
        Me.TxtZipcode.Size = New System.Drawing.Size(261, 31)
        Me.TxtZipcode.TabIndex = 3
        '
        'TxtDeliveryCity
        '
        Me.TxtDeliveryCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeliveryCity.Location = New System.Drawing.Point(130, 100)
        Me.TxtDeliveryCity.Name = "TxtDeliveryCity"
        Me.TxtDeliveryCity.Size = New System.Drawing.Size(261, 31)
        Me.TxtDeliveryCity.TabIndex = 2
        '
        'TxtDeliveryStreet
        '
        Me.TxtDeliveryStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeliveryStreet.Location = New System.Drawing.Point(130, 64)
        Me.TxtDeliveryStreet.Name = "TxtDeliveryStreet"
        Me.TxtDeliveryStreet.Size = New System.Drawing.Size(261, 31)
        Me.TxtDeliveryStreet.TabIndex = 1
        '
        'TxtDeliveryName
        '
        Me.TxtDeliveryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeliveryName.Location = New System.Drawing.Point(130, 28)
        Me.TxtDeliveryName.Name = "TxtDeliveryName"
        Me.TxtDeliveryName.Size = New System.Drawing.Size(261, 31)
        Me.TxtDeliveryName.TabIndex = 0
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
        Me.LblOrderNumber.TabIndex = 48
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
        Me.LblOrderNumberTitle.TabIndex = 47
        Me.LblOrderNumberTitle.Text = "Order #"
        '
        'CboCarryoutOrDelivery
        '
        Me.CboCarryoutOrDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCarryoutOrDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCarryoutOrDelivery.FormattingEnabled = True
        Me.CboCarryoutOrDelivery.Location = New System.Drawing.Point(12, 12)
        Me.CboCarryoutOrDelivery.Name = "CboCarryoutOrDelivery"
        Me.CboCarryoutOrDelivery.Size = New System.Drawing.Size(121, 28)
        Me.CboCarryoutOrDelivery.TabIndex = 49
        '
        'lblAlert
        '
        Me.lblAlert.AutoSize = True
        Me.lblAlert.BackColor = System.Drawing.Color.Red
        Me.lblAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlert.Location = New System.Drawing.Point(513, 524)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(282, 24)
        Me.lblAlert.TabIndex = 52
        Me.lblAlert.Text = "Press next to change to Carryout"
        '
        'FrmDeliveryInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 573)
        Me.Controls.Add(Me.lblAlert)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.LblOrderNumber)
        Me.Controls.Add(Me.LblOrderNumberTitle)
        Me.Controls.Add(Me.GrpDeliveryInformation)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.LblTitle)
        Me.DoubleBuffered = True
        Me.Name = "FrmDeliveryInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Delivery Information"
        Me.GrpDeliveryInformation.ResumeLayout(False)
        Me.GrpDeliveryInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents LblDeliveryName As Label
    Friend WithEvents LblDeliveryStreet As Label
    Friend WithEvents LblDeliveryCity As Label
    Friend WithEvents LblDeliveryZipcode As Label
    Friend WithEvents GrpDeliveryInformation As GroupBox
    Friend WithEvents TxtZipcode As TextBox
    Friend WithEvents TxtDeliveryCity As TextBox
    Friend WithEvents TxtDeliveryStreet As TextBox
    Friend WithEvents TxtDeliveryName As TextBox
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents lblAlert As Label
End Class
