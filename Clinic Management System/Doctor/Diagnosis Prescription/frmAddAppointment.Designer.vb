<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAppointment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIcNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.lblAppointmentID = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblIcNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 49)
        Me.Panel1.TabIndex = 0
        '
        'lblIcNo
        '
        Me.lblIcNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblIcNo.Location = New System.Drawing.Point(230, 12)
        Me.lblIcNo.Name = "lblIcNo"
        Me.lblIcNo.Size = New System.Drawing.Size(357, 23)
        Me.lblIcNo.TabIndex = 14
        Me.lblIcNo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Appointment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(34, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Appointment ID: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(84, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Patient ID: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(74, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First Name: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(74, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(26, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact Number: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(42, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email Address: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(127, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Date: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(124, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Time: "
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAdd.Location = New System.Drawing.Point(132, 507)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 50)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCancel.Location = New System.Drawing.Point(358, 507)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 50)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpDate.Location = New System.Drawing.Point(219, 379)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(352, 30)
        Me.dtpDate.TabIndex = 11
        '
        'cboTime
        '
        Me.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Items.AddRange(New Object() {"9.00 AM", "9.15 AM", "9.30 AM", "9.45 AM", "10.00 AM", "10.15 AM", "10.30 AM", "10.45 AM"})
        Me.cboTime.Location = New System.Drawing.Point(219, 432)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(352, 33)
        Me.cboTime.TabIndex = 12
        '
        'lblAppointmentID
        '
        Me.lblAppointmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAppointmentID.Location = New System.Drawing.Point(214, 74)
        Me.lblAppointmentID.Name = "lblAppointmentID"
        Me.lblAppointmentID.Size = New System.Drawing.Size(357, 23)
        Me.lblAppointmentID.TabIndex = 13
        '
        'lblPatientID
        '
        Me.lblPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPatientID.Location = New System.Drawing.Point(214, 122)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(357, 23)
        Me.lblPatientID.TabIndex = 14
        '
        'lblFirstName
        '
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(214, 174)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(357, 23)
        Me.lblFirstName.TabIndex = 15
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblLastName.Location = New System.Drawing.Point(214, 225)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(357, 23)
        Me.lblLastName.TabIndex = 16
        '
        'lblContactNo
        '
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblContactNo.Location = New System.Drawing.Point(214, 275)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(357, 23)
        Me.lblContactNo.TabIndex = 17
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEmailAddress.Location = New System.Drawing.Point(214, 326)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(357, 23)
        Me.lblEmailAddress.TabIndex = 18
        '
        'frmAddAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 618)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.lblAppointmentID)
        Me.Controls.Add(Me.cboTime)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddAppointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents lblAppointmentID As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblIcNo As Label
End Class
