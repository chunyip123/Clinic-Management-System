<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientList
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
        Me.lblPatientList = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.cboSortPatient = New System.Windows.Forms.ComboBox()
        Me.lblSearchPatient = New System.Windows.Forms.Label()
        Me.txtSearchPatient = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboSearchPatient = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPatientList
        '
        Me.lblPatientList.AutoSize = True
        Me.lblPatientList.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientList.Location = New System.Drawing.Point(20, 87)
        Me.lblPatientList.Name = "lblPatientList"
        Me.lblPatientList.Size = New System.Drawing.Size(120, 26)
        Me.lblPatientList.TabIndex = 7
        Me.lblPatientList.Text = "Patient List"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
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
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogout.Location = New System.Drawing.Point(1070, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(109, 44)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Sign Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblClinic
        '
        Me.lblClinic.AutoSize = True
        Me.lblClinic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinic.Location = New System.Drawing.Point(19, 16)
        Me.lblClinic.Name = "lblClinic"
        Me.lblClinic.Size = New System.Drawing.Size(324, 29)
        Me.lblClinic.TabIndex = 2
        Me.lblClinic.Text = "Clinic Management System"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(-2, -1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1189, 60)
        Me.pnlTop.TabIndex = 8
        '
        'btnAddPatient
        '
        Me.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatient.ForeColor = System.Drawing.Color.White
        Me.btnAddPatient.Location = New System.Drawing.Point(22, 136)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(135, 51)
        Me.btnAddPatient.TabIndex = 9
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.UseVisualStyleBackColor = False
        '
        'cboSortPatient
        '
        Me.cboSortPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSortPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortPatient.ForeColor = System.Drawing.Color.White
        Me.cboSortPatient.FormattingEnabled = True
        Me.cboSortPatient.Location = New System.Drawing.Point(22, 221)
        Me.cboSortPatient.Name = "cboSortPatient"
        Me.cboSortPatient.Size = New System.Drawing.Size(118, 26)
        Me.cboSortPatient.TabIndex = 11
        Me.cboSortPatient.Text = "Sort By"
        '
        'lblSearchPatient
        '
        Me.lblSearchPatient.AutoSize = True
        Me.lblSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchPatient.Location = New System.Drawing.Point(867, 227)
        Me.lblSearchPatient.Name = "lblSearchPatient"
        Me.lblSearchPatient.Size = New System.Drawing.Size(72, 20)
        Me.lblSearchPatient.TabIndex = 12
        Me.lblSearchPatient.Text = "Search: "
        '
        'txtSearchPatient
        '
        Me.txtSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPatient.Location = New System.Drawing.Point(939, 224)
        Me.txtSearchPatient.Name = "txtSearchPatient"
        Me.txtSearchPatient.Size = New System.Drawing.Size(164, 27)
        Me.txtSearchPatient.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1104, 223)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(73, 29)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cboSearchPatient
        '
        Me.cboSearchPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchPatient.ForeColor = System.Drawing.Color.White
        Me.cboSearchPatient.FormattingEnabled = True
        Me.cboSearchPatient.Location = New System.Drawing.Point(871, 192)
        Me.cboSearchPatient.Name = "cboSearchPatient"
        Me.cboSearchPatient.Size = New System.Drawing.Size(118, 26)
        Me.cboSearchPatient.TabIndex = 15
        Me.cboSearchPatient.Text = "Search By"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 261)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(1161, 405)
        Me.dgv.TabIndex = 16
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1017, 677)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 62)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back to Dashboard"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmPatientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 746)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cboSearchPatient)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchPatient)
        Me.Controls.Add(Me.lblSearchPatient)
        Me.Controls.Add(Me.cboSortPatient)
        Me.Controls.Add(Me.btnAddPatient)
        Me.Controls.Add(Me.lblPatientList)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPatientList"
        Me.Text = "frmPatientList"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatientList As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents cboSortPatient As ComboBox
    Friend WithEvents lblSearchPatient As Label
    Friend WithEvents txtSearchPatient As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cboSearchPatient As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnBack As Button
End Class
