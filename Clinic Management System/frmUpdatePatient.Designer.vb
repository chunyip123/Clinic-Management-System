<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePatient
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
        Me.txtPatientId = New System.Windows.Forms.TextBox()
        Me.lblPatientId = New System.Windows.Forms.Label()
        Me.lblEditPatient = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.mskIdentityNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblIdentityNo = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPatientDetail = New System.Windows.Forms.Label()
        Me.btnUpdateDetail = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkEnableEdit = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPatientId)
        Me.Panel1.Controls.Add(Me.lblPatientId)
        Me.Panel1.Location = New System.Drawing.Point(30, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 99)
        Me.Panel1.TabIndex = 0
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
        'lblEditPatient
        '
        Me.lblEditPatient.AutoSize = True
        Me.lblEditPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditPatient.Location = New System.Drawing.Point(28, 21)
        Me.lblEditPatient.Name = "lblEditPatient"
        Me.lblEditPatient.Size = New System.Drawing.Size(327, 25)
        Me.lblEditPatient.TabIndex = 1
        Me.lblEditPatient.Text = "Patient Details Currently Viewing"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.radFemale)
        Me.Panel2.Controls.Add(Me.radMale)
        Me.Panel2.Controls.Add(Me.mskIdentityNo)
        Me.Panel2.Controls.Add(Me.txtEmailAddress)
        Me.Panel2.Controls.Add(Me.lblEmailAddress)
        Me.Panel2.Controls.Add(Me.txtContactNo)
        Me.Panel2.Controls.Add(Me.lblContactNo)
        Me.Panel2.Controls.Add(Me.lblGender)
        Me.Panel2.Controls.Add(Me.txtAge)
        Me.Panel2.Controls.Add(Me.lblAge)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Controls.Add(Me.lblIdentityNo)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Location = New System.Drawing.Point(30, 203)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 564)
        Me.Panel2.TabIndex = 2
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Enabled = False
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(191, 354)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(85, 24)
        Me.radFemale.TabIndex = 22
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Enabled = False
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(107, 354)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(66, 24)
        Me.radMale.TabIndex = 21
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'mskIdentityNo
        '
        Me.mskIdentityNo.Enabled = False
        Me.mskIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskIdentityNo.Location = New System.Drawing.Point(107, 196)
        Me.mskIdentityNo.Mask = "000000-00-0000"
        Me.mskIdentityNo.Name = "mskIdentityNo"
        Me.mskIdentityNo.Size = New System.Drawing.Size(304, 27)
        Me.mskIdentityNo.TabIndex = 4
        Me.mskIdentityNo.ValidatingType = GetType(Integer)
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Enabled = False
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Location = New System.Drawing.Point(107, 502)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(304, 27)
        Me.txtEmailAddress.TabIndex = 12
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(103, 479)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(118, 20)
        Me.lblEmailAddress.TabIndex = 11
        Me.lblEmailAddress.Text = "Email Address"
        '
        'txtContactNo
        '
        Me.txtContactNo.Enabled = False
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(107, 423)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(304, 27)
        Me.txtContactNo.TabIndex = 10
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(104, 400)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(93, 20)
        Me.lblContactNo.TabIndex = 9
        Me.lblContactNo.Text = "Contact No"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(103, 328)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 20)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(107, 270)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(304, 27)
        Me.txtAge.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(103, 246)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 20)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "Age"
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(107, 124)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(304, 27)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(104, 101)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(91, 20)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
        '
        'lblIdentityNo
        '
        Me.lblIdentityNo.AutoSize = True
        Me.lblIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentityNo.Location = New System.Drawing.Point(103, 173)
        Me.lblIdentityNo.Name = "lblIdentityNo"
        Me.lblIdentityNo.Size = New System.Drawing.Size(129, 20)
        Me.lblIdentityNo.TabIndex = 0
        Me.lblIdentityNo.Text = "Identity Card No"
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(107, 50)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(304, 27)
        Me.txtFirstName.TabIndex = 2
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
        'cboCity
        '
        Me.cboCity.Enabled = False
        Me.cboCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Items.AddRange(New Object() {"Subang Jaya", "Klang"})
        Me.cboCity.Location = New System.Drawing.Point(110, 177)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(304, 28)
        Me.cboCity.TabIndex = 24
        '
        'cboState
        '
        Me.cboState.Enabled = False
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Selangor", "Kuala Lumpur"})
        Me.cboState.Location = New System.Drawing.Point(110, 252)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(304, 28)
        Me.cboState.TabIndex = 23
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(106, 154)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(38, 20)
        Me.lblCity.TabIndex = 19
        Me.lblCity.Text = "City"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Enabled = False
        Me.txtPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(110, 329)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(304, 27)
        Me.txtPostalCode.TabIndex = 18
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(106, 306)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(100, 20)
        Me.lblPostalCode.TabIndex = 17
        Me.lblPostalCode.Text = "Postal Code"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(106, 229)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(48, 20)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "State"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(110, 50)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(304, 73)
        Me.txtAddress.TabIndex = 14
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(106, 29)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(71, 20)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address"
        '
        'lblPatientDetail
        '
        Me.lblPatientDetail.AutoSize = True
        Me.lblPatientDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientDetail.Location = New System.Drawing.Point(28, 175)
        Me.lblPatientDetail.Name = "lblPatientDetail"
        Me.lblPatientDetail.Size = New System.Drawing.Size(178, 25)
        Me.lblPatientDetail.TabIndex = 3
        Me.lblPatientDetail.Text = "Basic Information"
        '
        'btnUpdateDetail
        '
        Me.btnUpdateDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateDetail.Enabled = False
        Me.btnUpdateDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDetail.ForeColor = System.Drawing.Color.White
        Me.btnUpdateDetail.Location = New System.Drawing.Point(734, 779)
        Me.btnUpdateDetail.Name = "btnUpdateDetail"
        Me.btnUpdateDetail.Size = New System.Drawing.Size(156, 58)
        Me.btnUpdateDetail.TabIndex = 18
        Me.btnUpdateDetail.Text = "Update Details"
        Me.btnUpdateDetail.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(940, 779)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(156, 58)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'chkEnableEdit
        '
        Me.chkEnableEdit.AutoSize = True
        Me.chkEnableEdit.Location = New System.Drawing.Point(33, 779)
        Me.chkEnableEdit.Name = "chkEnableEdit"
        Me.chkEnableEdit.Size = New System.Drawing.Size(101, 21)
        Me.chkEnableEdit.TabIndex = 20
        Me.chkEnableEdit.Text = "Edit Details"
        Me.chkEnableEdit.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cboState)
        Me.Panel3.Controls.Add(Me.cboCity)
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.lblAddress)
        Me.Panel3.Controls.Add(Me.txtPostalCode)
        Me.Panel3.Controls.Add(Me.lblCity)
        Me.Panel3.Controls.Add(Me.lblPostalCode)
        Me.Panel3.Controls.Add(Me.lblState)
        Me.Panel3.Location = New System.Drawing.Point(583, 203)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(513, 564)
        Me.Panel3.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Address Information"
        '
        'frmUpdatePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 849)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.chkEnableEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdateDetail)
        Me.Controls.Add(Me.lblPatientDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblEditPatient)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdatePatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdatePatient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPatientId As TextBox
    Friend WithEvents lblPatientId As Label
    Friend WithEvents lblEditPatient As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblIdentityNo As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblPatientDetail As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents btnUpdateDetail As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents mskIdentityNo As MaskedTextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents cboState As ComboBox
    Friend WithEvents cboCity As ComboBox
    Friend WithEvents chkEnableEdit As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
