<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCheckout))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.BtnSubmitOrder = New System.Windows.Forms.Button()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.GrpCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.LstCustomerInformation = New System.Windows.Forms.ListBox()
        Me.LstOrder = New System.Windows.Forms.ListBox()
        Me.GrpBill = New System.Windows.Forms.GroupBox()
        Me.lblDeliveryCharge = New System.Windows.Forms.Label()
        Me.lblDeliveryTitle = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTaxTitle = New System.Windows.Forms.Label()
        Me.lblSubtotalTitle = New System.Windows.Forms.Label()
        Me.GrpCustomerInformation.SuspendLayout()
        Me.GrpBill.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(397, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(140, 33)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Checkout"
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(12, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 7
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
        Me.CboCarryoutOrDelivery.TabIndex = 9
        '
        'BtnSubmitOrder
        '
        Me.BtnSubmitOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmitOrder.Location = New System.Drawing.Point(800, 513)
        Me.BtnSubmitOrder.Name = "BtnSubmitOrder"
        Me.BtnSubmitOrder.Size = New System.Drawing.Size(120, 48)
        Me.BtnSubmitOrder.TabIndex = 33
        Me.BtnSubmitOrder.Text = "Submit Order"
        Me.BtnSubmitOrder.UseVisualStyleBackColor = True
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
        'GrpCustomerInformation
        '
        Me.GrpCustomerInformation.AutoSize = True
        Me.GrpCustomerInformation.Controls.Add(Me.LstCustomerInformation)
        Me.GrpCustomerInformation.Location = New System.Drawing.Point(13, 93)
        Me.GrpCustomerInformation.Name = "GrpCustomerInformation"
        Me.GrpCustomerInformation.Size = New System.Drawing.Size(126, 142)
        Me.GrpCustomerInformation.TabIndex = 37
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
        'LstOrder
        '
        Me.LstOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOrder.FormattingEnabled = True
        Me.LstOrder.ItemHeight = 20
        Me.LstOrder.Location = New System.Drawing.Point(206, 93)
        Me.LstOrder.Name = "LstOrder"
        Me.LstOrder.Size = New System.Drawing.Size(520, 224)
        Me.LstOrder.TabIndex = 42
        '
        'GrpBill
        '
        Me.GrpBill.AutoSize = True
        Me.GrpBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpBill.Controls.Add(Me.lblDeliveryCharge)
        Me.GrpBill.Controls.Add(Me.lblDeliveryTitle)
        Me.GrpBill.Controls.Add(Me.lblTax)
        Me.GrpBill.Controls.Add(Me.lblTotalTitle)
        Me.GrpBill.Controls.Add(Me.lblTotal)
        Me.GrpBill.Controls.Add(Me.lblSubtotal)
        Me.GrpBill.Controls.Add(Me.lblTaxTitle)
        Me.GrpBill.Controls.Add(Me.lblSubtotalTitle)
        Me.GrpBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBill.Location = New System.Drawing.Point(345, 332)
        Me.GrpBill.Name = "GrpBill"
        Me.GrpBill.Size = New System.Drawing.Size(208, 158)
        Me.GrpBill.TabIndex = 47
        Me.GrpBill.TabStop = False
        Me.GrpBill.Text = "Current Bill :"
        '
        'lblDeliveryCharge
        '
        Me.lblDeliveryCharge.AutoSize = True
        Me.lblDeliveryCharge.Location = New System.Drawing.Point(183, 90)
        Me.lblDeliveryCharge.Name = "lblDeliveryCharge"
        Me.lblDeliveryCharge.Size = New System.Drawing.Size(18, 20)
        Me.lblDeliveryCharge.TabIndex = 43
        Me.lblDeliveryCharge.Text = "0"
        '
        'lblDeliveryTitle
        '
        Me.lblDeliveryTitle.AutoSize = True
        Me.lblDeliveryTitle.Location = New System.Drawing.Point(59, 90)
        Me.lblDeliveryTitle.Name = "lblDeliveryTitle"
        Me.lblDeliveryTitle.Size = New System.Drawing.Size(118, 20)
        Me.lblDeliveryTitle.TabIndex = 42
        Me.lblDeliveryTitle.Text = "delivery charge:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(183, 64)
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
        Me.lblSubtotal.Location = New System.Drawing.Point(183, 38)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(18, 20)
        Me.lblSubtotal.TabIndex = 38
        Me.lblSubtotal.Text = "0"
        '
        'lblTaxTitle
        '
        Me.lblTaxTitle.AutoSize = True
        Me.lblTaxTitle.Location = New System.Drawing.Point(139, 64)
        Me.lblTaxTitle.Name = "lblTaxTitle"
        Me.lblTaxTitle.Size = New System.Drawing.Size(38, 20)
        Me.lblTaxTitle.TabIndex = 37
        Me.lblTaxTitle.Text = "Tax:"
        '
        'lblSubtotalTitle
        '
        Me.lblSubtotalTitle.AutoSize = True
        Me.lblSubtotalTitle.Location = New System.Drawing.Point(104, 38)
        Me.lblSubtotalTitle.Name = "lblSubtotalTitle"
        Me.lblSubtotalTitle.Size = New System.Drawing.Size(73, 20)
        Me.lblSubtotalTitle.TabIndex = 36
        Me.lblSubtotalTitle.Text = "Subtotal:"
        '
        'FrmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 573)
        Me.Controls.Add(Me.GrpBill)
        Me.Controls.Add(Me.LstOrder)
        Me.Controls.Add(Me.GrpCustomerInformation)
        Me.Controls.Add(Me.LblOrderNumber)
        Me.Controls.Add(Me.LblOrderNumberTitle)
        Me.Controls.Add(Me.BtnSubmitOrder)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.LblTitle)
        Me.DoubleBuffered = True
        Me.Name = "FrmCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Check Out"
        Me.GrpCustomerInformation.ResumeLayout(False)
        Me.GrpBill.ResumeLayout(False)
        Me.GrpBill.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents BtnSubmitOrder As Button
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents GrpCustomerInformation As GroupBox
    Friend WithEvents LstCustomerInformation As ListBox
    Friend WithEvents LstOrder As ListBox
    Friend WithEvents GrpBill As GroupBox
    Friend WithEvents lblDeliveryCharge As Label
    Friend WithEvents lblDeliveryTitle As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTaxTitle As Label
    Friend WithEvents lblSubtotalTitle As Label
End Class
