<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeMain
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
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.cboSortSequence = New System.Windows.Forms.ComboBox()
        Me.lblResultsNo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cboSearchEmployee = New System.Windows.Forms.ComboBox()
        Me.txtSearchEmployee = New System.Windows.Forms.TextBox()
        Me.lblSearchOrganization = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.cboSortEmployee = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.lblEmployeeMain = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEmployee.ForeColor = System.Drawing.Color.White
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(1698, 987)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(156, 62)
        Me.btnDeleteEmployee.TabIndex = 46
        Me.btnDeleteEmployee.Text = "Delete Employee"
        Me.btnDeleteEmployee.UseVisualStyleBackColor = False
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
        Me.cboSortSequence.TabIndex = 45
        Me.cboSortSequence.Text = "Sorting Order"
        '
        'lblResultsNo
        '
        Me.lblResultsNo.AutoSize = True
        Me.lblResultsNo.Location = New System.Drawing.Point(14, 987)
        Me.lblResultsNo.Name = "lblResultsNo"
        Me.lblResultsNo.Size = New System.Drawing.Size(67, 17)
        Me.lblResultsNo.TabIndex = 44
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
        Me.btnBack.TabIndex = 43
        Me.btnBack.Text = "Back"
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
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(2025, 639)
        Me.dgv.TabIndex = 42
        '
        'cboSearchEmployee
        '
        Me.cboSearchEmployee.BackColor = System.Drawing.SystemColors.Window
        Me.cboSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchEmployee.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSearchEmployee.FormattingEnabled = True
        Me.cboSearchEmployee.Items.AddRange(New Object() {"Panel ID", "Organization Name", "Organization Code", "Organization Contact No."})
        Me.cboSearchEmployee.Location = New System.Drawing.Point(1786, 262)
        Me.cboSearchEmployee.Name = "cboSearchEmployee"
        Me.cboSearchEmployee.Size = New System.Drawing.Size(191, 28)
        Me.cboSearchEmployee.TabIndex = 41
        Me.cboSearchEmployee.Text = "Search By"
        '
        'txtSearchEmployee
        '
        Me.txtSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmployee.Location = New System.Drawing.Point(1786, 300)
        Me.txtSearchEmployee.Name = "txtSearchEmployee"
        Me.txtSearchEmployee.Size = New System.Drawing.Size(242, 27)
        Me.txtSearchEmployee.TabIndex = 40
        '
        'lblSearchOrganization
        '
        Me.lblSearchOrganization.AutoSize = True
        Me.lblSearchOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchOrganization.Location = New System.Drawing.Point(1633, 303)
        Me.lblSearchOrganization.Name = "lblSearchOrganization"
        Me.lblSearchOrganization.Size = New System.Drawing.Size(141, 20)
        Me.lblSearchOrganization.TabIndex = 39
        Me.lblSearchOrganization.Text = "Search Keyword: "
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
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
        'cboSortEmployee
        '
        Me.cboSortEmployee.BackColor = System.Drawing.SystemColors.Window
        Me.cboSortEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortEmployee.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSortEmployee.FormattingEnabled = True
        Me.cboSortEmployee.Items.AddRange(New Object() {"Organization Name", "Organization Code", "Daily Insured Limit"})
        Me.cboSortEmployee.Location = New System.Drawing.Point(43, 262)
        Me.cboSortEmployee.Name = "cboSortEmployee"
        Me.cboSortEmployee.Size = New System.Drawing.Size(191, 28)
        Me.cboSortEmployee.TabIndex = 38
        Me.cboSortEmployee.Text = "Sort By"
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
        Me.pnlTop.TabIndex = 36
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
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.Location = New System.Drawing.Point(43, 177)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(191, 67)
        Me.btnAddEmployee.TabIndex = 37
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'lblEmployeeMain
        '
        Me.lblEmployeeMain.AutoSize = True
        Me.lblEmployeeMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeMain.Location = New System.Drawing.Point(37, 106)
        Me.lblEmployeeMain.Name = "lblEmployeeMain"
        Me.lblEmployeeMain.Size = New System.Drawing.Size(377, 38)
        Me.lblEmployeeMain.TabIndex = 35
        Me.lblEmployeeMain.Text = "Employee Maintenance"
        '
        'frmEmployeeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 1060)
        Me.Controls.Add(Me.btnDeleteEmployee)
        Me.Controls.Add(Me.cboSortSequence)
        Me.Controls.Add(Me.lblResultsNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cboSearchEmployee)
        Me.Controls.Add(Me.txtSearchEmployee)
        Me.Controls.Add(Me.lblSearchOrganization)
        Me.Controls.Add(Me.cboSortEmployee)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.lblEmployeeMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeeMain"
        Me.Text = "frmEmployeeMain"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents cboSortSequence As ComboBox
    Friend WithEvents lblResultsNo As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cboSearchEmployee As ComboBox
    Friend WithEvents txtSearchEmployee As TextBox
    Friend WithEvents lblSearchOrganization As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents cboSortEmployee As ComboBox
    Friend WithEvents lblTime As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents lblEmployeeMain As Label
End Class
