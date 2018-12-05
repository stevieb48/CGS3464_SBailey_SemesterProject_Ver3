<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceipt))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.LstOrder = New System.Windows.Forms.ListBox()
        Me.GrpCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.LstCustomerInformation = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDeliveryCharge = New System.Windows.Forms.Label()
        Me.lblDeliveryTitle = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTaxTitle = New System.Windows.Forms.Label()
        Me.lblSubtotalTitle = New System.Windows.Forms.Label()
        Me.lblOrderType = New System.Windows.Forms.Label()
        Me.GrpCustomerInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(409, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(116, 33)
        Me.LblTitle.TabIndex = 34
        Me.LblTitle.Text = "Receipt"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(406, 504)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(120, 48)
        Me.BtnOk.TabIndex = 35
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
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
        Me.LblOrderNumber.TabIndex = 37
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
        Me.LblOrderNumberTitle.TabIndex = 36
        Me.LblOrderNumberTitle.Text = "Order #"
        '
        'LstOrder
        '
        Me.LstOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOrder.FormattingEnabled = True
        Me.LstOrder.ItemHeight = 20
        Me.LstOrder.Location = New System.Drawing.Point(221, 102)
        Me.LstOrder.Name = "LstOrder"
        Me.LstOrder.Size = New System.Drawing.Size(628, 224)
        Me.LstOrder.TabIndex = 44
        '
        'GrpCustomerInformation
        '
        Me.GrpCustomerInformation.AutoSize = True
        Me.GrpCustomerInformation.Controls.Add(Me.LstCustomerInformation)
        Me.GrpCustomerInformation.Location = New System.Drawing.Point(13, 93)
        Me.GrpCustomerInformation.Name = "GrpCustomerInformation"
        Me.GrpCustomerInformation.Size = New System.Drawing.Size(126, 142)
        Me.GrpCustomerInformation.TabIndex = 45
        Me.GrpCustomerInformation.TabStop = False
        Me.GrpCustomerInformation.Text = "Customer"
        '
        'LstCustomerInformation
        '
        Me.LstCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstCustomerInformation.FormattingEnabled = True
        Me.LstCustomerInformation.ItemHeight = 20
        Me.LstCustomerInformation.Location = New System.Drawing.Point(6, 19)
        Me.LstCustomerInformation.Name = "LstCustomerInformation"
        Me.LstCustomerInformation.Size = New System.Drawing.Size(114, 104)
        Me.LstCustomerInformation.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.lblDeliveryCharge)
        Me.GroupBox1.Controls.Add(Me.lblDeliveryTitle)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblTotalTitle)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblTaxTitle)
        Me.GroupBox1.Controls.Add(Me.lblSubtotalTitle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(345, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 158)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Bill :"
        '
        'lblDeliveryCharge
        '
        Me.lblDeliveryCharge.AutoSize = True
        Me.lblDeliveryCharge.Location = New System.Drawing.Point(184, 64)
        Me.lblDeliveryCharge.Name = "lblDeliveryCharge"
        Me.lblDeliveryCharge.Size = New System.Drawing.Size(18, 20)
        Me.lblDeliveryCharge.TabIndex = 43
        Me.lblDeliveryCharge.Text = "0"
        '
        'lblDeliveryTitle
        '
        Me.lblDeliveryTitle.AutoSize = True
        Me.lblDeliveryTitle.Location = New System.Drawing.Point(65, 64)
        Me.lblDeliveryTitle.Name = "lblDeliveryTitle"
        Me.lblDeliveryTitle.Size = New System.Drawing.Size(118, 20)
        Me.lblDeliveryTitle.TabIndex = 42
        Me.lblDeliveryTitle.Text = "delivery charge:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(184, 90)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(18, 20)
        Me.lblTax.TabIndex = 41
        Me.lblTax.Text = "0"
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTitle.Location = New System.Drawing.Point(129, 116)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(54, 20)
        Me.lblTotalTitle.TabIndex = 40
        Me.lblTotalTitle.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(183, 116)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(19, 20)
        Me.lblTotal.TabIndex = 39
        Me.lblTotal.Text = "0"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(184, 38)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(18, 20)
        Me.lblSubtotal.TabIndex = 38
        Me.lblSubtotal.Text = "0"
        '
        'lblTaxTitle
        '
        Me.lblTaxTitle.AutoSize = True
        Me.lblTaxTitle.Location = New System.Drawing.Point(145, 90)
        Me.lblTaxTitle.Name = "lblTaxTitle"
        Me.lblTaxTitle.Size = New System.Drawing.Size(38, 20)
        Me.lblTaxTitle.TabIndex = 37
        Me.lblTaxTitle.Text = "Tax:"
        '
        'lblSubtotalTitle
        '
        Me.lblSubtotalTitle.AutoSize = True
        Me.lblSubtotalTitle.Location = New System.Drawing.Point(110, 38)
        Me.lblSubtotalTitle.Name = "lblSubtotalTitle"
        Me.lblSubtotalTitle.Size = New System.Drawing.Size(73, 20)
        Me.lblSubtotalTitle.TabIndex = 36
        Me.lblSubtotalTitle.Text = "Subtotal:"
        '
        'lblOrderType
        '
        Me.lblOrderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderType.Location = New System.Drawing.Point(12, 12)
        Me.lblOrderType.Name = "lblOrderType"
        Me.lblOrderType.Size = New System.Drawing.Size(121, 28)
        Me.lblOrderType.TabIndex = 50
        Me.lblOrderType.Text = "Label1"
        '
        'FrmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 573)
        Me.Controls.Add(Me.lblOrderType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpCustomerInformation)
        Me.Controls.Add(Me.LstOrder)
        Me.Controls.Add(Me.LblOrderNumber)
        Me.Controls.Add(Me.LblOrderNumberTitle)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "FrmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Receipt"
        Me.GrpCustomerInformation.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents LstOrder As ListBox
    Friend WithEvents GrpCustomerInformation As GroupBox
    Friend WithEvents LstCustomerInformation As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDeliveryCharge As Label
    Friend WithEvents lblDeliveryTitle As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTaxTitle As Label
    Friend WithEvents lblSubtotalTitle As Label
    Friend WithEvents lblOrderType As Label
End Class
