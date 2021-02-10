<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiagPres
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AsdasdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvPatient = New System.Windows.Forms.DataGridView()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddAppointment = New System.Windows.Forms.Button()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.txtBloodPresure = New System.Windows.Forms.TextBox()
        Me.txtCaution = New System.Windows.Forms.RichTextBox()
        Me.txtDiagnosis = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvMedicine = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvPrescription = New System.Windows.Forms.DataGridView()
        Me.btnAddPrescription = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTop.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(1620, 31)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(0, 25)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogout.Location = New System.Drawing.Point(1884, 8)
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
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblUser)
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblUsername)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Controls.Add(Me.lblClinic)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(2050, 83)
        Me.pnlTop.TabIndex = 8
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(1627, 32)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 25)
        Me.lblUser.TabIndex = 25
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(881, 29)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 25)
        Me.lblTime.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdasdToolStripMenuItem, Me.AppointmentToolStripMenuItem, Me.UserToolStripMenuItem, Me.MedicineToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 86)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(12)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AsdasdToolStripMenuItem
        '
        Me.AsdasdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientListToolStripMenuItem})
        Me.AsdasdToolStripMenuItem.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.AsdasdToolStripMenuItem.Name = "AsdasdToolStripMenuItem"
        Me.AsdasdToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.AsdasdToolStripMenuItem.Text = "Patient"
        '
        'PatientListToolStripMenuItem
        '
        Me.PatientListToolStripMenuItem.Name = "PatientListToolStripMenuItem"
        Me.PatientListToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.PatientListToolStripMenuItem.Text = "Patient Maintenance"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentListToolStripMenuItem, Me.AddAppointmentToolStripMenuItem})
        Me.AppointmentToolStripMenuItem.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.AppointmentToolStripMenuItem.Text = "Appointment"
        '
        'AppointmentListToolStripMenuItem
        '
        Me.AppointmentListToolStripMenuItem.Name = "AppointmentListToolStripMenuItem"
        Me.AppointmentListToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.AppointmentListToolStripMenuItem.Text = "Appointment Maintenance"
        '
        'AddAppointmentToolStripMenuItem
        '
        Me.AddAppointmentToolStripMenuItem.Name = "AddAppointmentToolStripMenuItem"
        Me.AddAppointmentToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.AddAppointmentToolStripMenuItem.Text = "Add Appointment"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMaintenanceToolStripMenuItem, Me.AddEmployeeToolStripMenuItem})
        Me.UserToolStripMenuItem.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.UserToolStripMenuItem.Text = "Employee"
        '
        'UserMaintenanceToolStripMenuItem
        '
        Me.UserMaintenanceToolStripMenuItem.Name = "UserMaintenanceToolStripMenuItem"
        Me.UserMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.UserMaintenanceToolStripMenuItem.Text = "Employee Maintenance"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'MedicineToolStripMenuItem
        '
        Me.MedicineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicineListToolStripMenuItem, Me.AddMedicineToolStripMenuItem})
        Me.MedicineToolStripMenuItem.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.MedicineToolStripMenuItem.Name = "MedicineToolStripMenuItem"
        Me.MedicineToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.MedicineToolStripMenuItem.Text = "Medicine"
        '
        'MedicineListToolStripMenuItem
        '
        Me.MedicineListToolStripMenuItem.Name = "MedicineListToolStripMenuItem"
        Me.MedicineListToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.MedicineListToolStripMenuItem.Text = "Medicine Maintenance"
        '
        'AddMedicineToolStripMenuItem
        '
        Me.AddMedicineToolStripMenuItem.Name = "AddMedicineToolStripMenuItem"
        Me.AddMedicineToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.AddMedicineToolStripMenuItem.Text = "Add Medicine"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(43, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Patient Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.dgvPatient)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblPatientID)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(48, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 438)
        Me.Panel1.TabIndex = 10
        '
        'dgvPatient
        '
        Me.dgvPatient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatient.Location = New System.Drawing.Point(13, 49)
        Me.dgvPatient.Name = "dgvPatient"
        Me.dgvPatient.RowHeadersWidth = 51
        Me.dgvPatient.RowTemplate.Height = 24
        Me.dgvPatient.Size = New System.Drawing.Size(915, 375)
        Me.dgvPatient.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblName.Location = New System.Drawing.Point(355, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(227, 25)
        Me.lblName.TabIndex = 20
        '
        'lblPatientID
        '
        Me.lblPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPatientID.Location = New System.Drawing.Point(116, 14)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(141, 25)
        Me.lblPatientID.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(279, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(8, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Patient ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(1025, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Presenting Complaint"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnAddAppointment)
        Me.Panel2.Controls.Add(Me.txtAllergies)
        Me.Panel2.Controls.Add(Me.txtBloodPresure)
        Me.Panel2.Controls.Add(Me.txtCaution)
        Me.Panel2.Controls.Add(Me.txtDiagnosis)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(1030, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(964, 335)
        Me.Panel2.TabIndex = 12
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddAppointment.Location = New System.Drawing.Point(729, 272)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(220, 49)
        Me.btnAddAppointment.TabIndex = 22
        Me.btnAddAppointment.Text = "Add Appointment"
        Me.btnAddAppointment.UseVisualStyleBackColor = True
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAllergies.Location = New System.Drawing.Point(567, 16)
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(382, 30)
        Me.txtAllergies.TabIndex = 26
        '
        'txtBloodPresure
        '
        Me.txtBloodPresure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtBloodPresure.Location = New System.Drawing.Point(164, 16)
        Me.txtBloodPresure.Name = "txtBloodPresure"
        Me.txtBloodPresure.Size = New System.Drawing.Size(225, 30)
        Me.txtBloodPresure.TabIndex = 25
        '
        'txtCaution
        '
        Me.txtCaution.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCaution.Location = New System.Drawing.Point(164, 168)
        Me.txtCaution.Name = "txtCaution"
        Me.txtCaution.Size = New System.Drawing.Size(785, 95)
        Me.txtCaution.TabIndex = 24
        Me.txtCaution.Text = ""
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDiagnosis.Location = New System.Drawing.Point(164, 60)
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.Size = New System.Drawing.Size(785, 89)
        Me.txtDiagnosis.TabIndex = 23
        Me.txtDiagnosis.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(72, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 25)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Caution:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(54, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 25)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Diagnosis:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(468, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 25)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Allergies:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(7, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 25)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Blood Pressure:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(43, 608)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "History of Medicine Taken"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label4.Location = New System.Drawing.Point(1025, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 26)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Prescription"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.dgvMedicine)
        Me.Panel3.Location = New System.Drawing.Point(48, 637)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(940, 341)
        Me.Panel3.TabIndex = 11
        '
        'dgvMedicine
        '
        Me.dgvMedicine.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicine.Location = New System.Drawing.Point(13, 13)
        Me.dgvMedicine.Name = "dgvMedicine"
        Me.dgvMedicine.RowHeadersWidth = 51
        Me.dgvMedicine.RowTemplate.Height = 24
        Me.dgvMedicine.Size = New System.Drawing.Size(915, 314)
        Me.dgvMedicine.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Controls.Add(Me.dgvPrescription)
        Me.Panel4.Controls.Add(Me.btnAddPrescription)
        Me.Panel4.Location = New System.Drawing.Point(1030, 531)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(964, 447)
        Me.Panel4.TabIndex = 16
        '
        'dgvPrescription
        '
        Me.dgvPrescription.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrescription.Location = New System.Drawing.Point(13, 66)
        Me.dgvPrescription.Name = "dgvPrescription"
        Me.dgvPrescription.RowHeadersWidth = 51
        Me.dgvPrescription.RowTemplate.Height = 24
        Me.dgvPrescription.Size = New System.Drawing.Size(936, 365)
        Me.dgvPrescription.TabIndex = 1
        '
        'btnAddPrescription
        '
        Me.btnAddPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnAddPrescription.Location = New System.Drawing.Point(13, 11)
        Me.btnAddPrescription.Name = "btnAddPrescription"
        Me.btnAddPrescription.Size = New System.Drawing.Size(123, 49)
        Me.btnAddPrescription.TabIndex = 0
        Me.btnAddPrescription.Text = "+"
        Me.btnAddPrescription.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(1839, 997)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 49)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(238, 997)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(184, 49)
        Me.btnRefresh.TabIndex = 23
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnAddPatient
        '
        Me.btnAddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddPatient.Location = New System.Drawing.Point(48, 997)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(184, 49)
        Me.btnAddPatient.TabIndex = 24
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmDiagPres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 1060)
        Me.Controls.Add(Me.btnAddPatient)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiagPres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDiagPres"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AsdasdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicineListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMedicineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddAppointment As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvPatient As DataGridView
    Friend WithEvents dgvPrescription As DataGridView
    Friend WithEvents btnAddPrescription As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtCaution As RichTextBox
    Friend WithEvents txtDiagnosis As RichTextBox
    Friend WithEvents txtBloodPresure As TextBox
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblUser As Label
    Friend WithEvents RecordIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodPressureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllergiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiseaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CautionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvMedicine As DataGridView
End Class
