<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPanel
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
        Me.lblAddPatient = New System.Windows.Forms.Label()
        Me.txtPanelId = New System.Windows.Forms.TextBox()
        Me.lblPanelId = New System.Windows.Forms.Label()
        Me.lblInsuredLimit = New System.Windows.Forms.Label()
        Me.txtOrganizationName = New System.Windows.Forms.TextBox()
        Me.lblOrganizationName = New System.Windows.Forms.Label()
        Me.lblOrganizationCode = New System.Windows.Forms.Label()
        Me.txtOrganizationCode = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mskContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.mskInsuredLimit = New System.Windows.Forms.MaskedTextBox()
        Me.txtOrganizationNature = New System.Windows.Forms.TextBox()
        Me.lblOrganizationNature = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblAddPanelOrg = New System.Windows.Forms.Label()
        Me.btnAddOrganization = New System.Windows.Forms.Button()
        Me.lblPanelDetail = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddPatient
        '
        Me.lblAddPatient.AutoSize = True
        Me.lblAddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddPatient.Location = New System.Drawing.Point(31, 21)
        Me.lblAddPatient.Name = "lblAddPatient"
        Me.lblAddPatient.Size = New System.Drawing.Size(319, 32)
        Me.lblAddPatient.TabIndex = 41
        Me.lblAddPatient.Text = "Add New Organization"
        '
        'txtPanelId
        '
        Me.txtPanelId.Enabled = False
        Me.txtPanelId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanelId.Location = New System.Drawing.Point(108, 42)
        Me.txtPanelId.Name = "txtPanelId"
        Me.txtPanelId.Size = New System.Drawing.Size(303, 27)
        Me.txtPanelId.TabIndex = 1
        '
        'lblPanelId
        '
        Me.lblPanelId.AutoSize = True
        Me.lblPanelId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelId.Location = New System.Drawing.Point(104, 19)
        Me.lblPanelId.Name = "lblPanelId"
        Me.lblPanelId.Size = New System.Drawing.Size(73, 20)
        Me.lblPanelId.TabIndex = 0
        Me.lblPanelId.Text = "Panel ID"
        '
        'lblInsuredLimit
        '
        Me.lblInsuredLimit.AutoSize = True
        Me.lblInsuredLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuredLimit.Location = New System.Drawing.Point(103, 173)
        Me.lblInsuredLimit.Name = "lblInsuredLimit"
        Me.lblInsuredLimit.Size = New System.Drawing.Size(192, 20)
        Me.lblInsuredLimit.TabIndex = 4
        Me.lblInsuredLimit.Text = "Daily Insured Limit (RM)"
        '
        'txtOrganizationName
        '
        Me.txtOrganizationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganizationName.Location = New System.Drawing.Point(107, 50)
        Me.txtOrganizationName.Name = "txtOrganizationName"
        Me.txtOrganizationName.Size = New System.Drawing.Size(304, 27)
        Me.txtOrganizationName.TabIndex = 1
        '
        'lblOrganizationName
        '
        Me.lblOrganizationName.AutoSize = True
        Me.lblOrganizationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganizationName.Location = New System.Drawing.Point(104, 29)
        Me.lblOrganizationName.Name = "lblOrganizationName"
        Me.lblOrganizationName.Size = New System.Drawing.Size(153, 20)
        Me.lblOrganizationName.TabIndex = 0
        Me.lblOrganizationName.Text = "Organization Name"
        '
        'lblOrganizationCode
        '
        Me.lblOrganizationCode.AutoSize = True
        Me.lblOrganizationCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganizationCode.Location = New System.Drawing.Point(104, 101)
        Me.lblOrganizationCode.Name = "lblOrganizationCode"
        Me.lblOrganizationCode.Size = New System.Drawing.Size(148, 20)
        Me.lblOrganizationCode.TabIndex = 2
        Me.lblOrganizationCode.Text = "Organization Code"
        '
        'txtOrganizationCode
        '
        Me.txtOrganizationCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganizationCode.Location = New System.Drawing.Point(107, 124)
        Me.txtOrganizationCode.Name = "txtOrganizationCode"
        Me.txtOrganizationCode.Size = New System.Drawing.Size(304, 27)
        Me.txtOrganizationCode.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(313, 740)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(172, 58)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.mskContactNo)
        Me.Panel2.Controls.Add(Me.mskInsuredLimit)
        Me.Panel2.Controls.Add(Me.txtOrganizationNature)
        Me.Panel2.Controls.Add(Me.lblOrganizationNature)
        Me.Panel2.Controls.Add(Me.lblContactNo)
        Me.Panel2.Controls.Add(Me.txtOrganizationCode)
        Me.Panel2.Controls.Add(Me.lblOrganizationCode)
        Me.Panel2.Controls.Add(Me.lblInsuredLimit)
        Me.Panel2.Controls.Add(Me.txtOrganizationName)
        Me.Panel2.Controls.Add(Me.lblOrganizationName)
        Me.Panel2.Location = New System.Drawing.Point(34, 261)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 455)
        Me.Panel2.TabIndex = 1
        '
        'mskContactNo
        '
        Me.mskContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskContactNo.Location = New System.Drawing.Point(106, 268)
        Me.mskContactNo.Mask = "00-00000000"
        Me.mskContactNo.Name = "mskContactNo"
        Me.mskContactNo.Size = New System.Drawing.Size(304, 27)
        Me.mskContactNo.TabIndex = 7
        Me.mskContactNo.ValidatingType = GetType(Integer)
        '
        'mskInsuredLimit
        '
        Me.mskInsuredLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskInsuredLimit.Location = New System.Drawing.Point(106, 196)
        Me.mskInsuredLimit.Mask = "000000"
        Me.mskInsuredLimit.Name = "mskInsuredLimit"
        Me.mskInsuredLimit.Size = New System.Drawing.Size(304, 27)
        Me.mskInsuredLimit.TabIndex = 5
        Me.mskInsuredLimit.ValidatingType = GetType(Integer)
        '
        'txtOrganizationNature
        '
        Me.txtOrganizationNature.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganizationNature.Location = New System.Drawing.Point(106, 347)
        Me.txtOrganizationNature.Multiline = True
        Me.txtOrganizationNature.Name = "txtOrganizationNature"
        Me.txtOrganizationNature.Size = New System.Drawing.Size(304, 70)
        Me.txtOrganizationNature.TabIndex = 9
        '
        'lblOrganizationNature
        '
        Me.lblOrganizationNature.AutoSize = True
        Me.lblOrganizationNature.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganizationNature.Location = New System.Drawing.Point(102, 324)
        Me.lblOrganizationNature.Name = "lblOrganizationNature"
        Me.lblOrganizationNature.Size = New System.Drawing.Size(178, 20)
        Me.lblOrganizationNature.TabIndex = 8
        Me.lblOrganizationNature.Text = "Nature of Organization"
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(103, 245)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(93, 20)
        Me.lblContactNo.TabIndex = 6
        Me.lblContactNo.Text = "Contact No"
        '
        'lblAddPanelOrg
        '
        Me.lblAddPanelOrg.AutoSize = True
        Me.lblAddPanelOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddPanelOrg.Location = New System.Drawing.Point(32, 79)
        Me.lblAddPanelOrg.Name = "lblAddPanelOrg"
        Me.lblAddPanelOrg.Size = New System.Drawing.Size(375, 25)
        Me.lblAddPanelOrg.TabIndex = 34
        Me.lblAddPanelOrg.Text = "Organization Details Currently Adding"
        '
        'btnAddOrganization
        '
        Me.btnAddOrganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrganization.ForeColor = System.Drawing.Color.White
        Me.btnAddOrganization.Location = New System.Drawing.Point(107, 740)
        Me.btnAddOrganization.Name = "btnAddOrganization"
        Me.btnAddOrganization.Size = New System.Drawing.Size(172, 58)
        Me.btnAddOrganization.TabIndex = 2
        Me.btnAddOrganization.Text = "Add Organization"
        Me.btnAddOrganization.UseVisualStyleBackColor = False
        '
        'lblPanelDetail
        '
        Me.lblPanelDetail.AutoSize = True
        Me.lblPanelDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelDetail.Location = New System.Drawing.Point(32, 233)
        Me.lblPanelDetail.Name = "lblPanelDetail"
        Me.lblPanelDetail.Size = New System.Drawing.Size(264, 25)
        Me.lblPanelDetail.TabIndex = 36
        Me.lblPanelDetail.Text = "Organization's Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPanelId)
        Me.Panel1.Controls.Add(Me.lblPanelId)
        Me.Panel1.Location = New System.Drawing.Point(34, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 99)
        Me.Panel1.TabIndex = 0
        '
        'frmAddPanel
        '
        Me.AcceptButton = Me.btnAddOrganization
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(576, 820)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAddPatient)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblAddPanelOrg)
        Me.Controls.Add(Me.btnAddOrganization)
        Me.Controls.Add(Me.lblPanelDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddPatient As Label
    Friend WithEvents txtPanelId As TextBox
    Friend WithEvents lblPanelId As Label
    Friend WithEvents lblInsuredLimit As Label
    Friend WithEvents txtOrganizationName As TextBox
    Friend WithEvents lblOrganizationName As Label
    Friend WithEvents lblOrganizationCode As Label
    Friend WithEvents txtOrganizationCode As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtOrganizationNature As TextBox
    Friend WithEvents lblOrganizationNature As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblAddPanelOrg As Label
    Friend WithEvents btnAddOrganization As Button
    Friend WithEvents lblPanelDetail As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mskInsuredLimit As MaskedTextBox
    Friend WithEvents mskContactNo As MaskedTextBox
End Class
