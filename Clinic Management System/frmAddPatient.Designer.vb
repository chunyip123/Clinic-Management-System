<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPatient
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
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.mskIdentityNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.lblPatientDetail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.lblIdentityNo = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.mskPostalCode = New System.Windows.Forms.MaskedTextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mskContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.mskAge = New System.Windows.Forms.MaskedTextBox()
        Me.lblEditPatient = New System.Windows.Forms.Label()
        Me.txtPatientId = New System.Windows.Forms.TextBox()
        Me.lblPatientId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAddPatient = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(110, 50)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(304, 73)
        Me.txtAddress.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(106, 29)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(71, 20)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(106, 154)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(38, 20)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City"
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(106, 306)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(100, 20)
        Me.lblPostalCode.TabIndex = 6
        Me.lblPostalCode.Text = "Postal Code"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(106, 229)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(48, 20)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "State"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(191, 354)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(85, 24)
        Me.radFemale.TabIndex = 10
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(107, 354)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(66, 24)
        Me.radMale.TabIndex = 9
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'mskIdentityNo
        '
        Me.mskIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskIdentityNo.Location = New System.Drawing.Point(107, 196)
        Me.mskIdentityNo.Mask = "000000-00-0000"
        Me.mskIdentityNo.Name = "mskIdentityNo"
        Me.mskIdentityNo.Size = New System.Drawing.Size(304, 27)
        Me.mskIdentityNo.TabIndex = 5
        Me.mskIdentityNo.ValidatingType = GetType(Integer)
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Location = New System.Drawing.Point(107, 502)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(304, 27)
        Me.txtEmailAddress.TabIndex = 14
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(103, 479)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(118, 20)
        Me.lblEmailAddress.TabIndex = 13
        Me.lblEmailAddress.Text = "Email Address"
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(104, 400)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(93, 20)
        Me.lblContactNo.TabIndex = 11
        Me.lblContactNo.Text = "Contact No"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(103, 328)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 20)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(103, 246)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 20)
        Me.lblAge.TabIndex = 6
        Me.lblAge.Text = "Age"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(107, 124)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(304, 27)
        Me.txtLastName.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(942, 844)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(156, 58)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAddPatient
        '
        Me.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatient.ForeColor = System.Drawing.Color.White
        Me.btnAddPatient.Location = New System.Drawing.Point(736, 844)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(156, 58)
        Me.btnAddPatient.TabIndex = 4
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.UseVisualStyleBackColor = False
        '
        'lblPatientDetail
        '
        Me.lblPatientDetail.AutoSize = True
        Me.lblPatientDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientDetail.Location = New System.Drawing.Point(30, 240)
        Me.lblPatientDetail.Name = "lblPatientDetail"
        Me.lblPatientDetail.Size = New System.Drawing.Size(178, 25)
        Me.lblPatientDetail.TabIndex = 26
        Me.lblPatientDetail.Text = "Basic Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(580, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Address Information"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(104, 101)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(91, 20)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'cboCity
        '
        Me.cboCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Items.AddRange(New Object() {"Subang Jaya", "Klang"})
        Me.cboCity.Location = New System.Drawing.Point(110, 177)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(304, 28)
        Me.cboCity.TabIndex = 3
        '
        'lblIdentityNo
        '
        Me.lblIdentityNo.AutoSize = True
        Me.lblIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentityNo.Location = New System.Drawing.Point(103, 173)
        Me.lblIdentityNo.Name = "lblIdentityNo"
        Me.lblIdentityNo.Size = New System.Drawing.Size(129, 20)
        Me.lblIdentityNo.TabIndex = 4
        Me.lblIdentityNo.Text = "Identity Card No"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(107, 50)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(304, 27)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(104, 29)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(92, 20)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.mskPostalCode)
        Me.Panel3.Controls.Add(Me.cboState)
        Me.Panel3.Controls.Add(Me.cboCity)
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.lblAddress)
        Me.Panel3.Controls.Add(Me.lblCity)
        Me.Panel3.Controls.Add(Me.lblPostalCode)
        Me.Panel3.Controls.Add(Me.lblState)
        Me.Panel3.Location = New System.Drawing.Point(585, 268)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(513, 564)
        Me.Panel3.TabIndex = 3
        '
        'mskPostalCode
        '
        Me.mskPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPostalCode.Location = New System.Drawing.Point(110, 329)
        Me.mskPostalCode.Mask = "00000"
        Me.mskPostalCode.Name = "mskPostalCode"
        Me.mskPostalCode.Size = New System.Drawing.Size(304, 27)
        Me.mskPostalCode.TabIndex = 7
        '
        'cboState
        '
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Selangor", "Kuala Lumpur"})
        Me.cboState.Location = New System.Drawing.Point(110, 252)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(304, 28)
        Me.cboState.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.mskContactNo)
        Me.Panel2.Controls.Add(Me.mskAge)
        Me.Panel2.Controls.Add(Me.radFemale)
        Me.Panel2.Controls.Add(Me.radMale)
        Me.Panel2.Controls.Add(Me.mskIdentityNo)
        Me.Panel2.Controls.Add(Me.txtEmailAddress)
        Me.Panel2.Controls.Add(Me.lblEmailAddress)
        Me.Panel2.Controls.Add(Me.lblContactNo)
        Me.Panel2.Controls.Add(Me.lblGender)
        Me.Panel2.Controls.Add(Me.lblAge)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Controls.Add(Me.lblIdentityNo)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Location = New System.Drawing.Point(32, 268)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 564)
        Me.Panel2.TabIndex = 1
        '
        'mskContactNo
        '
        Me.mskContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskContactNo.Location = New System.Drawing.Point(107, 423)
        Me.mskContactNo.Mask = "000-00000000"
        Me.mskContactNo.Name = "mskContactNo"
        Me.mskContactNo.Size = New System.Drawing.Size(304, 27)
        Me.mskContactNo.TabIndex = 12
        '
        'mskAge
        '
        Me.mskAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskAge.Location = New System.Drawing.Point(107, 269)
        Me.mskAge.Mask = "000"
        Me.mskAge.Name = "mskAge"
        Me.mskAge.Size = New System.Drawing.Size(304, 27)
        Me.mskAge.TabIndex = 7
        Me.mskAge.ValidatingType = GetType(Integer)
        '
        'lblEditPatient
        '
        Me.lblEditPatient.AutoSize = True
        Me.lblEditPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditPatient.Location = New System.Drawing.Point(30, 86)
        Me.lblEditPatient.Name = "lblEditPatient"
        Me.lblEditPatient.Size = New System.Drawing.Size(319, 25)
        Me.lblEditPatient.TabIndex = 24
        Me.lblEditPatient.Text = "Patient Details Currently Adding"
        '
        'txtPatientId
        '
        Me.txtPatientId.Enabled = False
        Me.txtPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientId.Location = New System.Drawing.Point(108, 42)
        Me.txtPatientId.Name = "txtPatientId"
        Me.txtPatientId.Size = New System.Drawing.Size(303, 27)
        Me.txtPatientId.TabIndex = 1
        '
        'lblPatientId
        '
        Me.lblPatientId.AutoSize = True
        Me.lblPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientId.Location = New System.Drawing.Point(104, 19)
        Me.lblPatientId.Name = "lblPatientId"
        Me.lblPatientId.Size = New System.Drawing.Size(83, 20)
        Me.lblPatientId.TabIndex = 0
        Me.lblPatientId.Text = "Patient ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPatientId)
        Me.Panel1.Controls.Add(Me.lblPatientId)
        Me.Panel1.Location = New System.Drawing.Point(32, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 99)
        Me.Panel1.TabIndex = 0
        '
        'lblAddPatient
        '
        Me.lblAddPatient.AutoSize = True
        Me.lblAddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddPatient.Location = New System.Drawing.Point(29, 28)
        Me.lblAddPatient.Name = "lblAddPatient"
        Me.lblAddPatient.Size = New System.Drawing.Size(241, 32)
        Me.lblAddPatient.TabIndex = 32
        Me.lblAddPatient.Text = "Add New Patient"
        '
        'frmAddPatient
        '
        Me.AcceptButton = Me.btnAddPatient
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1131, 917)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAddPatient)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddPatient)
        Me.Controls.Add(Me.lblPatientDetail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblEditPatient)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents mskIdentityNo As MaskedTextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents lblPatientDetail As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents cboCity As ComboBox
    Friend WithEvents lblIdentityNo As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboState As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblEditPatient As Label
    Friend WithEvents txtPatientId As TextBox
    Friend WithEvents lblPatientId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAddPatient As Label
    Friend WithEvents mskAge As MaskedTextBox
    Friend WithEvents mskContactNo As MaskedTextBox
    Friend WithEvents mskPostalCode As MaskedTextBox
End Class
