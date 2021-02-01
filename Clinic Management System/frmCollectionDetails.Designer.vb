<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionDetails
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
        Me.btnProceedCheckout = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMedicineCollectionList = New System.Windows.Forms.Label()
        Me.lblPatientInformation = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEmailAddressR = New System.Windows.Forms.Label()
        Me.lblContactNoR = New System.Windows.Forms.Label()
        Me.lblGenderR = New System.Windows.Forms.Label()
        Me.lblAgeR = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblIentityNoR = New System.Windows.Forms.Label()
        Me.lblLastNameR = New System.Windows.Forms.Label()
        Me.lblFirstNameR = New System.Windows.Forms.Label()
        Me.lblPatientIdR = New System.Windows.Forms.Label()
        Me.lblPatientId = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblIdentityNo = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMedicineToCollect = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.chkCollectionDone = New System.Windows.Forms.CheckBox()
        Me.pnlTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProceedCheckout
        '
        Me.btnProceedCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProceedCheckout.Enabled = False
        Me.btnProceedCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceedCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceedCheckout.ForeColor = System.Drawing.Color.White
        Me.btnProceedCheckout.Location = New System.Drawing.Point(1698, 986)
        Me.btnProceedCheckout.Name = "btnProceedCheckout"
        Me.btnProceedCheckout.Size = New System.Drawing.Size(156, 62)
        Me.btnProceedCheckout.TabIndex = 44
        Me.btnProceedCheckout.Text = "Proceed To Checkout"
        Me.btnProceedCheckout.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1883, 986)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 62)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(0, -1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(2050, 83)
        Me.pnlTop.TabIndex = 40
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
        Me.lblMedicineCollectionList.Location = New System.Drawing.Point(37, 105)
        Me.lblMedicineCollectionList.Name = "lblMedicineCollectionList"
        Me.lblMedicineCollectionList.Size = New System.Drawing.Size(318, 38)
        Me.lblMedicineCollectionList.TabIndex = 39
        Me.lblMedicineCollectionList.Text = "Medicine Collection"
        '
        'lblPatientInformation
        '
        Me.lblPatientInformation.AutoSize = True
        Me.lblPatientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientInformation.Location = New System.Drawing.Point(43, 169)
        Me.lblPatientInformation.Name = "lblPatientInformation"
        Me.lblPatientInformation.Size = New System.Drawing.Size(228, 29)
        Me.lblPatientInformation.TabIndex = 45
        Me.lblPatientInformation.Text = "Patient's Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblEmailAddressR)
        Me.Panel1.Controls.Add(Me.lblContactNoR)
        Me.Panel1.Controls.Add(Me.lblGenderR)
        Me.Panel1.Controls.Add(Me.lblAgeR)
        Me.Panel1.Controls.Add(Me.lblEmailAddress)
        Me.Panel1.Controls.Add(Me.lblContactNo)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.lblAge)
        Me.Panel1.Controls.Add(Me.lblIentityNoR)
        Me.Panel1.Controls.Add(Me.lblLastNameR)
        Me.Panel1.Controls.Add(Me.lblFirstNameR)
        Me.Panel1.Controls.Add(Me.lblPatientIdR)
        Me.Panel1.Controls.Add(Me.lblPatientId)
        Me.Panel1.Controls.Add(Me.lblLastName)
        Me.Panel1.Controls.Add(Me.lblIdentityNo)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Location = New System.Drawing.Point(48, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1952, 267)
        Me.Panel1.TabIndex = 46
        '
        'lblEmailAddressR
        '
        Me.lblEmailAddressR.AutoSize = True
        Me.lblEmailAddressR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddressR.Location = New System.Drawing.Point(1017, 201)
        Me.lblEmailAddressR.Name = "lblEmailAddressR"
        Me.lblEmailAddressR.Size = New System.Drawing.Size(43, 25)
        Me.lblEmailAddressR.TabIndex = 44
        Me.lblEmailAddressR.Text = "text"
        '
        'lblContactNoR
        '
        Me.lblContactNoR.AutoSize = True
        Me.lblContactNoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNoR.Location = New System.Drawing.Point(1017, 146)
        Me.lblContactNoR.Name = "lblContactNoR"
        Me.lblContactNoR.Size = New System.Drawing.Size(43, 25)
        Me.lblContactNoR.TabIndex = 43
        Me.lblContactNoR.Text = "text"
        '
        'lblGenderR
        '
        Me.lblGenderR.AutoSize = True
        Me.lblGenderR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenderR.Location = New System.Drawing.Point(1017, 90)
        Me.lblGenderR.Name = "lblGenderR"
        Me.lblGenderR.Size = New System.Drawing.Size(43, 25)
        Me.lblGenderR.TabIndex = 42
        Me.lblGenderR.Text = "text"
        '
        'lblAgeR
        '
        Me.lblAgeR.AutoSize = True
        Me.lblAgeR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeR.Location = New System.Drawing.Point(1017, 37)
        Me.lblAgeR.Name = "lblAgeR"
        Me.lblAgeR.Size = New System.Drawing.Size(43, 25)
        Me.lblAgeR.TabIndex = 41
        Me.lblAgeR.Text = "text"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(864, 201)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(149, 25)
        Me.lblEmailAddress.TabIndex = 40
        Me.lblEmailAddress.Text = "Email Address: "
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(892, 146)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(121, 25)
        Me.lblContactNo.TabIndex = 39
        Me.lblContactNo.Text = "Contact No: "
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(925, 90)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(88, 25)
        Me.lblGender.TabIndex = 38
        Me.lblGender.Text = "Gender: "
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(954, 37)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(59, 25)
        Me.lblAge.TabIndex = 37
        Me.lblAge.Text = "Age: "
        '
        'lblIentityNoR
        '
        Me.lblIentityNoR.AutoSize = True
        Me.lblIentityNoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIentityNoR.Location = New System.Drawing.Point(207, 203)
        Me.lblIentityNoR.Name = "lblIentityNoR"
        Me.lblIentityNoR.Size = New System.Drawing.Size(43, 25)
        Me.lblIentityNoR.TabIndex = 36
        Me.lblIentityNoR.Text = "text"
        '
        'lblLastNameR
        '
        Me.lblLastNameR.AutoSize = True
        Me.lblLastNameR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameR.Location = New System.Drawing.Point(207, 146)
        Me.lblLastNameR.Name = "lblLastNameR"
        Me.lblLastNameR.Size = New System.Drawing.Size(43, 25)
        Me.lblLastNameR.TabIndex = 35
        Me.lblLastNameR.Text = "text"
        '
        'lblFirstNameR
        '
        Me.lblFirstNameR.AutoSize = True
        Me.lblFirstNameR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameR.Location = New System.Drawing.Point(207, 90)
        Me.lblFirstNameR.Name = "lblFirstNameR"
        Me.lblFirstNameR.Size = New System.Drawing.Size(43, 25)
        Me.lblFirstNameR.TabIndex = 34
        Me.lblFirstNameR.Text = "text"
        '
        'lblPatientIdR
        '
        Me.lblPatientIdR.AutoSize = True
        Me.lblPatientIdR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientIdR.Location = New System.Drawing.Point(207, 37)
        Me.lblPatientIdR.Name = "lblPatientIdR"
        Me.lblPatientIdR.Size = New System.Drawing.Size(43, 25)
        Me.lblPatientIdR.TabIndex = 33
        Me.lblPatientIdR.Text = "text"
        '
        'lblPatientId
        '
        Me.lblPatientId.AutoSize = True
        Me.lblPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientId.Location = New System.Drawing.Point(91, 37)
        Me.lblPatientId.Name = "lblPatientId"
        Me.lblPatientId.Size = New System.Drawing.Size(107, 25)
        Me.lblPatientId.TabIndex = 29
        Me.lblPatientId.Text = "Patient ID: "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(81, 146)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(117, 25)
        Me.lblLastName.TabIndex = 30
        Me.lblLastName.Text = "Last Name: "
        '
        'lblIdentityNo
        '
        Me.lblIdentityNo.AutoSize = True
        Me.lblIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentityNo.Location = New System.Drawing.Point(35, 203)
        Me.lblIdentityNo.Name = "lblIdentityNo"
        Me.lblIdentityNo.Size = New System.Drawing.Size(163, 25)
        Me.lblIdentityNo.TabIndex = 31
        Me.lblIdentityNo.Text = "Identity Card No: "
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(81, 90)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(117, 25)
        Me.lblFirstName.TabIndex = 32
        Me.lblFirstName.Text = "First Name: "
        '
        'lblMedicineToCollect
        '
        Me.lblMedicineToCollect.AutoSize = True
        Me.lblMedicineToCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicineToCollect.Location = New System.Drawing.Point(43, 512)
        Me.lblMedicineToCollect.Name = "lblMedicineToCollect"
        Me.lblMedicineToCollect.Size = New System.Drawing.Size(229, 29)
        Me.lblMedicineToCollect.TabIndex = 47
        Me.lblMedicineToCollect.Text = "Medicine To Collect"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(48, 545)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(1952, 427)
        Me.dgv.TabIndex = 48
        '
        'chkCollectionDone
        '
        Me.chkCollectionDone.AutoSize = True
        Me.chkCollectionDone.BackColor = System.Drawing.SystemColors.Control
        Me.chkCollectionDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCollectionDone.Location = New System.Drawing.Point(48, 986)
        Me.chkCollectionDone.Name = "chkCollectionDone"
        Me.chkCollectionDone.Size = New System.Drawing.Size(150, 24)
        Me.chkCollectionDone.TabIndex = 49
        Me.chkCollectionDone.Text = "Collection Done"
        Me.chkCollectionDone.UseVisualStyleBackColor = False
        '
        'frmCollectionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2050, 1060)
        Me.Controls.Add(Me.chkCollectionDone)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblMedicineToCollect)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblPatientInformation)
        Me.Controls.Add(Me.btnProceedCheckout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lblMedicineCollectionList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCollectionDetails"
        Me.Text = "frmCollectionDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProceedCheckout As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblClinic As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblMedicineCollectionList As Label
    Friend WithEvents lblPatientInformation As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblIentityNoR As Label
    Friend WithEvents lblLastNameR As Label
    Friend WithEvents lblFirstNameR As Label
    Friend WithEvents lblPatientIdR As Label
    Friend WithEvents lblPatientId As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblIdentityNo As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblEmailAddressR As Label
    Friend WithEvents lblContactNoR As Label
    Friend WithEvents lblGenderR As Label
    Friend WithEvents lblAgeR As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblMedicineToCollect As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents chkCollectionDone As CheckBox
End Class
