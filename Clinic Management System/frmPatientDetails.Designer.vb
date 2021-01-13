<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientDetails
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEditDetail = New System.Windows.Forms.Button()
        Me.lblPatientDetail = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblIdentityNo = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPatientId = New System.Windows.Forms.Label()
        Me.lblPatientIdR = New System.Windows.Forms.Label()
        Me.lblFirstNameR = New System.Windows.Forms.Label()
        Me.lblLastNameR = New System.Windows.Forms.Label()
        Me.lblIentityNoR = New System.Windows.Forms.Label()
        Me.lblAgeR = New System.Windows.Forms.Label()
        Me.lblGenderR = New System.Windows.Forms.Label()
        Me.lblContactNoR = New System.Windows.Forms.Label()
        Me.lblEmailAddressR = New System.Windows.Forms.Label()
        Me.lblAddressR = New System.Windows.Forms.Label()
        Me.lblCityR = New System.Windows.Forms.Label()
        Me.lblStateR = New System.Windows.Forms.Label()
        Me.lblPostCodeR = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(382, 688)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(156, 58)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnEditDetail
        '
        Me.btnEditDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDetail.ForeColor = System.Drawing.Color.White
        Me.btnEditDetail.Location = New System.Drawing.Point(135, 688)
        Me.btnEditDetail.Name = "btnEditDetail"
        Me.btnEditDetail.Size = New System.Drawing.Size(156, 58)
        Me.btnEditDetail.TabIndex = 24
        Me.btnEditDetail.Text = "Edit Details"
        Me.btnEditDetail.UseVisualStyleBackColor = False
        '
        'lblPatientDetail
        '
        Me.lblPatientDetail.AutoSize = True
        Me.lblPatientDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientDetail.Location = New System.Drawing.Point(28, 21)
        Me.lblPatientDetail.Name = "lblPatientDetail"
        Me.lblPatientDetail.Size = New System.Drawing.Size(134, 20)
        Me.lblPatientDetail.TabIndex = 23
        Me.lblPatientDetail.Text = "Patient Details"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(178, 470)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(39, 17)
        Me.lblCity.TabIndex = 19
        Me.lblCity.Text = "City: "
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(127, 571)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(92, 17)
        Me.lblPostalCode.TabIndex = 17
        Me.lblPostalCode.Text = "Postal Code: "
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(170, 521)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(49, 17)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "State: "
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(151, 417)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(68, 17)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address: "
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(113, 368)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(106, 17)
        Me.lblEmailAddress.TabIndex = 11
        Me.lblEmailAddress.Text = "Email Address: "
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Location = New System.Drawing.Point(133, 319)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(86, 17)
        Me.lblContactNo.TabIndex = 9
        Me.lblContactNo.Text = "Contact No: "
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(155, 268)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 17)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender: "
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(178, 216)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(41, 17)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "Age: "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(131, 121)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(88, 18)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name: "
        '
        'lblIdentityNo
        '
        Me.lblIdentityNo.AutoSize = True
        Me.lblIdentityNo.Location = New System.Drawing.Point(102, 167)
        Me.lblIdentityNo.Name = "lblIdentityNo"
        Me.lblIdentityNo.Size = New System.Drawing.Size(117, 17)
        Me.lblIdentityNo.TabIndex = 0
        Me.lblIdentityNo.Text = "Identity Card No: "
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(130, 73)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(89, 18)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblPostCodeR)
        Me.Panel2.Controls.Add(Me.lblStateR)
        Me.Panel2.Controls.Add(Me.lblCityR)
        Me.Panel2.Controls.Add(Me.lblAddressR)
        Me.Panel2.Controls.Add(Me.lblEmailAddressR)
        Me.Panel2.Controls.Add(Me.lblContactNoR)
        Me.Panel2.Controls.Add(Me.lblGenderR)
        Me.Panel2.Controls.Add(Me.lblAgeR)
        Me.Panel2.Controls.Add(Me.lblIentityNoR)
        Me.Panel2.Controls.Add(Me.lblLastNameR)
        Me.Panel2.Controls.Add(Me.lblFirstNameR)
        Me.Panel2.Controls.Add(Me.lblPatientIdR)
        Me.Panel2.Controls.Add(Me.lblPatientId)
        Me.Panel2.Controls.Add(Me.lblCity)
        Me.Panel2.Controls.Add(Me.lblPostalCode)
        Me.Panel2.Controls.Add(Me.lblState)
        Me.Panel2.Controls.Add(Me.lblAddress)
        Me.Panel2.Controls.Add(Me.lblEmailAddress)
        Me.Panel2.Controls.Add(Me.lblContactNo)
        Me.Panel2.Controls.Add(Me.lblGender)
        Me.Panel2.Controls.Add(Me.lblAge)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Controls.Add(Me.lblIdentityNo)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Location = New System.Drawing.Point(32, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(599, 622)
        Me.Panel2.TabIndex = 22
        '
        'lblPatientId
        '
        Me.lblPatientId.AutoSize = True
        Me.lblPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientId.Location = New System.Drawing.Point(140, 29)
        Me.lblPatientId.Name = "lblPatientId"
        Me.lblPatientId.Size = New System.Drawing.Size(79, 18)
        Me.lblPatientId.TabIndex = 0
        Me.lblPatientId.Text = "Patient ID: "
        '
        'lblPatientIdR
        '
        Me.lblPatientIdR.AutoSize = True
        Me.lblPatientIdR.Location = New System.Drawing.Point(225, 29)
        Me.lblPatientIdR.Name = "lblPatientIdR"
        Me.lblPatientIdR.Size = New System.Drawing.Size(30, 17)
        Me.lblPatientIdR.TabIndex = 25
        Me.lblPatientIdR.Text = "text"
        '
        'lblFirstNameR
        '
        Me.lblFirstNameR.AutoSize = True
        Me.lblFirstNameR.Location = New System.Drawing.Point(225, 75)
        Me.lblFirstNameR.Name = "lblFirstNameR"
        Me.lblFirstNameR.Size = New System.Drawing.Size(30, 17)
        Me.lblFirstNameR.TabIndex = 26
        Me.lblFirstNameR.Text = "text"
        '
        'lblLastNameR
        '
        Me.lblLastNameR.AutoSize = True
        Me.lblLastNameR.Location = New System.Drawing.Point(225, 121)
        Me.lblLastNameR.Name = "lblLastNameR"
        Me.lblLastNameR.Size = New System.Drawing.Size(30, 17)
        Me.lblLastNameR.TabIndex = 27
        Me.lblLastNameR.Text = "text"
        '
        'lblIentityNoR
        '
        Me.lblIentityNoR.AutoSize = True
        Me.lblIentityNoR.Location = New System.Drawing.Point(225, 167)
        Me.lblIentityNoR.Name = "lblIentityNoR"
        Me.lblIentityNoR.Size = New System.Drawing.Size(30, 17)
        Me.lblIentityNoR.TabIndex = 28
        Me.lblIentityNoR.Text = "text"
        '
        'lblAgeR
        '
        Me.lblAgeR.AutoSize = True
        Me.lblAgeR.Location = New System.Drawing.Point(225, 216)
        Me.lblAgeR.Name = "lblAgeR"
        Me.lblAgeR.Size = New System.Drawing.Size(30, 17)
        Me.lblAgeR.TabIndex = 29
        Me.lblAgeR.Text = "text"
        '
        'lblGenderR
        '
        Me.lblGenderR.AutoSize = True
        Me.lblGenderR.Location = New System.Drawing.Point(225, 268)
        Me.lblGenderR.Name = "lblGenderR"
        Me.lblGenderR.Size = New System.Drawing.Size(30, 17)
        Me.lblGenderR.TabIndex = 30
        Me.lblGenderR.Text = "text"
        '
        'lblContactNoR
        '
        Me.lblContactNoR.AutoSize = True
        Me.lblContactNoR.Location = New System.Drawing.Point(225, 319)
        Me.lblContactNoR.Name = "lblContactNoR"
        Me.lblContactNoR.Size = New System.Drawing.Size(30, 17)
        Me.lblContactNoR.TabIndex = 31
        Me.lblContactNoR.Text = "text"
        '
        'lblEmailAddressR
        '
        Me.lblEmailAddressR.AutoSize = True
        Me.lblEmailAddressR.Location = New System.Drawing.Point(225, 368)
        Me.lblEmailAddressR.Name = "lblEmailAddressR"
        Me.lblEmailAddressR.Size = New System.Drawing.Size(30, 17)
        Me.lblEmailAddressR.TabIndex = 32
        Me.lblEmailAddressR.Text = "text"
        '
        'lblAddressR
        '
        Me.lblAddressR.AutoSize = True
        Me.lblAddressR.Location = New System.Drawing.Point(225, 417)
        Me.lblAddressR.Name = "lblAddressR"
        Me.lblAddressR.Size = New System.Drawing.Size(30, 17)
        Me.lblAddressR.TabIndex = 33
        Me.lblAddressR.Text = "text"
        '
        'lblCityR
        '
        Me.lblCityR.AutoSize = True
        Me.lblCityR.Location = New System.Drawing.Point(225, 470)
        Me.lblCityR.Name = "lblCityR"
        Me.lblCityR.Size = New System.Drawing.Size(30, 17)
        Me.lblCityR.TabIndex = 34
        Me.lblCityR.Text = "text"
        '
        'lblStateR
        '
        Me.lblStateR.AutoSize = True
        Me.lblStateR.Location = New System.Drawing.Point(225, 522)
        Me.lblStateR.Name = "lblStateR"
        Me.lblStateR.Size = New System.Drawing.Size(30, 17)
        Me.lblStateR.TabIndex = 35
        Me.lblStateR.Text = "text"
        '
        'lblPostCodeR
        '
        Me.lblPostCodeR.AutoSize = True
        Me.lblPostCodeR.Location = New System.Drawing.Point(225, 571)
        Me.lblPostCodeR.Name = "lblPostCodeR"
        Me.lblPostCodeR.Size = New System.Drawing.Size(30, 17)
        Me.lblPostCodeR.TabIndex = 36
        Me.lblPostCodeR.Text = "text"
        '
        'frmPatientDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 765)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEditDetail)
        Me.Controls.Add(Me.lblPatientDetail)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPatientDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPatientDetails"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEditDetail As Button
    Friend WithEvents lblPatientDetail As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblIdentityNo As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPatientIdR As Label
    Friend WithEvents lblPatientId As Label
    Friend WithEvents lblLastNameR As Label
    Friend WithEvents lblFirstNameR As Label
    Friend WithEvents lblPostCodeR As Label
    Friend WithEvents lblStateR As Label
    Friend WithEvents lblCityR As Label
    Friend WithEvents lblAddressR As Label
    Friend WithEvents lblEmailAddressR As Label
    Friend WithEvents lblContactNoR As Label
    Friend WithEvents lblGenderR As Label
    Friend WithEvents lblAgeR As Label
    Friend WithEvents lblIentityNoR As Label
End Class
