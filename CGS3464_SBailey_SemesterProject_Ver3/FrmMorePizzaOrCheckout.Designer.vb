﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMorePizzaOrCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMorePizzaOrCheckout))
        Me.BtnCheckout = New System.Windows.Forms.Button()
        Me.CboCarryoutOrDelivery = New System.Windows.Forms.ComboBox()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnEditPizza = New System.Windows.Forms.Button()
        Me.BtnAddPizza = New System.Windows.Forms.Button()
        Me.BtnDeletePizza = New System.Windows.Forms.Button()
        Me.LstOrder = New System.Windows.Forms.ListBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblOrderNumber = New System.Windows.Forms.Label()
        Me.LblOrderNumberTitle = New System.Windows.Forms.Label()
        Me.GrpBill = New System.Windows.Forms.GroupBox()
        Me.lblDeliveryCharge = New System.Windows.Forms.Label()
        Me.lblDeliveryTitle = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTaxTitle = New System.Windows.Forms.Label()
        Me.lblSubtotalTitle = New System.Windows.Forms.Label()
        Me.GrpBill.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCheckout
        '
        Me.BtnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheckout.Location = New System.Drawing.Point(799, 513)
        Me.BtnCheckout.Name = "BtnCheckout"
        Me.BtnCheckout.Size = New System.Drawing.Size(120, 48)
        Me.BtnCheckout.TabIndex = 27
        Me.BtnCheckout.Text = "Checkout"
        Me.BtnCheckout.UseVisualStyleBackColor = True
        '
        'CboCarryoutOrDelivery
        '
        Me.CboCarryoutOrDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCarryoutOrDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCarryoutOrDelivery.FormattingEnabled = True
        Me.CboCarryoutOrDelivery.Location = New System.Drawing.Point(12, 12)
        Me.CboCarryoutOrDelivery.Name = "CboCarryoutOrDelivery"
        Me.CboCarryoutOrDelivery.Size = New System.Drawing.Size(121, 28)
        Me.CboCarryoutOrDelivery.TabIndex = 26
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(13, 513)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(120, 48)
        Me.BtnPrevious.TabIndex = 25
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnEditPizza
        '
        Me.BtnEditPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditPizza.Location = New System.Drawing.Point(84, 102)
        Me.BtnEditPizza.Name = "BtnEditPizza"
        Me.BtnEditPizza.Size = New System.Drawing.Size(122, 48)
        Me.BtnEditPizza.TabIndex = 28
        Me.BtnEditPizza.Text = "Edit Pizza"
        Me.BtnEditPizza.UseVisualStyleBackColor = True
        '
        'BtnAddPizza
        '
        Me.BtnAddPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPizza.Location = New System.Drawing.Point(84, 278)
        Me.BtnAddPizza.Name = "BtnAddPizza"
        Me.BtnAddPizza.Size = New System.Drawing.Size(122, 48)
        Me.BtnAddPizza.TabIndex = 29
        Me.BtnAddPizza.Text = "Add Pizza"
        Me.BtnAddPizza.UseVisualStyleBackColor = True
        '
        'BtnDeletePizza
        '
        Me.BtnDeletePizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeletePizza.Location = New System.Drawing.Point(84, 190)
        Me.BtnDeletePizza.Name = "BtnDeletePizza"
        Me.BtnDeletePizza.Size = New System.Drawing.Size(122, 48)
        Me.BtnDeletePizza.TabIndex = 30
        Me.BtnDeletePizza.Text = "Delete Pizza"
        Me.BtnDeletePizza.UseVisualStyleBackColor = True
        '
        'LstOrder
        '
        Me.LstOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOrder.FormattingEnabled = True
        Me.LstOrder.ItemHeight = 20
        Me.LstOrder.Location = New System.Drawing.Point(221, 102)
        Me.LstOrder.Name = "LstOrder"
        Me.LstOrder.Size = New System.Drawing.Size(628, 224)
        Me.LstOrder.TabIndex = 31
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(369, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(196, 33)
        Me.LblTitle.TabIndex = 32
        Me.LblTitle.Text = "Current Order"
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
        Me.LblOrderNumber.TabIndex = 34
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
        Me.LblOrderNumberTitle.TabIndex = 33
        Me.LblOrderNumberTitle.Text = "Order #"
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
        Me.GrpBill.TabIndex = 35
        Me.GrpBill.TabStop = False
        Me.GrpBill.Text = "Current Bill :"
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
        'FrmMorePizzaOrCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 573)
        Me.Controls.Add(Me.GrpBill)
        Me.Controls.Add(Me.LblOrderNumber)
        Me.Controls.Add(Me.LblOrderNumberTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LstOrder)
        Me.Controls.Add(Me.BtnDeletePizza)
        Me.Controls.Add(Me.BtnAddPizza)
        Me.Controls.Add(Me.BtnEditPizza)
        Me.Controls.Add(Me.BtnCheckout)
        Me.Controls.Add(Me.CboCarryoutOrDelivery)
        Me.Controls.Add(Me.BtnPrevious)
        Me.DoubleBuffered = True
        Me.Name = "FrmMorePizzaOrCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "More Pizza Or Checkout?"
        Me.GrpBill.ResumeLayout(False)
        Me.GrpBill.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCheckout As Button
    Friend WithEvents CboCarryoutOrDelivery As ComboBox
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnEditPizza As Button
    Friend WithEvents BtnAddPizza As Button
    Friend WithEvents BtnDeletePizza As Button
    Friend WithEvents LstOrder As ListBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblOrderNumber As Label
    Friend WithEvents LblOrderNumberTitle As Label
    Friend WithEvents GrpBill As GroupBox
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTaxTitle As Label
    Friend WithEvents lblSubtotalTitle As Label
    Friend WithEvents lblDeliveryCharge As Label
    Friend WithEvents lblDeliveryTitle As Label
End Class
