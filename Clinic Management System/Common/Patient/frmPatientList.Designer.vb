<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientList
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPatientList = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnRegisterPatient = New System.Windows.Forms.Button()
        Me.cboSortPatient = New System.Windows.Forms.ComboBox()
        Me.lblSearchPatient = New System.Windows.Forms.Label()
        Me.txtSearchPatient = New System.Windows.Forms.TextBox()
        Me.cboSearchPatient = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblResultsNo = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboSortSequence = New System.Windows.Forms.ComboBox()
        Me.btnDeletePatient = New System.Windows.Forms.Button()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPatientList
        '
        Me.lblPatientList.AutoSize = True
        Me.lblPatientList.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientList.Location = New System.Drawing.Point(35, 105)
        Me.lblPatientList.Name = "lblPatientList"
        Me.lblPatientList.Size = New System.Drawing.Size(190, 38)
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
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(-2, -1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(2050, 83)
        Me.pnlTop.TabIndex = 8
        '
        'btnRegisterPatient
        '
        Me.btnRegisterPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegisterPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterPatient.ForeColor = System.Drawing.Color.White
        Me.btnRegisterPatient.Location = New System.Drawing.Point(41, 176)
        Me.btnRegisterPatient.Name = "btnRegisterPatient"
        Me.btnRegisterPatient.Size = New System.Drawing.Size(191, 67)
        Me.btnRegisterPatient.TabIndex = 9
        Me.btnRegisterPatient.Text = "Register Patient"
        Me.btnRegisterPatient.UseVisualStyleBackColor = False
        '
        'cboSortPatient
        '
        Me.cboSortPatient.BackColor = System.Drawing.SystemColors.Window
        Me.cboSortPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortPatient.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSortPatient.FormattingEnabled = True
        Me.cboSortPatient.Items.AddRange(New Object() {"First Name", "Last Name", "Age"})
        Me.cboSortPatient.Location = New System.Drawing.Point(41, 261)
        Me.cboSortPatient.Name = "cboSortPatient"
        Me.cboSortPatient.Size = New System.Drawing.Size(191, 28)
        Me.cboSortPatient.TabIndex = 11
        Me.cboSortPatient.Text = "Sort By"
        '
        'lblSearchPatient
        '
        Me.lblSearchPatient.AutoSize = True
        Me.lblSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchPatient.Location = New System.Drawing.Point(1631, 302)
        Me.lblSearchPatient.Name = "lblSearchPatient"
        Me.lblSearchPatient.Size = New System.Drawing.Size(141, 20)
        Me.lblSearchPatient.TabIndex = 12
        Me.lblSearchPatient.Text = "Search Keyword: "
        '
        'txtSearchPatient
        '
        Me.txtSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPatient.Location = New System.Drawing.Point(1784, 299)
        Me.txtSearchPatient.Name = "txtSearchPatient"
        Me.txtSearchPatient.Size = New System.Drawing.Size(242, 27)
        Me.txtSearchPatient.TabIndex = 13
        '
        'cboSearchPatient
        '
        Me.cboSearchPatient.BackColor = System.Drawing.SystemColors.Window
        Me.cboSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchPatient.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSearchPatient.FormattingEnabled = True
        Me.cboSearchPatient.Items.AddRange(New Object() {"Patient ID", "Patient First Name", "Patient Last Name", "Patient IC No.", "Gender"})
        Me.cboSearchPatient.Location = New System.Drawing.Point(1784, 261)
        Me.cboSearchPatient.Name = "cboSearchPatient"
        Me.cboSearchPatient.Size = New System.Drawing.Size(191, 28)
        Me.cboSearchPatient.TabIndex = 15
        Me.cboSearchPatient.Text = "Search By"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 341)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(2025, 639)
        Me.dgv.TabIndex = 16
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1881, 986)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 62)
        Me.btnBack.TabIndex = 17
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblResultsNo
        '
        Me.lblResultsNo.AutoSize = True
        Me.lblResultsNo.Location = New System.Drawing.Point(12, 986)
        Me.lblResultsNo.Name = "lblResultsNo"
        Me.lblResultsNo.Size = New System.Drawing.Size(67, 17)
        Me.lblResultsNo.TabIndex = 18
        Me.lblResultsNo.Text = "0 Results"
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.SystemColors.Window
        Me.cboGender.Enabled = False
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(1784, 299)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(242, 28)
        Me.cboGender.TabIndex = 19
        Me.cboGender.Visible = False
        '
        'cboSortSequence
        '
        Me.cboSortSequence.BackColor = System.Drawing.SystemColors.Window
        Me.cboSortSequence.Enabled = False
        Me.cboSortSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortSequence.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSortSequence.FormattingEnabled = True
        Me.cboSortSequence.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.cboSortSequence.Location = New System.Drawing.Point(41, 297)
        Me.cboSortSequence.Name = "cboSortSequence"
        Me.cboSortSequence.Size = New System.Drawing.Size(191, 28)
        Me.cboSortSequence.TabIndex = 20
        Me.cboSortSequence.Text = "Sorting Order"
        '
        'btnDeletePatient
        '
        Me.btnDeletePatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePatient.ForeColor = System.Drawing.Color.White
        Me.btnDeletePatient.Location = New System.Drawing.Point(1696, 986)
        Me.btnDeletePatient.Name = "btnDeletePatient"
        Me.btnDeletePatient.Size = New System.Drawing.Size(156, 62)
        Me.btnDeletePatient.TabIndex = 21
        Me.btnDeletePatient.Text = "Delete Patient"
        Me.btnDeletePatient.UseVisualStyleBackColor = False
        '
        'btnAddPatient
        '
        Me.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatient.ForeColor = System.Drawing.Color.White
        Me.btnAddPatient.Location = New System.Drawing.Point(1510, 986)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(156, 62)
        Me.btnAddPatient.TabIndex = 22
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.UseVisualStyleBackColor = False
        '
        'frmPatientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 1060)
        Me.Controls.Add(Me.btnAddPatient)
        Me.Controls.Add(Me.btnDeletePatient)
        Me.Controls.Add(Me.cboSortSequence)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.lblResultsNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cboSearchPatient)
        Me.Controls.Add(Me.txtSearchPatient)
        Me.Controls.Add(Me.lblSearchPatient)
        Me.Controls.Add(Me.cboSortPatient)
        Me.Controls.Add(Me.btnRegisterPatient)
        Me.Controls.Add(Me.lblPatientList)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPatientList"
        Me.Text = "frmPatientList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents btnRegisterPatient As Button
    Friend WithEvents cboSortPatient As ComboBox
    Friend WithEvents lblSearchPatient As Label
    Friend WithEvents txtSearchPatient As TextBox
    Friend WithEvents cboSearchPatient As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents lblResultsNo As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents cboSortSequence As ComboBox
    Friend WithEvents btnDeletePatient As Button
    Friend WithEvents btnAddPatient As Button
End Class
