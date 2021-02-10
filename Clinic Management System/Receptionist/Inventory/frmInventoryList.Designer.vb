<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryList
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
        Me.components = New System.ComponentModel.Container()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.cboSortSequence = New System.Windows.Forms.ComboBox()
        Me.lblResultsNo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cboSearchInventory = New System.Windows.Forms.ComboBox()
        Me.txtSearchInventory = New System.Windows.Forms.TextBox()
        Me.lblSearchInventory = New System.Windows.Forms.Label()
        Me.cboSortInventory = New System.Windows.Forms.ComboBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblInventoryList = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.White
        Me.btnDeleteItem.Location = New System.Drawing.Point(1698, 987)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(156, 62)
        Me.btnDeleteItem.TabIndex = 34
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'cboSortSequence
        '
        Me.cboSortSequence.BackColor = System.Drawing.SystemColors.Window
        Me.cboSortSequence.Enabled = False
        Me.cboSortSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortSequence.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSortSequence.FormattingEnabled = True
        Me.cboSortSequence.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.cboSortSequence.Location = New System.Drawing.Point(43, 298)
        Me.cboSortSequence.Name = "cboSortSequence"
        Me.cboSortSequence.Size = New System.Drawing.Size(191, 28)
        Me.cboSortSequence.TabIndex = 33
        Me.cboSortSequence.Text = "Sorting Order"
        '
        'lblResultsNo
        '
        Me.lblResultsNo.AutoSize = True
        Me.lblResultsNo.Location = New System.Drawing.Point(14, 987)
        Me.lblResultsNo.Name = "lblResultsNo"
        Me.lblResultsNo.Size = New System.Drawing.Size(67, 17)
        Me.lblResultsNo.TabIndex = 31
        Me.lblResultsNo.Text = "0 Results"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1883, 987)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 62)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back to Dashboard"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(14, 342)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(2025, 639)
        Me.dgv.TabIndex = 29
        '
        'cboSearchInventory
        '
        Me.cboSearchInventory.BackColor = System.Drawing.SystemColors.Window
        Me.cboSearchInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchInventory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSearchInventory.FormattingEnabled = True
        Me.cboSearchInventory.Items.AddRange(New Object() {"Item ID", "Item Name", "Item Price (RM)"})
        Me.cboSearchInventory.Location = New System.Drawing.Point(1786, 262)
        Me.cboSearchInventory.Name = "cboSearchInventory"
        Me.cboSearchInventory.Size = New System.Drawing.Size(191, 28)
        Me.cboSearchInventory.TabIndex = 28
        Me.cboSearchInventory.Text = "Search By"
        '
        'txtSearchInventory
        '
        Me.txtSearchInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchInventory.Location = New System.Drawing.Point(1786, 300)
        Me.txtSearchInventory.Name = "txtSearchInventory"
        Me.txtSearchInventory.Size = New System.Drawing.Size(242, 27)
        Me.txtSearchInventory.TabIndex = 27
        '
        'lblSearchInventory
        '
        Me.lblSearchInventory.AutoSize = True
        Me.lblSearchInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchInventory.Location = New System.Drawing.Point(1633, 303)
        Me.lblSearchInventory.Name = "lblSearchInventory"
        Me.lblSearchInventory.Size = New System.Drawing.Size(141, 20)
        Me.lblSearchInventory.TabIndex = 26
        Me.lblSearchInventory.Text = "Search Keyword: "
        '
        'cboSortInventory
        '
        Me.cboSortInventory.BackColor = System.Drawing.SystemColors.Window
        Me.cboSortInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortInventory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSortInventory.FormattingEnabled = True
        Me.cboSortInventory.Items.AddRange(New Object() {"Item Name", "Item Price (RM)", "Item Quantity", "Item Expiry Date"})
        Me.cboSortInventory.Location = New System.Drawing.Point(43, 262)
        Me.cboSortInventory.Name = "cboSortInventory"
        Me.cboSortInventory.Size = New System.Drawing.Size(191, 28)
        Me.cboSortInventory.TabIndex = 25
        Me.cboSortInventory.Text = "Sort By"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(2050, 83)
        Me.pnlTop.TabIndex = 23
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(572, 23)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 20)
        Me.lblTime.TabIndex = 5
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(946, 23)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(0, 20)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogout.Location = New System.Drawing.Point(1884, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(155, 66)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Sign Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblClinic
        '
        Me.lblClinic.AutoSize = True
        Me.lblClinic.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinic.Location = New System.Drawing.Point(37, 23)
        Me.lblClinic.Name = "lblClinic"
        Me.lblClinic.Size = New System.Drawing.Size(373, 36)
        Me.lblClinic.TabIndex = 2
        Me.lblClinic.Text = "Clinic Management System"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(43, 177)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(177, 67)
        Me.btnAddItem.TabIndex = 24
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'lblInventoryList
        '
        Me.lblInventoryList.AutoSize = True
        Me.lblInventoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryList.Location = New System.Drawing.Point(37, 106)
        Me.lblInventoryList.Name = "lblInventoryList"
        Me.lblInventoryList.Size = New System.Drawing.Size(289, 38)
        Me.lblInventoryList.TabIndex = 22
        Me.lblInventoryList.Text = "Medical Inventory"
        '
        'frmInventoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2050, 1060)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.cboSortSequence)
        Me.Controls.Add(Me.lblResultsNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cboSearchInventory)
        Me.Controls.Add(Me.txtSearchInventory)
        Me.Controls.Add(Me.lblSearchInventory)
        Me.Controls.Add(Me.cboSortInventory)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.lblInventoryList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventoryList"
        Me.Text = "frmInventoryList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents cboSortSequence As ComboBox
    Friend WithEvents lblResultsNo As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cboSearchInventory As ComboBox
    Friend WithEvents txtSearchInventory As TextBox
    Friend WithEvents lblSearchInventory As Label
    Friend WithEvents cboSortInventory As ComboBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblInventoryList As Label
End Class
