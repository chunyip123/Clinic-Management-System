<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePanel
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
        Me.txtOrgNature = New System.Windows.Forms.TextBox()
        Me.lblOrgNature = New System.Windows.Forms.Label()
        Me.lblOrganizationDetail = New System.Windows.Forms.Label()
        Me.mskInsuredLimit = New System.Windows.Forms.MaskedTextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtOrganizationCode = New System.Windows.Forms.TextBox()
        Me.chkEnableEdit = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdateDetail = New System.Windows.Forms.Button()
        Me.lblOrganizationCode = New System.Windows.Forms.Label()
        Me.lblInsuredLimit = New System.Windows.Forms.Label()
        Me.txtOrganizationName = New System.Windows.Forms.TextBox()
        Me.lblOrganizationName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mskContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblEditPanel = New System.Windows.Forms.Label()
        Me.txtPanelId = New System.Windows.Forms.TextBox()
        Me.lblPanelId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPanelDetail = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOrgNature
        '
        Me.txtOrgNature.Enabled = False
        Me.txtOrgNature.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrgNature.Location = New System.Drawing.Point(107, 350)
        Me.txtOrgNature.Multiline = True
        Me.txtOrgNature.Name = "txtOrgNature"
        Me.txtOrgNature.Size = New System.Drawing.Size(304, 73)
        Me.txtOrgNature.TabIndex = 9
        '
        'lblOrgNature
        '
        Me.lblOrgNature.AutoSize = True
        Me.lblOrgNature.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrgNature.Location = New System.Drawing.Point(103, 328)
        Me.lblOrgNature.Name = "lblOrgNature"
        Me.lblOrgNature.Size = New System.Drawing.Size(178, 20)
        Me.lblOrgNature.TabIndex = 8
        Me.lblOrgNature.Text = "Nature of Organization"
        '
        'lblOrganizationDetail
        '
        Me.lblOrganizationDetail.AutoSize = True
        Me.lblOrganizationDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganizationDetail.Location = New System.Drawing.Point(-540, 170)
        Me.lblOrganizationDetail.Name = "lblOrganizationDetail"
        Me.lblOrganizationDetail.Size = New System.Drawing.Size(248, 25)
        Me.lblOrganizationDetail.TabIndex = 26
        Me.lblOrganizationDetail.Text = "Organization Information"
        '
        'mskInsuredLimit
        '
        Me.mskInsuredLimit.Enabled = False
        Me.mskInsuredLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskInsuredLimit.Location = New System.Drawing.Point(107, 196)
        Me.mskInsuredLimit.Mask = "000000"
        Me.mskInsuredLimit.Name = "mskInsuredLimit"
        Me.mskInsuredLimit.Size = New System.Drawing.Size(304, 27)
        Me.mskInsuredLimit.TabIndex = 5
        Me.mskInsuredLimit.ValidatingType = GetType(Integer)
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(103, 246)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(93, 20)
        Me.lblContactNo.TabIndex = 6
        Me.lblContactNo.Text = "Contact No"
        '
        'txtOrganizationCode
        '
        Me.txtOrganizationCode.Enabled = False
        Me.txtOrganizationCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganizationCode.Location = New System.Drawing.Point(107, 124)
        Me.txtOrganizationCode.Name = "txtOrganizationCode"
        Me.txtOrganizationCode.Size = New System.Drawing.Size(304, 27)
        Me.txtOrganizationCode.TabIndex = 3
        '
        'chkEnableEdit
        '
        Me.chkEnableEdit.AutoSize = True
        Me.chkEnableEdit.Location = New System.Drawing.Point(43, 683)
        Me.chkEnableEdit.Name = "chkEnableEdit"
        Me.chkEnableEdit.Size = New System.Drawing.Size(101, 21)
        Me.chkEnableEdit.TabIndex = 2
        Me.chkEnableEdit.Text = "Edit Details"
        Me.chkEnableEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(327, 723)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(156, 58)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdateDetail
        '
        Me.btnUpdateDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateDetail.Enabled = False
        Me.btnUpdateDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDetail.ForeColor = System.Drawing.Color.White
        Me.btnUpdateDetail.Location = New System.Drawing.Point(121, 723)
        Me.btnUpdateDetail.Name = "btnUpdateDetail"
        Me.btnUpdateDetail.Size = New System.Drawing.Size(156, 58)
        Me.btnUpdateDetail.TabIndex = 3
        Me.btnUpdateDetail.Text = "Update Details"
        Me.btnUpdateDetail.UseVisualStyleBackColor = False
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
        Me.txtOrganizationName.Enabled = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.mskContactNo)
        Me.Panel2.Controls.Add(Me.mskInsuredLimit)
        Me.Panel2.Controls.Add(Me.lblContactNo)
        Me.Panel2.Controls.Add(Me.txtOrgNature)
        Me.Panel2.Controls.Add(Me.txtOrganizationCode)
        Me.Panel2.Controls.Add(Me.lblOrgNature)
        Me.Panel2.Controls.Add(Me.lblOrganizationCode)
        Me.Panel2.Controls.Add(Me.lblInsuredLimit)
        Me.Panel2.Controls.Add(Me.txtOrganizationName)
        Me.Panel2.Controls.Add(Me.lblOrganizationName)
        Me.Panel2.Location = New System.Drawing.Point(33, 198)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 473)
        Me.Panel2.TabIndex = 1
        '
        'mskContactNo
        '
        Me.mskContactNo.Enabled = False
        Me.mskContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskContactNo.Location = New System.Drawing.Point(107, 269)
        Me.mskContactNo.Mask = "00-00000000"
        Me.mskContactNo.Name = "mskContactNo"
        Me.mskContactNo.Size = New System.Drawing.Size(304, 27)
        Me.mskContactNo.TabIndex = 7
        Me.mskContactNo.ValidatingType = GetType(Integer)
        '
        'lblEditPanel
        '
        Me.lblEditPanel.AutoSize = True
        Me.lblEditPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditPanel.Location = New System.Drawing.Point(31, 16)
        Me.lblEditPanel.Name = "lblEditPanel"
        Me.lblEditPanel.Size = New System.Drawing.Size(383, 25)
        Me.lblEditPanel.TabIndex = 24
        Me.lblEditPanel.Text = "Organization Details Currently Viewing"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPanelId)
        Me.Panel1.Controls.Add(Me.lblPanelId)
        Me.Panel1.Location = New System.Drawing.Point(33, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 99)
        Me.Panel1.TabIndex = 0
        '
        'lblPanelDetail
        '
        Me.lblPanelDetail.AutoSize = True
        Me.lblPanelDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelDetail.Location = New System.Drawing.Point(31, 170)
        Me.lblPanelDetail.Name = "lblPanelDetail"
        Me.lblPanelDetail.Size = New System.Drawing.Size(264, 25)
        Me.lblPanelDetail.TabIndex = 37
        Me.lblPanelDetail.Text = "Organization's Information"
        '
        'frmUpdatePanel
        '
        Me.AcceptButton = Me.btnUpdateDetail
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(579, 794)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPanelDetail)
        Me.Controls.Add(Me.lblOrganizationDetail)
        Me.Controls.Add(Me.chkEnableEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdateDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblEditPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmUpdatePanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOrgNature As TextBox
    Friend WithEvents lblOrgNature As Label
    Friend WithEvents lblOrganizationDetail As Label
    Friend WithEvents mskInsuredLimit As MaskedTextBox
    Friend WithEvents lblContactNo As Label
    Friend WithEvents txtOrganizationCode As TextBox
    Friend WithEvents chkEnableEdit As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdateDetail As Button
    Friend WithEvents lblOrganizationCode As Label
    Friend WithEvents lblInsuredLimit As Label
    Friend WithEvents txtOrganizationName As TextBox
    Friend WithEvents lblOrganizationName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblEditPanel As Label
    Friend WithEvents txtPanelId As TextBox
    Friend WithEvents lblPanelId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mskContactNo As MaskedTextBox
    Friend WithEvents lblPanelDetail As Label
End Class
