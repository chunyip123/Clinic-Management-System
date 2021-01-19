Imports System.Text

Public Class frmUpdatePanel

    Public SelectedId As String

    Protected Overrides Sub WndProc(ByRef message As Message)
        If message.Msg = &H84 Then ' WM_NCHITTEST
            message.Result = CType(1, IntPtr)
            Return
        End If
        MyBase.WndProc(message)
    End Sub

    Private Sub frmUpdatePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEnableEdit.Checked = False
    End Sub

    Private Sub frmUpdatePanel_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim db As New CMSDatabaseDataContext()
        Dim c As PanelOrganisation = db.PanelOrganisations.FirstOrDefault(Function(o) o.PanelId = SelectedId)

        If c Is Nothing Then
            MessageBox.Show("Organization not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

        txtPanelId.Text = c.PanelId
        txtOrganizationName.Text = c.OrgName
        txtOrganizationCode.Text = c.OrgCode
        mskInsuredLimit.Text = c.CoverLimit
        mskContactNo.Text = c.ContactNo
        txtOrgNature.Text = c.OrgNature
    End Sub

    Private Sub btnUpdateDetail_Click(sender As Object, e As EventArgs) Handles btnUpdateDetail.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim orgname As String = txtOrganizationName.Text
        Dim orgcode As String = txtOrganizationCode.Text
        Dim insuredlimit As String = mskInsuredLimit.Text
        Dim contactno As String = mskContactNo.Text

        If orgname = "" Then
            err.AppendLine("-Please fill in organization's name.")
            ctr = If(ctr, txtOrganizationName)
        End If

        If orgcode = "" Then
            err.AppendLine("-Please fill in organization's code.")
            ctr = If(ctr, txtOrganizationCode)
        End If

        If insuredlimit = "" Then
            err.AppendLine("-Please fill in organization's daily insured limit.")
            ctr = If(ctr, mskInsuredLimit)
        End If

        If contactno = "  -" Then
            err.AppendLine("-Please fill in organization's contact number.")
            ctr = If(ctr, mskContactNo)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New CMSDatabaseDataContext()
        Dim c As PanelOrganisation = db.PanelOrganisations.FirstOrDefault(Function(o) o.PanelId = SelectedId)

        If c Is Nothing Then
            MessageBox.Show("Organization not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

        c.PanelId = txtPanelId.Text
        c.OrgName = txtOrganizationName.Text
        c.OrgCode = txtOrganizationCode.Text
        c.CoverLimit = mskInsuredLimit.Text
        c.ContactNo = mskContactNo.Text
        c.OrgNature = txtOrgNature.Text

        db.SubmitChanges()

        MessageBox.Show("Details of item " + SelectedId + " had been updated successfully.")

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkEnableEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableEdit.CheckedChanged
        If chkEnableEdit.Checked = True Then
            txtOrganizationName.Enabled = True
            txtOrganizationCode.Enabled = True
            mskInsuredLimit.Enabled = True
            mskContactNo.Enabled = True
            txtOrgNature.Enabled = True
            btnUpdateDetail.Enabled = True
        Else
            txtOrganizationName.Enabled = False
            txtOrganizationCode.Enabled = False
            mskInsuredLimit.Enabled = False
            mskContactNo.Enabled = False
            txtOrgNature.Enabled = False
            btnUpdateDetail.Enabled = False
        End If
    End Sub
End Class