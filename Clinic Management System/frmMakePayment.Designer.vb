<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakePayment
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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPaymentDetails = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMakePayment = New System.Windows.Forms.Button()
        Me.lblInvoiceDetails = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblInvoiceTimeR = New System.Windows.Forms.Label()
        Me.lblInvoiceDateR = New System.Windows.Forms.Label()
        Me.lblInvoiceIdR = New System.Windows.Forms.Label()
        Me.lblInvoiceId = New System.Windows.Forms.Label()
        Me.lblInvoiceTime = New System.Windows.Forms.Label()
        Me.lblInvoiceDate = New System.Windows.Forms.Label()
        Me.lblIentityNoR = New System.Windows.Forms.Label()
        Me.lblLastNameR = New System.Windows.Forms.Label()
        Me.lblFirstNameR = New System.Windows.Forms.Label()
        Me.lblPatientIdR = New System.Windows.Forms.Label()
        Me.lblPatientId = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblIdentityNo = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblOrderSummary = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.radCreditCardPayment = New System.Windows.Forms.RadioButton()
        Me.radCashPayment = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblGrandTotalR = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.txtOrganizationCode = New System.Windows.Forms.TextBox()
        Me.lblOrganizationCode = New System.Windows.Forms.Label()
        Me.chkPanelOrg = New System.Windows.Forms.CheckBox()
        Me.lblDiscountR = New System.Windows.Forms.Label()
        Me.lblServiceFeeR = New System.Windows.Forms.Label()
        Me.lblSubtotalR = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblServiceFee = New System.Windows.Forms.Label()
        Me.lblPaymentDetail = New System.Windows.Forms.Label()
        Me.btnApplyPanel = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(-1, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(2050, 83)
        Me.pnlTop.TabIndex = 51
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblPaymentDetails
        '
        Me.lblPaymentDetails.AutoSize = True
        Me.lblPaymentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDetails.Location = New System.Drawing.Point(36, 23)
        Me.lblPaymentDetails.Name = "lblPaymentDetails"
        Me.lblPaymentDetails.Size = New System.Drawing.Size(153, 38)
        Me.lblPaymentDetails.TabIndex = 50
        Me.lblPaymentDetails.Text = "Payment"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1839, 1404)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 62)
        Me.btnBack.TabIndex = 52
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnMakePayment
        '
        Me.btnMakePayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMakePayment.Enabled = False
        Me.btnMakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakePayment.ForeColor = System.Drawing.Color.White
        Me.btnMakePayment.Location = New System.Drawing.Point(1654, 1404)
        Me.btnMakePayment.Name = "btnMakePayment"
        Me.btnMakePayment.Size = New System.Drawing.Size(156, 62)
        Me.btnMakePayment.TabIndex = 53
        Me.btnMakePayment.Text = "Make Payment"
        Me.btnMakePayment.UseVisualStyleBackColor = False
        '
        'lblInvoiceDetails
        '
        Me.lblInvoiceDetails.AutoSize = True
        Me.lblInvoiceDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceDetails.Location = New System.Drawing.Point(42, 87)
        Me.lblInvoiceDetails.Name = "lblInvoiceDetails"
        Me.lblInvoiceDetails.Size = New System.Drawing.Size(169, 29)
        Me.lblInvoiceDetails.TabIndex = 54
        Me.lblInvoiceDetails.Text = "Invoice Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblInvoiceTimeR)
        Me.Panel2.Controls.Add(Me.lblInvoiceDateR)
        Me.Panel2.Controls.Add(Me.lblInvoiceIdR)
        Me.Panel2.Controls.Add(Me.lblInvoiceId)
        Me.Panel2.Controls.Add(Me.lblInvoiceTime)
        Me.Panel2.Controls.Add(Me.lblInvoiceDate)
        Me.Panel2.Controls.Add(Me.lblIentityNoR)
        Me.Panel2.Controls.Add(Me.lblLastNameR)
        Me.Panel2.Controls.Add(Me.lblFirstNameR)
        Me.Panel2.Controls.Add(Me.lblPatientIdR)
        Me.Panel2.Controls.Add(Me.lblPatientId)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Controls.Add(Me.lblIdentityNo)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Location = New System.Drawing.Point(47, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1952, 267)
        Me.Panel2.TabIndex = 55
        '
        'lblInvoiceTimeR
        '
        Me.lblInvoiceTimeR.AutoSize = True
        Me.lblInvoiceTimeR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceTimeR.Location = New System.Drawing.Point(208, 146)
        Me.lblInvoiceTimeR.Name = "lblInvoiceTimeR"
        Me.lblInvoiceTimeR.Size = New System.Drawing.Size(43, 25)
        Me.lblInvoiceTimeR.TabIndex = 51
        Me.lblInvoiceTimeR.Text = "text"
        '
        'lblInvoiceDateR
        '
        Me.lblInvoiceDateR.AutoSize = True
        Me.lblInvoiceDateR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceDateR.Location = New System.Drawing.Point(208, 90)
        Me.lblInvoiceDateR.Name = "lblInvoiceDateR"
        Me.lblInvoiceDateR.Size = New System.Drawing.Size(43, 25)
        Me.lblInvoiceDateR.TabIndex = 50
        Me.lblInvoiceDateR.Text = "text"
        '
        'lblInvoiceIdR
        '
        Me.lblInvoiceIdR.AutoSize = True
        Me.lblInvoiceIdR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceIdR.Location = New System.Drawing.Point(208, 37)
        Me.lblInvoiceIdR.Name = "lblInvoiceIdR"
        Me.lblInvoiceIdR.Size = New System.Drawing.Size(43, 25)
        Me.lblInvoiceIdR.TabIndex = 49
        Me.lblInvoiceIdR.Text = "text"
        '
        'lblInvoiceId
        '
        Me.lblInvoiceId.AutoSize = True
        Me.lblInvoiceId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceId.Location = New System.Drawing.Point(86, 37)
        Me.lblInvoiceId.Name = "lblInvoiceId"
        Me.lblInvoiceId.Size = New System.Drawing.Size(104, 25)
        Me.lblInvoiceId.TabIndex = 45
        Me.lblInvoiceId.Text = "Invoice ID:"
        '
        'lblInvoiceTime
        '
        Me.lblInvoiceTime.AutoSize = True
        Me.lblInvoiceTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceTime.Location = New System.Drawing.Point(61, 146)
        Me.lblInvoiceTime.Name = "lblInvoiceTime"
        Me.lblInvoiceTime.Size = New System.Drawing.Size(129, 25)
        Me.lblInvoiceTime.TabIndex = 46
        Me.lblInvoiceTime.Text = "Invoice Time:"
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.AutoSize = True
        Me.lblInvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceDate.Location = New System.Drawing.Point(64, 90)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(126, 25)
        Me.lblInvoiceDate.TabIndex = 48
        Me.lblInvoiceDate.Text = "Invoice Date:"
        '
        'lblIentityNoR
        '
        Me.lblIentityNoR.AutoSize = True
        Me.lblIentityNoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIentityNoR.Location = New System.Drawing.Point(1014, 203)
        Me.lblIentityNoR.Name = "lblIentityNoR"
        Me.lblIentityNoR.Size = New System.Drawing.Size(43, 25)
        Me.lblIentityNoR.TabIndex = 36
        Me.lblIentityNoR.Text = "text"
        '
        'lblLastNameR
        '
        Me.lblLastNameR.AutoSize = True
        Me.lblLastNameR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameR.Location = New System.Drawing.Point(1014, 146)
        Me.lblLastNameR.Name = "lblLastNameR"
        Me.lblLastNameR.Size = New System.Drawing.Size(43, 25)
        Me.lblLastNameR.TabIndex = 35
        Me.lblLastNameR.Text = "text"
        '
        'lblFirstNameR
        '
        Me.lblFirstNameR.AutoSize = True
        Me.lblFirstNameR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameR.Location = New System.Drawing.Point(1014, 90)
        Me.lblFirstNameR.Name = "lblFirstNameR"
        Me.lblFirstNameR.Size = New System.Drawing.Size(43, 25)
        Me.lblFirstNameR.TabIndex = 34
        Me.lblFirstNameR.Text = "text"
        '
        'lblPatientIdR
        '
        Me.lblPatientIdR.AutoSize = True
        Me.lblPatientIdR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientIdR.Location = New System.Drawing.Point(1014, 37)
        Me.lblPatientIdR.Name = "lblPatientIdR"
        Me.lblPatientIdR.Size = New System.Drawing.Size(43, 25)
        Me.lblPatientIdR.TabIndex = 33
        Me.lblPatientIdR.Text = "text"
        '
        'lblPatientId
        '
        Me.lblPatientId.AutoSize = True
        Me.lblPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientId.Location = New System.Drawing.Point(898, 37)
        Me.lblPatientId.Name = "lblPatientId"
        Me.lblPatientId.Size = New System.Drawing.Size(107, 25)
        Me.lblPatientId.TabIndex = 29
        Me.lblPatientId.Text = "Patient ID: "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(888, 146)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(117, 25)
        Me.lblLastName.TabIndex = 30
        Me.lblLastName.Text = "Last Name: "
        '
        'lblIdentityNo
        '
        Me.lblIdentityNo.AutoSize = True
        Me.lblIdentityNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentityNo.Location = New System.Drawing.Point(842, 203)
        Me.lblIdentityNo.Name = "lblIdentityNo"
        Me.lblIdentityNo.Size = New System.Drawing.Size(163, 25)
        Me.lblIdentityNo.TabIndex = 31
        Me.lblIdentityNo.Text = "Identity Card No: "
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(888, 90)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(117, 25)
        Me.lblFirstName.TabIndex = 32
        Me.lblFirstName.Text = "First Name: "
        '
        'lblOrderSummary
        '
        Me.lblOrderSummary.AutoSize = True
        Me.lblOrderSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderSummary.Location = New System.Drawing.Point(42, 430)
        Me.lblOrderSummary.Name = "lblOrderSummary"
        Me.lblOrderSummary.Size = New System.Drawing.Size(183, 29)
        Me.lblOrderSummary.TabIndex = 56
        Me.lblOrderSummary.Text = "Order Summary"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(47, 463)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(1952, 300)
        Me.dgv.TabIndex = 57
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblPaymentDetail)
        Me.Panel1.Controls.Add(Me.dgv)
        Me.Panel1.Controls.Add(Me.lblOrderSummary)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblInvoiceDetails)
        Me.Panel1.Controls.Add(Me.btnMakePayment)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.lblPaymentDetails)
        Me.Panel1.Location = New System.Drawing.Point(-1, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2050, 972)
        Me.Panel1.TabIndex = 52
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.radCreditCardPayment)
        Me.Panel4.Controls.Add(Me.radCashPayment)
        Me.Panel4.Location = New System.Drawing.Point(43, 1200)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1952, 170)
        Me.Panel4.TabIndex = 61
        '
        'radCreditCardPayment
        '
        Me.radCreditCardPayment.AutoSize = True
        Me.radCreditCardPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCreditCardPayment.Location = New System.Drawing.Point(75, 96)
        Me.radCreditCardPayment.Name = "radCreditCardPayment"
        Me.radCreditCardPayment.Size = New System.Drawing.Size(133, 29)
        Me.radCreditCardPayment.TabIndex = 1
        Me.radCreditCardPayment.TabStop = True
        Me.radCreditCardPayment.Text = "Credit Card"
        Me.radCreditCardPayment.UseVisualStyleBackColor = True
        '
        'radCashPayment
        '
        Me.radCashPayment.AutoSize = True
        Me.radCashPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCashPayment.Location = New System.Drawing.Point(75, 42)
        Me.radCashPayment.Name = "radCashPayment"
        Me.radCashPayment.Size = New System.Drawing.Size(80, 29)
        Me.radCashPayment.TabIndex = 0
        Me.radCashPayment.TabStop = True
        Me.radCashPayment.Text = "Cash"
        Me.radCashPayment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 1168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 29)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Payment Method"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnApplyPanel)
        Me.Panel3.Controls.Add(Me.lblGrandTotalR)
        Me.Panel3.Controls.Add(Me.lblGrandTotal)
        Me.Panel3.Controls.Add(Me.txtOrganizationCode)
        Me.Panel3.Controls.Add(Me.lblOrganizationCode)
        Me.Panel3.Controls.Add(Me.chkPanelOrg)
        Me.Panel3.Controls.Add(Me.lblDiscountR)
        Me.Panel3.Controls.Add(Me.lblServiceFeeR)
        Me.Panel3.Controls.Add(Me.lblSubtotalR)
        Me.Panel3.Controls.Add(Me.lblSubtotal)
        Me.Panel3.Controls.Add(Me.lblDiscount)
        Me.Panel3.Controls.Add(Me.lblServiceFee)
        Me.Panel3.Location = New System.Drawing.Point(47, 845)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1952, 267)
        Me.Panel3.TabIndex = 59
        '
        'lblGrandTotalR
        '
        Me.lblGrandTotalR.AutoSize = True
        Me.lblGrandTotalR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotalR.Location = New System.Drawing.Point(279, 205)
        Me.lblGrandTotalR.Name = "lblGrandTotalR"
        Me.lblGrandTotalR.Size = New System.Drawing.Size(43, 25)
        Me.lblGrandTotalR.TabIndex = 56
        Me.lblGrandTotalR.Text = "text"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(130, 205)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(121, 25)
        Me.lblGrandTotal.TabIndex = 55
        Me.lblGrandTotal.Text = "Grand Total:"
        '
        'txtOrganizationCode
        '
        Me.txtOrganizationCode.Enabled = False
        Me.txtOrganizationCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganizationCode.Location = New System.Drawing.Point(1108, 87)
        Me.txtOrganizationCode.Name = "txtOrganizationCode"
        Me.txtOrganizationCode.Size = New System.Drawing.Size(278, 30)
        Me.txtOrganizationCode.TabIndex = 54
        '
        'lblOrganizationCode
        '
        Me.lblOrganizationCode.AutoSize = True
        Me.lblOrganizationCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganizationCode.Location = New System.Drawing.Point(888, 90)
        Me.lblOrganizationCode.Name = "lblOrganizationCode"
        Me.lblOrganizationCode.Size = New System.Drawing.Size(182, 25)
        Me.lblOrganizationCode.TabIndex = 53
        Me.lblOrganizationCode.Text = "Organization Code:"
        '
        'chkPanelOrg
        '
        Me.chkPanelOrg.AutoSize = True
        Me.chkPanelOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPanelOrg.Location = New System.Drawing.Point(893, 37)
        Me.chkPanelOrg.Name = "chkPanelOrg"
        Me.chkPanelOrg.Size = New System.Drawing.Size(200, 29)
        Me.chkPanelOrg.TabIndex = 52
        Me.chkPanelOrg.Text = "Panel Organization"
        Me.chkPanelOrg.UseVisualStyleBackColor = True
        '
        'lblDiscountR
        '
        Me.lblDiscountR.AutoSize = True
        Me.lblDiscountR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountR.Location = New System.Drawing.Point(279, 148)
        Me.lblDiscountR.Name = "lblDiscountR"
        Me.lblDiscountR.Size = New System.Drawing.Size(43, 25)
        Me.lblDiscountR.TabIndex = 51
        Me.lblDiscountR.Text = "text"
        '
        'lblServiceFeeR
        '
        Me.lblServiceFeeR.AutoSize = True
        Me.lblServiceFeeR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceFeeR.Location = New System.Drawing.Point(279, 93)
        Me.lblServiceFeeR.Name = "lblServiceFeeR"
        Me.lblServiceFeeR.Size = New System.Drawing.Size(43, 25)
        Me.lblServiceFeeR.TabIndex = 50
        Me.lblServiceFeeR.Text = "text"
        '
        'lblSubtotalR
        '
        Me.lblSubtotalR.AutoSize = True
        Me.lblSubtotalR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalR.Location = New System.Drawing.Point(279, 38)
        Me.lblSubtotalR.Name = "lblSubtotalR"
        Me.lblSubtotalR.Size = New System.Drawing.Size(43, 25)
        Me.lblSubtotalR.TabIndex = 49
        Me.lblSubtotalR.Text = "text"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(161, 37)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(90, 25)
        Me.lblSubtotal.TabIndex = 45
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(19, 148)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(234, 25)
        Me.lblDiscount.TabIndex = 46
        Me.lblDiscount.Text = "Organisation's Coverage:"
        '
        'lblServiceFee
        '
        Me.lblServiceFee.AutoSize = True
        Me.lblServiceFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceFee.Location = New System.Drawing.Point(80, 93)
        Me.lblServiceFee.Name = "lblServiceFee"
        Me.lblServiceFee.Size = New System.Drawing.Size(171, 25)
        Me.lblServiceFee.TabIndex = 48
        Me.lblServiceFee.Text = "Service Fee (6%):"
        '
        'lblPaymentDetail
        '
        Me.lblPaymentDetail.AutoSize = True
        Me.lblPaymentDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDetail.Location = New System.Drawing.Point(42, 813)
        Me.lblPaymentDetail.Name = "lblPaymentDetail"
        Me.lblPaymentDetail.Size = New System.Drawing.Size(186, 29)
        Me.lblPaymentDetail.TabIndex = 58
        Me.lblPaymentDetail.Text = "Payment Details"
        '
        'btnApplyPanel
        '
        Me.btnApplyPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnApplyPanel.Enabled = False
        Me.btnApplyPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyPanel.ForeColor = System.Drawing.Color.White
        Me.btnApplyPanel.Location = New System.Drawing.Point(1392, 86)
        Me.btnApplyPanel.Name = "btnApplyPanel"
        Me.btnApplyPanel.Size = New System.Drawing.Size(91, 32)
        Me.btnApplyPanel.TabIndex = 62
        Me.btnApplyPanel.Text = "Apply"
        Me.btnApplyPanel.UseVisualStyleBackColor = False
        '
        'frmMakePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2050, 1060)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMakePayment"
        Me.Text = "frmMakePayment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblClinic As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPaymentDetails As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnMakePayment As Button
    Friend WithEvents lblInvoiceDetails As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblIentityNoR As Label
    Friend WithEvents lblLastNameR As Label
    Friend WithEvents lblFirstNameR As Label
    Friend WithEvents lblPatientIdR As Label
    Friend WithEvents lblPatientId As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblIdentityNo As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblOrderSummary As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInvoiceTimeR As Label
    Friend WithEvents lblInvoiceDateR As Label
    Friend WithEvents lblInvoiceIdR As Label
    Friend WithEvents lblInvoiceId As Label
    Friend WithEvents lblInvoiceTime As Label
    Friend WithEvents lblInvoiceDate As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGrandTotalR As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents txtOrganizationCode As TextBox
    Friend WithEvents lblOrganizationCode As Label
    Friend WithEvents chkPanelOrg As CheckBox
    Friend WithEvents lblDiscountR As Label
    Friend WithEvents lblServiceFeeR As Label
    Friend WithEvents lblSubtotalR As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblServiceFee As Label
    Friend WithEvents lblPaymentDetail As Label
    Friend WithEvents radCreditCardPayment As RadioButton
    Friend WithEvents radCashPayment As RadioButton
    Friend WithEvents btnApplyPanel As Button
End Class
