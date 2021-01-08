<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.btnPatients = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnPanel = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.Location = New System.Drawing.Point(67, 84)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(118, 26)
        Me.lblDashboard.TabIndex = 0
        Me.lblDashboard.Text = "Dashboard"
        '
        'btnPatients
        '
        Me.btnPatients.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatients.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatients.ForeColor = System.Drawing.Color.White
        Me.btnPatients.Location = New System.Drawing.Point(72, 132)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.Size = New System.Drawing.Size(205, 213)
        Me.btnPatients.TabIndex = 2
        Me.btnPatients.Text = "Patients List"
        Me.btnPatients.UseVisualStyleBackColor = False
        '
        'btnAppointments
        '
        Me.btnAppointments.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointments.ForeColor = System.Drawing.Color.White
        Me.btnAppointments.Location = New System.Drawing.Point(501, 132)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(205, 213)
        Me.btnAppointments.TabIndex = 3
        Me.btnAppointments.Text = "Appointments"
        Me.btnAppointments.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(915, 132)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(205, 213)
        Me.btnPayment.TabIndex = 4
        Me.btnPayment.Text = "Medicine Collection / Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Location = New System.Drawing.Point(72, 439)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(205, 213)
        Me.btnInventory.TabIndex = 5
        Me.btnInventory.Text = "Medical Inventory"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnPanel
        '
        Me.btnPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanel.ForeColor = System.Drawing.Color.White
        Me.btnPanel.Location = New System.Drawing.Point(501, 439)
        Me.btnPanel.Name = "btnPanel"
        Me.btnPanel.Size = New System.Drawing.Size(205, 213)
        Me.btnPanel.TabIndex = 6
        Me.btnPanel.Text = "Panel Organizations"
        Me.btnPanel.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
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
        Me.pnlTop.Location = New System.Drawing.Point(-1, -2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1189, 60)
        Me.pnlTop.TabIndex = 1
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 696)
        Me.Controls.Add(Me.btnPanel)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnAppointments)
        Me.Controls.Add(Me.btnPatients)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lblDashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDashboard As Label
    Friend WithEvents btnPatients As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnPanel As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblClinic As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents pnlTop As Panel
End Class
