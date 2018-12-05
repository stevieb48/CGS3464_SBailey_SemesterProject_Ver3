<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnCarryout = New System.Windows.Forms.Button()
        Me.BtnDelivery = New System.Windows.Forms.Button()
        Me.CboPizzaType = New System.Windows.Forms.ComboBox()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(241, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(459, 33)
        Me.LblTitle.TabIndex = 2
        Me.LblTitle.Text = "Welcome to Steve's Pizza Factory"
        '
        'BtnCarryout
        '
        Me.BtnCarryout.AutoSize = True
        Me.BtnCarryout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarryout.Location = New System.Drawing.Point(250, 241)
        Me.BtnCarryout.Name = "BtnCarryout"
        Me.BtnCarryout.Size = New System.Drawing.Size(177, 90)
        Me.BtnCarryout.TabIndex = 0
        Me.BtnCarryout.Text = "Carry-out"
        Me.BtnCarryout.UseVisualStyleBackColor = True
        '
        'BtnDelivery
        '
        Me.BtnDelivery.AutoSize = True
        Me.BtnDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelivery.Location = New System.Drawing.Point(506, 241)
        Me.BtnDelivery.Name = "BtnDelivery"
        Me.BtnDelivery.Size = New System.Drawing.Size(177, 90)
        Me.BtnDelivery.TabIndex = 0
        Me.BtnDelivery.Text = "Delivery"
        Me.BtnDelivery.UseVisualStyleBackColor = True
        '
        'CboPizzaType
        '
        Me.CboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPizzaType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPizzaType.FormattingEnabled = True
        Me.CboPizzaType.Location = New System.Drawing.Point(799, 12)
        Me.CboPizzaType.Name = "CboPizzaType"
        Me.CboPizzaType.Size = New System.Drawing.Size(121, 28)
        Me.CboPizzaType.TabIndex = 37
        Me.CboPizzaType.Visible = False
        '
        'CboCarryoutOrDelivery
        '
        Me.CboCarryoutOrDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCarryoutOrDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCarryoutOrDelivery.FormattingEnabled = True
        Me.CboCarryoutOrDelivery.Location = New System.Drawing.Point(12, 12)
        Me.CboCarryoutOrDelivery.Name = "CboCarryoutOrDelivery"
        Me.CboCarryoutOrDelivery.Size = New System.Drawing.Size(121, 28)
        Me.CboCarryoutOrDelivery.TabIndex = 11
        Me.CboCarryoutOrDelivery.Visible = False
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
        Me.LblOrderNumberTitle.TabIndex = 12
        Me.LblOrderNumberTitle.Text = "Order #"
        Me.LblOrderNumberTitle.Visible = False
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
        Me.LblOrderNumber.TabIndex = 13
        Me.LblOrderNumber.Text = "1001"
        Me.LblOrderNumber.Visible = False
        '
        'FrmCarryoutOrDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 573)
        Me.Controls.Add(Me.CboPizzaType)
        Me.Controls.Add(Me.LblOrderNumber)
        Me.Controls.Add(Me.LblOrderNumberTitle)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.BtnDelivery)
        Me.Controls.Add(Me.BtnCarryout)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "FrmCarryoutOrDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carry-out Or Delivery?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnCarryout As Button
    Friend WithEvents BtnDelivery As Button
    Friend WithEvents CboPizzaType As ComboBox
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents LblOrderNumber As Label
End Class
