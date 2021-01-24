<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAppointment
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
        Me.lblAddAppointment = New System.Windows.Forms.Label()
        Me.lblIdentityNo = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblOrganizationName = New System.Windows.Forms.Label()
        Me.lblAppointmentDetail = New System.Windows.Forms.Label()
        Me.txtAppointmentId = New System.Windows.Forms.TextBox()
        Me.lblAppointmentId = New System.Windows.Forms.Label()
        Me.lblAddAppointmentDetail = New System.Windows.Forms.Label()
        Me.btnUpdateAppointment = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radNewPatient = New System.Windows.Forms.RadioButton()
        Me.radExistingPatient = New System.Windows.Forms.RadioButton()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.mskIdentityNo = New System.Windows.Forms.MaskedTextBox()
        Me.mskContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblConsultationDateL = New System.Windows.Forms.Label()
        Me.lblConsultationTimeL = New System.Windows.Forms.Label()
        Me.lblConsultationDate = New System.Windows.Forms.Label()
        Me.lblConsultationTime = New System.Windows.Forms.Label()
        Me.chkEnableEdit = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddAppointment
        '
        Me.lblAddAppointment.AutoSize = True
        Me.lblAddAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddAppointment.Location = New System.Drawing.Point(30, 22)
        Me.lblAddAppointment.Name = "lblAddAppointment"
        Me.lblAddAppointment.Size = New System.Drawing.Size(202, 32)
        Me.lblAddAppointment.TabIndex = 48
        Me.lblAddAppointment.Text = "Appointments"
        '
        'lblIdentityNo
        '
        Me.lblIdentityNo.AutoSize = True
        Me.lblIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentityNo.Location = New System.Drawing.Point(103, 296)
        Me.lblIdentityNo.Name = "lblIdentityNo"
        Me.lblIdentityNo.Size = New System.Drawing.Size(129, 20)
        Me.lblIdentityNo.TabIndex = 6
        Me.lblIdentityNo.Text = "Identity Card No"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(933, 817)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(172, 58)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtEmailAddress)
        Me.Panel2.Controls.Add(Me.lblEmailAddress)
        Me.Panel2.Controls.Add(Me.mskContactNo)
        Me.Panel2.Controls.Add(Me.lblContactNo)
        Me.Panel2.Controls.Add(Me.mskIdentityNo)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.radExistingPatient)
        Me.Panel2.Controls.Add(Me.radNewPatient)
        Me.Panel2.Controls.Add(Me.lblIdentityNo)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Controls.Add(Me.txtPatientID)
        Me.Panel2.Controls.Add(Me.lblOrganizationName)
        Me.Panel2.Location = New System.Drawing.Point(33, 262)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 529)
        Me.Panel2.TabIndex = 43
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(107, 175)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(304, 27)
        Me.txtFirstName.TabIndex = 3
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(104, 152)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(92, 20)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(103, 224)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(91, 20)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(107, 101)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(304, 27)
        Me.txtPatientID.TabIndex = 1
        '
        'lblOrganizationName
        '
        Me.lblOrganizationName.AutoSize = True
        Me.lblOrganizationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganizationName.Location = New System.Drawing.Point(104, 80)
        Me.lblOrganizationName.Name = "lblOrganizationName"
        Me.lblOrganizationName.Size = New System.Drawing.Size(83, 20)
        Me.lblOrganizationName.TabIndex = 0
        Me.lblOrganizationName.Text = "Patient ID"
        '
        'lblAppointmentDetail
        '
        Me.lblAppointmentDetail.AutoSize = True
        Me.lblAppointmentDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentDetail.Location = New System.Drawing.Point(31, 234)
        Me.lblAppointmentDetail.Name = "lblAppointmentDetail"
        Me.lblAppointmentDetail.Size = New System.Drawing.Size(208, 25)
        Me.lblAppointmentDetail.TabIndex = 47
        Me.lblAppointmentDetail.Text = "Patient's Information"
        '
        'txtAppointmentId
        '
        Me.txtAppointmentId.Enabled = False
        Me.txtAppointmentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentId.Location = New System.Drawing.Point(108, 42)
        Me.txtAppointmentId.Name = "txtAppointmentId"
        Me.txtAppointmentId.Size = New System.Drawing.Size(303, 27)
        Me.txtAppointmentId.TabIndex = 1
        '
        'lblAppointmentId
        '
        Me.lblAppointmentId.AutoSize = True
        Me.lblAppointmentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentId.Location = New System.Drawing.Point(104, 19)
        Me.lblAppointmentId.Name = "lblAppointmentId"
        Me.lblAppointmentId.Size = New System.Drawing.Size(124, 20)
        Me.lblAppointmentId.TabIndex = 0
        Me.lblAppointmentId.Text = "Appointment ID"
        '
        'lblAddAppointmentDetail
        '
        Me.lblAddAppointmentDetail.AutoSize = True
        Me.lblAddAppointmentDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddAppointmentDetail.Location = New System.Drawing.Point(31, 80)
        Me.lblAddAppointmentDetail.Name = "lblAddAppointmentDetail"
        Me.lblAddAppointmentDetail.Size = New System.Drawing.Size(381, 25)
        Me.lblAddAppointmentDetail.TabIndex = 46
        Me.lblAddAppointmentDetail.Text = "Appointment Details Currently Viewing"
        '
        'btnUpdateAppointment
        '
        Me.btnUpdateAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAppointment.ForeColor = System.Drawing.Color.White
        Me.btnUpdateAppointment.Location = New System.Drawing.Point(706, 817)
        Me.btnUpdateAppointment.Name = "btnUpdateAppointment"
        Me.btnUpdateAppointment.Size = New System.Drawing.Size(172, 58)
        Me.btnUpdateAppointment.TabIndex = 44
        Me.btnUpdateAppointment.Text = "Update Appointment"
        Me.btnUpdateAppointment.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtAppointmentId)
        Me.Panel1.Controls.Add(Me.lblAppointmentId)
        Me.Panel1.Location = New System.Drawing.Point(33, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 99)
        Me.Panel1.TabIndex = 42
        '
        'radNewPatient
        '
        Me.radNewPatient.AutoSize = True
        Me.radNewPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNewPatient.Location = New System.Drawing.Point(114, 30)
        Me.radNewPatient.Name = "radNewPatient"
        Me.radNewPatient.Size = New System.Drawing.Size(120, 24)
        Me.radNewPatient.TabIndex = 10
        Me.radNewPatient.TabStop = True
        Me.radNewPatient.Text = "New Patient"
        Me.radNewPatient.UseVisualStyleBackColor = True
        '
        'radExistingPatient
        '
        Me.radExistingPatient.AutoSize = True
        Me.radExistingPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radExistingPatient.Location = New System.Drawing.Point(252, 30)
        Me.radExistingPatient.Name = "radExistingPatient"
        Me.radExistingPatient.Size = New System.Drawing.Size(146, 24)
        Me.radExistingPatient.TabIndex = 11
        Me.radExistingPatient.TabStop = True
        Me.radExistingPatient.Text = "Existing Patient"
        Me.radExistingPatient.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(106, 247)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(304, 27)
        Me.txtLastName.TabIndex = 12
        '
        'mskIdentityNo
        '
        Me.mskIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskIdentityNo.Location = New System.Drawing.Point(106, 319)
        Me.mskIdentityNo.Mask = "000000-00-0000"
        Me.mskIdentityNo.Name = "mskIdentityNo"
        Me.mskIdentityNo.Size = New System.Drawing.Size(304, 27)
        Me.mskIdentityNo.TabIndex = 13
        Me.mskIdentityNo.ValidatingType = GetType(Integer)
        '
        'mskContactNo
        '
        Me.mskContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskContactNo.Location = New System.Drawing.Point(109, 397)
        Me.mskContactNo.Mask = "000-00000000"
        Me.mskContactNo.Name = "mskContactNo"
        Me.mskContactNo.Size = New System.Drawing.Size(304, 27)
        Me.mskContactNo.TabIndex = 15
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(106, 374)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(93, 20)
        Me.lblContactNo.TabIndex = 14
        Me.lblContactNo.Text = "Contact No"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Location = New System.Drawing.Point(109, 473)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(304, 27)
        Me.txtEmailAddress.TabIndex = 17
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(105, 450)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(118, 20)
        Me.lblEmailAddress.TabIndex = 16
        Me.lblEmailAddress.Text = "Email Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(587, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Appointment Information"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblConsultationTime)
        Me.Panel3.Controls.Add(Me.lblConsultationDate)
        Me.Panel3.Controls.Add(Me.lblConsultationTimeL)
        Me.Panel3.Controls.Add(Me.lblConsultationDateL)
        Me.Panel3.Location = New System.Drawing.Point(592, 262)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(513, 529)
        Me.Panel3.TabIndex = 49
        '
        'lblConsultationDateL
        '
        Me.lblConsultationDateL.AutoSize = True
        Me.lblConsultationDateL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultationDateL.Location = New System.Drawing.Point(74, 30)
        Me.lblConsultationDateL.Name = "lblConsultationDateL"
        Me.lblConsultationDateL.Size = New System.Drawing.Size(167, 25)
        Me.lblConsultationDateL.TabIndex = 2
        Me.lblConsultationDateL.Text = "Consultation Date"
        '
        'lblConsultationTimeL
        '
        Me.lblConsultationTimeL.AutoSize = True
        Me.lblConsultationTimeL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultationTimeL.Location = New System.Drawing.Point(74, 125)
        Me.lblConsultationTimeL.Name = "lblConsultationTimeL"
        Me.lblConsultationTimeL.Size = New System.Drawing.Size(170, 25)
        Me.lblConsultationTimeL.TabIndex = 4
        Me.lblConsultationTimeL.Text = "Consultation Time"
        '
        'lblConsultationDate
        '
        Me.lblConsultationDate.AutoSize = True
        Me.lblConsultationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultationDate.Location = New System.Drawing.Point(75, 58)
        Me.lblConsultationDate.Name = "lblConsultationDate"
        Me.lblConsultationDate.Size = New System.Drawing.Size(47, 24)
        Me.lblConsultationDate.TabIndex = 5
        Me.lblConsultationDate.Text = "Text"
        '
        'lblConsultationTime
        '
        Me.lblConsultationTime.AutoSize = True
        Me.lblConsultationTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultationTime.Location = New System.Drawing.Point(75, 155)
        Me.lblConsultationTime.Name = "lblConsultationTime"
        Me.lblConsultationTime.Size = New System.Drawing.Size(47, 24)
        Me.lblConsultationTime.TabIndex = 6
        Me.lblConsultationTime.Text = "Text"
        '
        'chkEnableEdit
        '
        Me.chkEnableEdit.AutoSize = True
        Me.chkEnableEdit.Location = New System.Drawing.Point(33, 802)
        Me.chkEnableEdit.Name = "chkEnableEdit"
        Me.chkEnableEdit.Size = New System.Drawing.Size(101, 21)
        Me.chkEnableEdit.TabIndex = 56
        Me.chkEnableEdit.Text = "Edit Details"
        Me.chkEnableEdit.UseVisualStyleBackColor = True
        '
        'frmEditAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 897)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkEnableEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblAddAppointment)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblAppointmentDetail)
        Me.Controls.Add(Me.lblAddAppointmentDetail)
        Me.Controls.Add(Me.btnUpdateAppointment)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEditAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddAppointment As Label
    Friend WithEvents lblIdentityNo As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lblOrganizationName As Label
    Friend WithEvents lblAppointmentDetail As Label
    Friend WithEvents txtAppointmentId As TextBox
    Friend WithEvents lblAppointmentId As Label
    Friend WithEvents lblAddAppointmentDetail As Label
    Friend WithEvents btnUpdateAppointment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radExistingPatient As RadioButton
    Friend WithEvents radNewPatient As RadioButton
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents mskIdentityNo As MaskedTextBox
    Friend WithEvents mskContactNo As MaskedTextBox
    Friend WithEvents lblContactNo As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblConsultationTime As Label
    Friend WithEvents lblConsultationDate As Label
    Friend WithEvents lblConsultationTimeL As Label
    Friend WithEvents lblConsultationDateL As Label
    Friend WithEvents chkEnableEdit As CheckBox
End Class
