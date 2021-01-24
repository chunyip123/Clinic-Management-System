<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointmentList
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
        Me.btnCreateAppointment = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblClinic = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblInventoryList = New System.Windows.Forms.Label()
        Me.lblAppointmentDate = New System.Windows.Forms.Label()
        Me.mcAppointmentDate = New System.Windows.Forms.MonthCalendar()
        Me.lblAppointmentTime = New System.Windows.Forms.Label()
        Me.btn900AM = New System.Windows.Forms.Button()
        Me.btn915AM = New System.Windows.Forms.Button()
        Me.btn930AM = New System.Windows.Forms.Button()
        Me.btn945AM = New System.Windows.Forms.Button()
        Me.btn1045AM = New System.Windows.Forms.Button()
        Me.btn1030AM = New System.Windows.Forms.Button()
        Me.btn1015AM = New System.Windows.Forms.Button()
        Me.btn1000AM = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn445PM = New System.Windows.Forms.Button()
        Me.btn430PM = New System.Windows.Forms.Button()
        Me.btn415PM = New System.Windows.Forms.Button()
        Me.btn400PM = New System.Windows.Forms.Button()
        Me.btn245PM = New System.Windows.Forms.Button()
        Me.btn230PM = New System.Windows.Forms.Button()
        Me.btn215PM = New System.Windows.Forms.Button()
        Me.btn200PM = New System.Windows.Forms.Button()
        Me.btn345PM = New System.Windows.Forms.Button()
        Me.btn330PM = New System.Windows.Forms.Button()
        Me.btn315PM = New System.Windows.Forms.Button()
        Me.btn300PM = New System.Windows.Forms.Button()
        Me.btn1245PM = New System.Windows.Forms.Button()
        Me.btn1230PM = New System.Windows.Forms.Button()
        Me.btn1215PM = New System.Windows.Forms.Button()
        Me.btn1200PM = New System.Windows.Forms.Button()
        Me.btn1145AM = New System.Windows.Forms.Button()
        Me.btn1130AM = New System.Windows.Forms.Button()
        Me.btn1115AM = New System.Windows.Forms.Button()
        Me.btn1100AM = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateAppointment
        '
        Me.btnCreateAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAppointment.ForeColor = System.Drawing.Color.White
        Me.btnCreateAppointment.Location = New System.Drawing.Point(1698, 987)
        Me.btnCreateAppointment.Name = "btnCreateAppointment"
        Me.btnCreateAppointment.Size = New System.Drawing.Size(156, 62)
        Me.btnCreateAppointment.TabIndex = 46
        Me.btnCreateAppointment.Text = "Create Appointment"
        Me.btnCreateAppointment.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1883, 987)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 62)
        Me.btnBack.TabIndex = 43
        Me.btnBack.Text = "Back to Dashboard"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
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
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(2050, 83)
        Me.pnlTop.TabIndex = 36
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
        'lblInventoryList
        '
        Me.lblInventoryList.AutoSize = True
        Me.lblInventoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryList.Location = New System.Drawing.Point(51, 33)
        Me.lblInventoryList.Name = "lblInventoryList"
        Me.lblInventoryList.Size = New System.Drawing.Size(228, 38)
        Me.lblInventoryList.TabIndex = 35
        Me.lblInventoryList.Text = "Appointments"
        '
        'lblAppointmentDate
        '
        Me.lblAppointmentDate.AutoSize = True
        Me.lblAppointmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentDate.Location = New System.Drawing.Point(52, 116)
        Me.lblAppointmentDate.Name = "lblAppointmentDate"
        Me.lblAppointmentDate.Size = New System.Drawing.Size(243, 32)
        Me.lblAppointmentDate.TabIndex = 48
        Me.lblAppointmentDate.Text = "Appointment Date"
        '
        'mcAppointmentDate
        '
        Me.mcAppointmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcAppointmentDate.Location = New System.Drawing.Point(58, 157)
        Me.mcAppointmentDate.MaxSelectionCount = 1
        Me.mcAppointmentDate.Name = "mcAppointmentDate"
        Me.mcAppointmentDate.TabIndex = 49
        '
        'lblAppointmentTime
        '
        Me.lblAppointmentTime.AutoSize = True
        Me.lblAppointmentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentTime.Location = New System.Drawing.Point(52, 445)
        Me.lblAppointmentTime.Name = "lblAppointmentTime"
        Me.lblAppointmentTime.Size = New System.Drawing.Size(246, 32)
        Me.lblAppointmentTime.TabIndex = 50
        Me.lblAppointmentTime.Text = "Appointment Time"
        '
        'btn900AM
        '
        Me.btn900AM.BackColor = System.Drawing.Color.LightGray
        Me.btn900AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn900AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn900AM.Location = New System.Drawing.Point(58, 494)
        Me.btn900AM.Name = "btn900AM"
        Me.btn900AM.Size = New System.Drawing.Size(322, 114)
        Me.btn900AM.TabIndex = 51
        Me.btn900AM.Text = "09:00"
        Me.btn900AM.UseVisualStyleBackColor = False
        '
        'btn915AM
        '
        Me.btn915AM.BackColor = System.Drawing.Color.LightGray
        Me.btn915AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn915AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn915AM.Location = New System.Drawing.Point(532, 494)
        Me.btn915AM.Name = "btn915AM"
        Me.btn915AM.Size = New System.Drawing.Size(322, 114)
        Me.btn915AM.TabIndex = 52
        Me.btn915AM.Text = "09:15"
        Me.btn915AM.UseVisualStyleBackColor = False
        '
        'btn930AM
        '
        Me.btn930AM.BackColor = System.Drawing.Color.LightGray
        Me.btn930AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn930AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn930AM.Location = New System.Drawing.Point(998, 494)
        Me.btn930AM.Name = "btn930AM"
        Me.btn930AM.Size = New System.Drawing.Size(322, 114)
        Me.btn930AM.TabIndex = 53
        Me.btn930AM.Text = "09:30"
        Me.btn930AM.UseVisualStyleBackColor = False
        '
        'btn945AM
        '
        Me.btn945AM.BackColor = System.Drawing.Color.LightGray
        Me.btn945AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn945AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn945AM.Location = New System.Drawing.Point(1482, 494)
        Me.btn945AM.Name = "btn945AM"
        Me.btn945AM.Size = New System.Drawing.Size(322, 114)
        Me.btn945AM.TabIndex = 54
        Me.btn945AM.Text = "09:45"
        Me.btn945AM.UseVisualStyleBackColor = False
        '
        'btn1045AM
        '
        Me.btn1045AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1045AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1045AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1045AM.Location = New System.Drawing.Point(1482, 686)
        Me.btn1045AM.Name = "btn1045AM"
        Me.btn1045AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1045AM.TabIndex = 58
        Me.btn1045AM.Text = "10:45 AM"
        Me.btn1045AM.UseVisualStyleBackColor = False
        '
        'btn1030AM
        '
        Me.btn1030AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1030AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1030AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1030AM.Location = New System.Drawing.Point(998, 686)
        Me.btn1030AM.Name = "btn1030AM"
        Me.btn1030AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1030AM.TabIndex = 57
        Me.btn1030AM.Text = "10:30 AM"
        Me.btn1030AM.UseVisualStyleBackColor = False
        '
        'btn1015AM
        '
        Me.btn1015AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1015AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1015AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1015AM.Location = New System.Drawing.Point(532, 686)
        Me.btn1015AM.Name = "btn1015AM"
        Me.btn1015AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1015AM.TabIndex = 56
        Me.btn1015AM.Text = "10:15"
        Me.btn1015AM.UseVisualStyleBackColor = False
        '
        'btn1000AM
        '
        Me.btn1000AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1000AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1000AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000AM.Location = New System.Drawing.Point(58, 686)
        Me.btn1000AM.Name = "btn1000AM"
        Me.btn1000AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1000AM.TabIndex = 55
        Me.btn1000AM.Text = "10:00"
        Me.btn1000AM.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.btn445PM)
        Me.Panel1.Controls.Add(Me.btn430PM)
        Me.Panel1.Controls.Add(Me.btn415PM)
        Me.Panel1.Controls.Add(Me.btn400PM)
        Me.Panel1.Controls.Add(Me.btn245PM)
        Me.Panel1.Controls.Add(Me.btn230PM)
        Me.Panel1.Controls.Add(Me.btn215PM)
        Me.Panel1.Controls.Add(Me.btn200PM)
        Me.Panel1.Controls.Add(Me.btn345PM)
        Me.Panel1.Controls.Add(Me.btn330PM)
        Me.Panel1.Controls.Add(Me.btn315PM)
        Me.Panel1.Controls.Add(Me.btn300PM)
        Me.Panel1.Controls.Add(Me.btn1245PM)
        Me.Panel1.Controls.Add(Me.btn1230PM)
        Me.Panel1.Controls.Add(Me.btn1215PM)
        Me.Panel1.Controls.Add(Me.btn1200PM)
        Me.Panel1.Controls.Add(Me.btn1145AM)
        Me.Panel1.Controls.Add(Me.btn1130AM)
        Me.Panel1.Controls.Add(Me.btn1115AM)
        Me.Panel1.Controls.Add(Me.btn1100AM)
        Me.Panel1.Controls.Add(Me.btn1045AM)
        Me.Panel1.Controls.Add(Me.btn1030AM)
        Me.Panel1.Controls.Add(Me.btn1015AM)
        Me.Panel1.Controls.Add(Me.lblInventoryList)
        Me.Panel1.Controls.Add(Me.btn1000AM)
        Me.Panel1.Controls.Add(Me.lblAppointmentDate)
        Me.Panel1.Controls.Add(Me.btn945AM)
        Me.Panel1.Controls.Add(Me.mcAppointmentDate)
        Me.Panel1.Controls.Add(Me.btn930AM)
        Me.Panel1.Controls.Add(Me.lblAppointmentTime)
        Me.Panel1.Controls.Add(Me.btn915AM)
        Me.Panel1.Controls.Add(Me.btn900AM)
        Me.Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2050, 876)
        Me.Panel1.TabIndex = 59
        '
        'btn445PM
        '
        Me.btn445PM.BackColor = System.Drawing.Color.LightGray
        Me.btn445PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn445PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn445PM.Location = New System.Drawing.Point(1482, 1658)
        Me.btn445PM.Name = "btn445PM"
        Me.btn445PM.Size = New System.Drawing.Size(322, 114)
        Me.btn445PM.TabIndex = 78
        Me.btn445PM.Text = "4:45 PM"
        Me.btn445PM.UseVisualStyleBackColor = False
        '
        'btn430PM
        '
        Me.btn430PM.BackColor = System.Drawing.Color.LightGray
        Me.btn430PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn430PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn430PM.Location = New System.Drawing.Point(998, 1658)
        Me.btn430PM.Name = "btn430PM"
        Me.btn430PM.Size = New System.Drawing.Size(322, 114)
        Me.btn430PM.TabIndex = 77
        Me.btn430PM.Text = "4:30 PM"
        Me.btn430PM.UseVisualStyleBackColor = False
        '
        'btn415PM
        '
        Me.btn415PM.BackColor = System.Drawing.Color.LightGray
        Me.btn415PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn415PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn415PM.Location = New System.Drawing.Point(532, 1658)
        Me.btn415PM.Name = "btn415PM"
        Me.btn415PM.Size = New System.Drawing.Size(322, 114)
        Me.btn415PM.TabIndex = 76
        Me.btn415PM.Text = "4:15 PM"
        Me.btn415PM.UseVisualStyleBackColor = False
        '
        'btn400PM
        '
        Me.btn400PM.BackColor = System.Drawing.Color.LightGray
        Me.btn400PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn400PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn400PM.Location = New System.Drawing.Point(58, 1658)
        Me.btn400PM.Name = "btn400PM"
        Me.btn400PM.Size = New System.Drawing.Size(322, 114)
        Me.btn400PM.TabIndex = 75
        Me.btn400PM.Text = "4:00 PM"
        Me.btn400PM.UseVisualStyleBackColor = False
        '
        'btn245PM
        '
        Me.btn245PM.BackColor = System.Drawing.Color.LightGray
        Me.btn245PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn245PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn245PM.Location = New System.Drawing.Point(1482, 1267)
        Me.btn245PM.Name = "btn245PM"
        Me.btn245PM.Size = New System.Drawing.Size(322, 114)
        Me.btn245PM.TabIndex = 74
        Me.btn245PM.Text = "2:45 PM"
        Me.btn245PM.UseVisualStyleBackColor = False
        '
        'btn230PM
        '
        Me.btn230PM.BackColor = System.Drawing.Color.LightGray
        Me.btn230PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn230PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn230PM.Location = New System.Drawing.Point(998, 1267)
        Me.btn230PM.Name = "btn230PM"
        Me.btn230PM.Size = New System.Drawing.Size(322, 114)
        Me.btn230PM.TabIndex = 73
        Me.btn230PM.Text = "2:30 PM"
        Me.btn230PM.UseVisualStyleBackColor = False
        '
        'btn215PM
        '
        Me.btn215PM.BackColor = System.Drawing.Color.LightGray
        Me.btn215PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn215PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn215PM.Location = New System.Drawing.Point(532, 1267)
        Me.btn215PM.Name = "btn215PM"
        Me.btn215PM.Size = New System.Drawing.Size(322, 114)
        Me.btn215PM.TabIndex = 72
        Me.btn215PM.Text = "2:15 PM"
        Me.btn215PM.UseVisualStyleBackColor = False
        '
        'btn200PM
        '
        Me.btn200PM.BackColor = System.Drawing.Color.LightGray
        Me.btn200PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn200PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200PM.Location = New System.Drawing.Point(58, 1267)
        Me.btn200PM.Name = "btn200PM"
        Me.btn200PM.Size = New System.Drawing.Size(322, 114)
        Me.btn200PM.TabIndex = 71
        Me.btn200PM.Text = "2:00 PM"
        Me.btn200PM.UseVisualStyleBackColor = False
        '
        'btn345PM
        '
        Me.btn345PM.BackColor = System.Drawing.Color.LightGray
        Me.btn345PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn345PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn345PM.Location = New System.Drawing.Point(1482, 1462)
        Me.btn345PM.Name = "btn345PM"
        Me.btn345PM.Size = New System.Drawing.Size(322, 114)
        Me.btn345PM.TabIndex = 70
        Me.btn345PM.Text = "3:45 PM"
        Me.btn345PM.UseVisualStyleBackColor = False
        '
        'btn330PM
        '
        Me.btn330PM.BackColor = System.Drawing.Color.LightGray
        Me.btn330PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn330PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn330PM.Location = New System.Drawing.Point(998, 1462)
        Me.btn330PM.Name = "btn330PM"
        Me.btn330PM.Size = New System.Drawing.Size(322, 114)
        Me.btn330PM.TabIndex = 69
        Me.btn330PM.Text = "3:30 PM"
        Me.btn330PM.UseVisualStyleBackColor = False
        '
        'btn315PM
        '
        Me.btn315PM.BackColor = System.Drawing.Color.LightGray
        Me.btn315PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn315PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn315PM.Location = New System.Drawing.Point(532, 1462)
        Me.btn315PM.Name = "btn315PM"
        Me.btn315PM.Size = New System.Drawing.Size(322, 114)
        Me.btn315PM.TabIndex = 68
        Me.btn315PM.Text = "3:15 PM"
        Me.btn315PM.UseVisualStyleBackColor = False
        '
        'btn300PM
        '
        Me.btn300PM.BackColor = System.Drawing.Color.LightGray
        Me.btn300PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn300PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn300PM.Location = New System.Drawing.Point(58, 1462)
        Me.btn300PM.Name = "btn300PM"
        Me.btn300PM.Size = New System.Drawing.Size(322, 114)
        Me.btn300PM.TabIndex = 67
        Me.btn300PM.Text = "3:00 PM"
        Me.btn300PM.UseVisualStyleBackColor = False
        '
        'btn1245PM
        '
        Me.btn1245PM.BackColor = System.Drawing.Color.LightGray
        Me.btn1245PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1245PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1245PM.Location = New System.Drawing.Point(1482, 1077)
        Me.btn1245PM.Name = "btn1245PM"
        Me.btn1245PM.Size = New System.Drawing.Size(322, 114)
        Me.btn1245PM.TabIndex = 66
        Me.btn1245PM.Text = "12:45 PM"
        Me.btn1245PM.UseVisualStyleBackColor = False
        '
        'btn1230PM
        '
        Me.btn1230PM.BackColor = System.Drawing.Color.LightGray
        Me.btn1230PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1230PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1230PM.Location = New System.Drawing.Point(998, 1077)
        Me.btn1230PM.Name = "btn1230PM"
        Me.btn1230PM.Size = New System.Drawing.Size(322, 114)
        Me.btn1230PM.TabIndex = 65
        Me.btn1230PM.Text = "12:30 PM"
        Me.btn1230PM.UseVisualStyleBackColor = False
        '
        'btn1215PM
        '
        Me.btn1215PM.BackColor = System.Drawing.Color.LightGray
        Me.btn1215PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1215PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1215PM.Location = New System.Drawing.Point(532, 1077)
        Me.btn1215PM.Name = "btn1215PM"
        Me.btn1215PM.Size = New System.Drawing.Size(322, 114)
        Me.btn1215PM.TabIndex = 64
        Me.btn1215PM.Text = "12:15 PM"
        Me.btn1215PM.UseVisualStyleBackColor = False
        '
        'btn1200PM
        '
        Me.btn1200PM.BackColor = System.Drawing.Color.LightGray
        Me.btn1200PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1200PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1200PM.Location = New System.Drawing.Point(58, 1077)
        Me.btn1200PM.Name = "btn1200PM"
        Me.btn1200PM.Size = New System.Drawing.Size(322, 114)
        Me.btn1200PM.TabIndex = 63
        Me.btn1200PM.Text = "12:00 PM"
        Me.btn1200PM.UseVisualStyleBackColor = False
        '
        'btn1145AM
        '
        Me.btn1145AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1145AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1145AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1145AM.Location = New System.Drawing.Point(1482, 881)
        Me.btn1145AM.Name = "btn1145AM"
        Me.btn1145AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1145AM.TabIndex = 62
        Me.btn1145AM.Text = "11:45 AM"
        Me.btn1145AM.UseVisualStyleBackColor = False
        '
        'btn1130AM
        '
        Me.btn1130AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1130AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1130AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1130AM.Location = New System.Drawing.Point(998, 881)
        Me.btn1130AM.Name = "btn1130AM"
        Me.btn1130AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1130AM.TabIndex = 61
        Me.btn1130AM.Text = "11:30 AM"
        Me.btn1130AM.UseVisualStyleBackColor = False
        '
        'btn1115AM
        '
        Me.btn1115AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1115AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1115AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1115AM.Location = New System.Drawing.Point(532, 881)
        Me.btn1115AM.Name = "btn1115AM"
        Me.btn1115AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1115AM.TabIndex = 60
        Me.btn1115AM.Text = "11:15 AM"
        Me.btn1115AM.UseVisualStyleBackColor = False
        '
        'btn1100AM
        '
        Me.btn1100AM.BackColor = System.Drawing.Color.LightGray
        Me.btn1100AM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1100AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1100AM.Location = New System.Drawing.Point(58, 881)
        Me.btn1100AM.Name = "btn1100AM"
        Me.btn1100AM.Size = New System.Drawing.Size(322, 114)
        Me.btn1100AM.TabIndex = 59
        Me.btn1100AM.Text = "11:00 AM"
        Me.btn1100AM.UseVisualStyleBackColor = False
        '
        'frmAppointmentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2050, 1060)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCreateAppointment)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAppointmentList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateAppointment As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblClinic As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblInventoryList As Label
    Friend WithEvents lblAppointmentDate As Label
    Friend WithEvents mcAppointmentDate As MonthCalendar
    Friend WithEvents lblAppointmentTime As Label
    Friend WithEvents btn900AM As Button
    Friend WithEvents btn915AM As Button
    Friend WithEvents btn930AM As Button
    Friend WithEvents btn945AM As Button
    Friend WithEvents btn1045AM As Button
    Friend WithEvents btn1030AM As Button
    Friend WithEvents btn1015AM As Button
    Friend WithEvents btn1000AM As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn445PM As Button
    Friend WithEvents btn430PM As Button
    Friend WithEvents btn415PM As Button
    Friend WithEvents btn400PM As Button
    Friend WithEvents btn245PM As Button
    Friend WithEvents btn230PM As Button
    Friend WithEvents btn215PM As Button
    Friend WithEvents btn200PM As Button
    Friend WithEvents btn345PM As Button
    Friend WithEvents btn330PM As Button
    Friend WithEvents btn315PM As Button
    Friend WithEvents btn300PM As Button
    Friend WithEvents btn1245PM As Button
    Friend WithEvents btn1230PM As Button
    Friend WithEvents btn1215PM As Button
    Friend WithEvents btn1200PM As Button
    Friend WithEvents btn1145AM As Button
    Friend WithEvents btn1130AM As Button
    Friend WithEvents btn1115AM As Button
    Friend WithEvents btn1100AM As Button
End Class
