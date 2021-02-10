Imports System.ComponentModel
Public Class frmEmployeeMain
    Public ClickedId As String

    Private Sub frmEmployeeMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        frmDiagPres.Show()
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

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim db As New CMSDatabaseDataContext()

        Dim rs = From c In db.PanelOrganisations

        dgv.DataSource = rs

        frmAddPanel.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        If cboSearchEmployee.SelectedIndex = 0 Then
            BindDataById()
        ElseIf cboSearchEmployee.SelectedIndex = 1 Then
            BindDataByEmpName()
        ElseIf cboSearchEmployee.SelectedIndex = 2 Then
            BindDataByEmpCode()
        ElseIf cboSearchEmployee.SelectedIndex = 3 Then
            BindDataByEmpContact()
        Else
            BindData()
        End If
    End Sub

    Private Sub BindDataById()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.PanelId.Contains(txtSearchEmployee.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByEmpName()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.OrgName.Contains(txtSearchEmployee.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByEmpCode()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.OrgCode.Contains(txtSearchEmployee.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByEmpContact()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From c In db.PanelOrganisations
                 Where c.ContactNo.Contains(txtSearchEmployee.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub ResetField()
        txtSearchEmployee.Clear()
    End Sub

    Private Sub cboSearchEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchEmployee.SelectedIndexChanged
        BindData()
        ResetField()
    End Sub

    Private Sub cboSortSequence_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortSequence.SelectedIndexChanged
        If cboSortSequence.SelectedIndex = 0 Then
            If cboSortEmployee.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Ascending)
            ElseIf cboSortEmployee.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Ascending)
            ElseIf cboSortEmployee.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(3), ListSortDirection.Ascending)
            End If
        ElseIf cboSortSequence.SelectedIndex = 1 Then
            If cboSortEmployee.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Descending)
            ElseIf cboSortEmployee.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Descending)
            ElseIf cboSortEmployee.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(3), ListSortDirection.Descending)
            End If
        End If
    End Sub

    Private Sub cboSortEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortEmployee.SelectedIndexChanged
        If cboSortEmployee.SelectedIndex <> -1 Then
            cboSortSequence.Enabled = True
            cboSortSequence.SelectedIndex = -1
            BindData()
        Else
            cboSortSequence.Enabled = False
        End If
    End Sub

    Private Sub btnDeleteOrganization_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
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