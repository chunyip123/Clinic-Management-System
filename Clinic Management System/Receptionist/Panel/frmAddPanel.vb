Imports System.Text

Public Class frmAddPanel

    Public NextPanelId As Integer
    Public ExistingSameResult As Integer
    Public ExistingSameId As Integer

    Protected Overrides Sub WndProc(ByRef message As Message)
        If message.Msg = &H84 Then ' WM_NCHITTEST
            message.Result = CType(1, IntPtr)
            Return
        End If
        MyBase.WndProc(message)
    End Sub

    Private Sub frmAddPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ResetForm()
        NextPanelId = 1

        txtPanelId.Clear()
        txtOrganizationName.Clear()
        txtOrganizationCode.Clear()
        mskInsuredLimit.Clear()
        mskContactNo.Clear()
        txtOrganizationNature.Clear()

        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.PanelId Is "C" + NextPanelId.ToString()

        ExistingSameId = rs.Count()

        While ExistingSameId <> 0
            NextPanelId += 1
            ExistingSameId = rs.Count()
        End While

        txtPanelId.Text = "C" + NextPanelId.ToString
        txtOrganizationName.Focus()
    End Sub

    Private Sub frmAddPanel_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub

    Private Sub btnAddOrganization_Click(sender As Object, e As EventArgs) Handles btnAddOrganization.Click
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


        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.OrgCode Is txtOrganizationCode.Text

        ExistingSameResult = rs.Count()

        If ExistingSameResult <> 0 Then

            MessageBox.Show("Organization details cound not be added to list as this organization code already exist in the system.", "Unable to Register", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim c As New PanelOrganisation()
            c.PanelId = txtPanelId.Text
            c.OrgName = txtOrganizationName.Text
            c.OrgCode = txtOrganizationCode.Text
            c.CoverLimit = mskInsuredLimit.Text
            c.ContactNo = mskContactNo.Text
            c.OrgNature = txtOrganizationNature.Text

            db.PanelOrganisations.InsertOnSubmit(c)
            db.SubmitChanges()
            MessageBox.Show("Organization details of " & c.OrgName & " had been added to list successfully.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ResetForm()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class