Imports System.ComponentModel

Public Class frmPanelList

    Public ClickedId As String

    Private Sub frmPanelList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgv.Columns(0).HeaderCell.Value = "Panel ID"
        dgv.Columns(1).HeaderCell.Value = "Organization Name"
        dgv.Columns(2).HeaderCell.Value = "Organization Code"
        dgv.Columns(3).HeaderCell.Value = "Daily Insured Limit (RM)"
        dgv.Columns(4).HeaderCell.Value = "Contact No."
        dgv.Columns(5).HeaderCell.Value = "Organization's Nature"
    End Sub

    Private Sub BindData()
        Dim db As New CMSDatabaseDataContext()

        Dim rs = From c In db.PanelOrganisations

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            frmUpdatePanel.SelectedId = id
            frmUpdatePanel.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnAddOrganization_Click(sender As Object, e As EventArgs) Handles btnAddOrganization.Click
        Dim db As New CMSDatabaseDataContext()

        Dim rs = From c In db.PanelOrganisations

        dgv.DataSource = rs

        frmAddPanel.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub txtSearchOrganization_TextChanged(sender As Object, e As EventArgs) Handles txtSearchOrganization.TextChanged
        If cboSearchOrganization.SelectedIndex = 0 Then
            BindDataById()
        ElseIf cboSearchOrganization.SelectedIndex = 1 Then
            BindDataByOrgName()
        ElseIf cboSearchOrganization.SelectedIndex = 2 Then
            BindDataByOrgCode()
        ElseIf cboSearchOrganization.SelectedIndex = 3 Then
            BindDataByOrgContact()
        Else
            BindData()
        End If
    End Sub

    Private Sub BindDataById()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.PanelId.Contains(txtSearchOrganization.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByOrgName()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.OrgName.Contains(txtSearchOrganization.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByOrgCode()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.OrgCode.Contains(txtSearchOrganization.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByOrgContact()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.ContactNo.Contains(txtSearchOrganization.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub ResetField()
        txtSearchOrganization.Clear()
    End Sub

    Private Sub cboSearchOrganization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchOrganization.SelectedIndexChanged
        BindData()
        ResetField()
    End Sub



    Private Sub cboSortSequence_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortSequence.SelectedIndexChanged
        If cboSortSequence.SelectedIndex = 0 Then
            If cboSortPanel.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Ascending)
            ElseIf cboSortPanel.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Ascending)
            ElseIf cboSortPanel.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(3), ListSortDirection.Ascending)
            End If
        ElseIf cboSortSequence.SelectedIndex = 1 Then
            If cboSortPanel.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Descending)
            ElseIf cboSortPanel.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Descending)
            ElseIf cboSortPanel.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(3), ListSortDirection.Descending)
            End If
        End If
    End Sub

    Private Sub cboSortPanel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortPanel.SelectedIndexChanged
        If cboSortPanel.SelectedIndex <> -1 Then
            cboSortSequence.Enabled = True
            cboSortSequence.SelectedIndex = -1
            BindData()
        Else
            cboSortSequence.Enabled = False
        End If
    End Sub

    Private Sub btnDeleteOrganization_Click(sender As Object, e As EventArgs) Handles btnDeleteOrganization.Click
        Dim db As New CMSDatabaseDataContext()
        Dim c As PanelOrganisation = db.PanelOrganisations.FirstOrDefault(Function(o) o.PanelId = ClickedId)

        If c Is Nothing Then
            MessageBox.Show("Organization not found, please select an organization to be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            db.PanelOrganisations.DeleteOnSubmit(c)
            db.SubmitChanges()
            MessageBox.Show("Organization " + c.OrgName + " had been deleted successfully.")
        End If

        BindData()

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            ClickedId = id
        End If
    End Sub
End Class