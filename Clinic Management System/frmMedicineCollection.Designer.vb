<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicineCollection
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
        Me.btnCheckCollection = New System.Windows.Forms.Button()
        Me.lblResultsNo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMedicineCollectionList = New System.Windows.Forms.Label()
        Me.btnRFCtab = New System.Windows.Forms.Button()
        Me.btnPendingtab = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCheckCollection
        '
        Me.btnCheckCollection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheckCollection.Enabled = False
        Me.btnCheckCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckCollection.ForeColor = System.Drawing.Color.White
        Me.btnCheckCollection.Location = New System.Drawing.Point(1665, 985)
        Me.btnCheckCollection.Name = "btnCheckCollection"
        Me.btnCheckCollection.Size = New System.Drawing.Size(189, 62)
        Me.btnCheckCollection.TabIndex = 34
        Me.btnCheckCollection.Text = "View Collection Details"
        Me.btnCheckCollection.UseVisualStyleBackColor = False
        '
        'lblResultsNo
        '
        Me.lblResultsNo.AutoSize = True
        Me.lblResultsNo.Location = New System.Drawing.Point(14, 985)
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
        Me.btnBack.Location = New System.Drawing.Point(1883, 985)
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
        Me.dgv.Location = New System.Drawing.Point(14, 246)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(2025, 733)
        Me.dgv.TabIndex = 29
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(0, -2)
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
        'lblMedicineCollectionList
        '
        Me.lblMedicineCollectionList.AutoSize = True
        Me.lblMedicineCollectionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicineCollectionList.Location = New System.Drawing.Point(37, 104)
        Me.lblMedicineCollectionList.Name = "lblMedicineCollectionList"
        Me.lblMedicineCollectionList.Size = New System.Drawing.Size(318, 38)
        Me.lblMedicineCollectionList.TabIndex = 22
        Me.lblMedicineCollectionList.Text = "Medicine Collection"
        '
        'btnRFCtab
        '
        Me.btnRFCtab.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRFCtab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRFCtab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFCtab.Location = New System.Drawing.Point(14, 186)
        Me.btnRFCtab.Name = "btnRFCtab"
        Me.btnRFCtab.Size = New System.Drawing.Size(201, 61)
        Me.btnRFCtab.TabIndex = 37
        Me.btnRFCtab.Text = "Ready for Collection"
        Me.btnRFCtab.UseVisualStyleBackColor = False
        '
        'btnPendingtab
        '
        Me.btnPendingtab.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPendingtab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendingtab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingtab.Location = New System.Drawing.Point(214, 186)
        Me.btnPendingtab.Name = "btnPendingtab"
        Me.btnPendingtab.Size = New System.Drawing.Size(201, 61)
        Me.btnPendingtab.TabIndex = 38
        Me.btnPendingtab.Text = "Pending"
        Me.btnPendingtab.UseVisualStyleBackColor = False
        '
        'frmMedicineCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2050, 1060)
        Me.Controls.Add(Me.btnPendingtab)
        Me.Controls.Add(Me.btnRFCtab)
        Me.Controls.Add(Me.btnCheckCollection)
        Me.Controls.Add(Me.lblResultsNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lblMedicineCollectionList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMedicineCollection"
        Me.Text = "Pending"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheckCollection As Button
    Friend WithEvents lblResultsNo As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblMedicineCollectionList As Label
    Friend WithEvents btnRFCtab As Button
    Friend WithEvents btnPendingtab As Button
End Class
