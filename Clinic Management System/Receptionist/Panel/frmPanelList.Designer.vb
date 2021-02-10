<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPanelList
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
        Me.btnDeleteOrganization = New System.Windows.Forms.Button()
        Me.cboSortSequence = New System.Windows.Forms.ComboBox()
        Me.lblResultsNo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cboSearchOrganization = New System.Windows.Forms.ComboBox()
        Me.txtSearchOrganization = New System.Windows.Forms.TextBox()
        Me.lblSearchOrganization = New System.Windows.Forms.Label()
        Me.cboSortPanel = New System.Windows.Forms.ComboBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAddOrganization = New System.Windows.Forms.Button()
        Me.lblPanelList = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDeleteOrganization
        '
        Me.btnDeleteOrganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrganization.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrganization.Location = New System.Drawing.Point(1697, 987)
        Me.btnDeleteOrganization.Name = "btnDeleteOrganization"
        Me.btnDeleteOrganization.Size = New System.Drawing.Size(156, 62)
        Me.btnDeleteOrganization.TabIndex = 34
        Me.btnDeleteOrganization.Text = "Delete Organization"
        Me.btnDeleteOrganization.UseVisualStyleBackColor = False
        '
        'cboSortSequence
        '
        Me.cboSortSequence.BackColor = System.Drawing.SystemColors.Window
        Me.cboSortSequence.Enabled = False
        Me.cboSortSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortSequence.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSortSequence.FormattingEnabled = True
        Me.cboSortSequence.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.cboSortSequence.Location = New System.Drawing.Point(42, 298)
        Me.cboSortSequence.Name = "cboSortSequence"
        Me.cboSortSequence.Size = New System.Drawing.Size(191, 28)
        Me.cboSortSequence.TabIndex = 33
        Me.cboSortSequence.Text = "Sorting Order"
        '
        'lblResultsNo
        '
        Me.lblResultsNo.AutoSize = True
        Me.lblResultsNo.Location = New System.Drawing.Point(13, 987)
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
        Me.btnBack.Location = New System.Drawing.Point(1882, 987)
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
        Me.dgv.Location = New System.Drawing.Point(13, 342)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(2025, 639)
        Me.dgv.TabIndex = 29
        '
        'cboSearchOrganization
        '
        Me.cboSearchOrganization.BackColor = System.Drawing.SystemColors.Window
        Me.cboSearchOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchOrganization.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSearchOrganization.FormattingEnabled = True
        Me.cboSearchOrganization.Items.AddRange(New Object() {"Panel ID", "Organization Name", "Organization Code", "Organization Contact No."})
        Me.cboSearchOrganization.Location = New System.Drawing.Point(1785, 262)
        Me.cboSearchOrganization.Name = "cboSearchOrganization"
        Me.cboSearchOrganization.Size = New System.Drawing.Size(191, 28)
        Me.cboSearchOrganization.TabIndex = 28
        Me.cboSearchOrganization.Text = "Search By"
        '
        'txtSearchOrganization
        '
        Me.txtSearchOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchOrganization.Location = New System.Drawing.Point(1785, 300)
        Me.txtSearchOrganization.Name = "txtSearchOrganization"
        Me.txtSearchOrganization.Size = New System.Drawing.Size(242, 27)
        Me.txtSearchOrganization.TabIndex = 27
        '
        'lblSearchOrganization
        '
        Me.lblSearchOrganization.AutoSize = True
        Me.lblSearchOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchOrganization.Location = New System.Drawing.Point(1632, 303)
        Me.lblSearchOrganization.Name = "lblSearchOrganization"
        Me.lblSearchOrganization.Size = New System.Drawing.Size(141, 20)
        Me.lblSearchOrganization.TabIndex = 26
        Me.lblSearchOrganization.Text = "Search Keyword: "
        '
        'cboSortPanel
        '
        Me.cboSortPanel.BackColor = System.Drawing.SystemColors.Window
        Me.cboSortPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortPanel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSortPanel.FormattingEnabled = True
        Me.cboSortPanel.Items.AddRange(New Object() {"Organization Name", "Organization Code", "Daily Insured Limit"})
        Me.cboSortPanel.Location = New System.Drawing.Point(42, 262)
        Me.cboSortPanel.Name = "cboSortPanel"
        Me.cboSortPanel.Size = New System.Drawing.Size(191, 28)
        Me.cboSortPanel.TabIndex = 25
        Me.cboSortPanel.Text = "Sort By"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(-1, 0)
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
        'btnAddOrganization
        '
        Me.btnAddOrganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrganization.ForeColor = System.Drawing.Color.White
        Me.btnAddOrganization.Location = New System.Drawing.Point(42, 177)
        Me.btnAddOrganization.Name = "btnAddOrganization"
        Me.btnAddOrganization.Size = New System.Drawing.Size(191, 67)
        Me.btnAddOrganization.TabIndex = 24
        Me.btnAddOrganization.Text = "Add Organization"
        Me.btnAddOrganization.UseVisualStyleBackColor = False
        '
        'lblPanelList
        '
        Me.lblPanelList.AutoSize = True
        Me.lblPanelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelList.Location = New System.Drawing.Point(36, 106)
        Me.lblPanelList.Name = "lblPanelList"
        Me.lblPanelList.Size = New System.Drawing.Size(330, 38)
        Me.lblPanelList.TabIndex = 22
        Me.lblPanelList.Text = "Panel Organizations"
        '
        'frmPanelList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2050, 1060)
        Me.Controls.Add(Me.btnDeleteOrganization)
        Me.Controls.Add(Me.cboSortSequence)
        Me.Controls.Add(Me.lblResultsNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cboSearchOrganization)
        Me.Controls.Add(Me.txtSearchOrganization)
        Me.Controls.Add(Me.lblSearchOrganization)
        Me.Controls.Add(Me.cboSortPanel)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.btnAddOrganization)
        Me.Controls.Add(Me.lblPanelList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPanelList"
        Me.Text = "frmPanelList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteOrganization As Button
    Friend WithEvents cboSortSequence As ComboBox
    Friend WithEvents lblResultsNo As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cboSearchOrganization As ComboBox
    Friend WithEvents txtSearchOrganization As TextBox
    Friend WithEvents lblSearchOrganization As Label
    Friend WithEvents cboSortPanel As ComboBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnAddOrganization As Button
    Friend WithEvents lblPanelList As Label
End Class
