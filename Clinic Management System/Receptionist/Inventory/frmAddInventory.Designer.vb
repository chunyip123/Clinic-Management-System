<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInventory
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
        Me.lblAddItem = New System.Windows.Forms.Label()
        Me.mskUnitPrice = New System.Windows.Forms.MaskedTextBox()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.NumericUpDown()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemDetail = New System.Windows.Forms.Label()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.lblItemId = New System.Windows.Forms.Label()
        Me.lblAddInventoryItem = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddItem
        '
        Me.lblAddItem.AutoSize = True
        Me.lblAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddItem.Location = New System.Drawing.Point(30, 22)
        Me.lblAddItem.Name = "lblAddItem"
        Me.lblAddItem.Size = New System.Drawing.Size(202, 32)
        Me.lblAddItem.TabIndex = 48
        Me.lblAddItem.Text = "Add New Item"
        '
        'mskUnitPrice
        '
        Me.mskUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskUnitPrice.Location = New System.Drawing.Point(107, 244)
        Me.mskUnitPrice.Name = "mskUnitPrice"
        Me.mskUnitPrice.Size = New System.Drawing.Size(304, 27)
        Me.mskUnitPrice.TabIndex = 5
        Me.mskUnitPrice.ValidatingType = GetType(Integer)
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.AutoSize = True
        Me.lblExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiryDate.Location = New System.Drawing.Point(103, 369)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(96, 20)
        Me.lblExpiryDate.TabIndex = 8
        Me.lblExpiryDate.Text = "Expiry Date"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(104, 293)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(71, 20)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(312, 741)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(172, 58)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.dtpExpiryDate)
        Me.Panel2.Controls.Add(Me.mskUnitPrice)
        Me.Panel2.Controls.Add(Me.lblExpiryDate)
        Me.Panel2.Controls.Add(Me.lblQuantity)
        Me.Panel2.Controls.Add(Me.txtItemDescription)
        Me.Panel2.Controls.Add(Me.lblItemDescription)
        Me.Panel2.Controls.Add(Me.lblUnitPrice)
        Me.Panel2.Controls.Add(Me.txtItemName)
        Me.Panel2.Controls.Add(Me.lblItemName)
        Me.Panel2.Location = New System.Drawing.Point(33, 262)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 456)
        Me.Panel2.TabIndex = 43
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(108, 316)
        Me.txtQuantity.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(304, 27)
        Me.txtQuantity.TabIndex = 10
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpiryDate.CustomFormat = ""
        Me.dtpExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpiryDate.Location = New System.Drawing.Point(107, 393)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(304, 27)
        Me.dtpExpiryDate.TabIndex = 9
        Me.dtpExpiryDate.Value = New Date(2021, 1, 19, 12, 0, 43, 0)
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(107, 124)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(304, 71)
        Me.txtItemDescription.TabIndex = 3
        '
        'lblItemDescription
        '
        Me.lblItemDescription.AutoSize = True
        Me.lblItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription.Location = New System.Drawing.Point(104, 101)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(132, 20)
        Me.lblItemDescription.TabIndex = 2
        Me.lblItemDescription.Text = "Item Description"
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(104, 221)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(126, 20)
        Me.lblUnitPrice.TabIndex = 4
        Me.lblUnitPrice.Text = "Unit Price (RM)"
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(107, 50)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(304, 27)
        Me.txtItemName.TabIndex = 1
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(104, 29)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(90, 20)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Item Name"
        '
        'lblItemDetail
        '
        Me.lblItemDetail.AutoSize = True
        Me.lblItemDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDetail.Location = New System.Drawing.Point(31, 234)
        Me.lblItemDetail.Name = "lblItemDetail"
        Me.lblItemDetail.Size = New System.Drawing.Size(182, 25)
        Me.lblItemDetail.TabIndex = 47
        Me.lblItemDetail.Text = "Item's Information"
        '
        'txtItemId
        '
        Me.txtItemId.Enabled = False
        Me.txtItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemId.Location = New System.Drawing.Point(108, 42)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(303, 27)
        Me.txtItemId.TabIndex = 1
        '
        'lblItemId
        '
        Me.lblItemId.AutoSize = True
        Me.lblItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId.Location = New System.Drawing.Point(104, 19)
        Me.lblItemId.Name = "lblItemId"
        Me.lblItemId.Size = New System.Drawing.Size(63, 20)
        Me.lblItemId.TabIndex = 0
        Me.lblItemId.Text = "Item ID"
        '
        'lblAddInventoryItem
        '
        Me.lblAddInventoryItem.AutoSize = True
        Me.lblAddInventoryItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddInventoryItem.Location = New System.Drawing.Point(31, 80)
        Me.lblAddInventoryItem.Name = "lblAddInventoryItem"
        Me.lblAddInventoryItem.Size = New System.Drawing.Size(293, 25)
        Me.lblAddInventoryItem.TabIndex = 46
        Me.lblAddInventoryItem.Text = "Item Details Currently Adding"
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(106, 741)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(172, 58)
        Me.btnAddItem.TabIndex = 44
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtItemId)
        Me.Panel1.Controls.Add(Me.lblItemId)
        Me.Panel1.Location = New System.Drawing.Point(33, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 99)
        Me.Panel1.TabIndex = 42
        '
        'frmAddInventory
        '
        Me.AcceptButton = Me.btnAddItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(576, 820)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAddItem)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblItemDetail)
        Me.Controls.Add(Me.lblAddInventoryItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddItem As Label
    Friend WithEvents mskUnitPrice As MaskedTextBox
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents lblItemDescription As Label
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblItemDetail As Label
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents lblItemId As Label
    Friend WithEvents lblAddInventoryItem As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents txtQuantity As NumericUpDown
End Class
