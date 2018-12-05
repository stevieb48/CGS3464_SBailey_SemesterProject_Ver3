<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCarryoutInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarryoutInformation))
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtCarryoutName = New System.Windows.Forms.TextBox()
        Me.LblCarryoutName = New System.Windows.Forms.Label()
        Me.GrpCarryoutInformation = New System.Windows.Forms.GroupBox()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.GrpCarryoutInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(798, 513)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(120, 48)
        Me.BtnNext.TabIndex = 43
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(12, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 42
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(320, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(294, 33)
        Me.LblTitle.TabIndex = 44
        Me.LblTitle.Text = "Carry-out Information"
        '
        'TxtCarryoutName
        '
        Me.TxtCarryoutName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCarryoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCarryoutName.Location = New System.Drawing.Point(283, 26)
        Me.TxtCarryoutName.Name = "TxtCarryoutName"
        Me.TxtCarryoutName.Size = New System.Drawing.Size(261, 26)
        Me.TxtCarryoutName.TabIndex = 0
        '
        'LblCarryoutName
        '
        Me.LblCarryoutName.AutoSize = True
        Me.LblCarryoutName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCarryoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarryoutName.Location = New System.Drawing.Point(15, 28)
        Me.LblCarryoutName.Name = "LblCarryoutName"
        Me.LblCarryoutName.Size = New System.Drawing.Size(261, 22)
        Me.LblCarryoutName.TabIndex = 46
        Me.LblCarryoutName.Text = "Please enter a Name for the Order :"
        '
        'GrpCarryoutInformation
        '
        Me.GrpCarryoutInformation.AutoSize = True
        Me.GrpCarryoutInformation.Controls.Add(Me.LblCarryoutName)
        Me.GrpCarryoutInformation.Controls.Add(Me.TxtCarryoutName)
        Me.GrpCarryoutInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCarryoutInformation.Location = New System.Drawing.Point(187, 248)
        Me.GrpCarryoutInformation.Name = "GrpCarryoutInformation"
        Me.GrpCarryoutInformation.Size = New System.Drawing.Size(559, 77)
        Me.GrpCarryoutInformation.TabIndex = 47
        Me.GrpCarryoutInformation.TabStop = False
        Me.GrpCarryoutInformation.Text = "Carry-out for :"
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
        Me.LblOrderNumber.TabIndex = 49
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
        Me.LblOrderNumberTitle.TabIndex = 48
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
        Me.CboCarryoutOrDelivery.TabIndex = 50
        '
        'FrmCarryoutInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 573)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.LblOrderNumber)
        Me.Controls.Add(Me.LblOrderNumberTitle)
        Me.Controls.Add(Me.GrpCarryoutInformation)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrevious)
        Me.DoubleBuffered = True
        Me.Name = "FrmCarryoutInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Carry-out Information"
        Me.GrpCarryoutInformation.ResumeLayout(False)
        Me.GrpCarryoutInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtCarryoutName As TextBox
    Friend WithEvents LblCarryoutName As Label
    Friend WithEvents GrpCarryoutInformation As GroupBox
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
End Class
