Imports System.ComponentModel

Public Class frmPatientList

    Public SpecifiedGender As String
    Public ClickedId As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSearchPatient.Click

    End Sub

    Private Sub frmPatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgv.Columns(0).HeaderCell.Value = "Patient ID"
        dgv.Columns(1).HeaderCell.Value = "First Name"
        dgv.Columns(2).HeaderCell.Value = "Last Name"
        dgv.Columns(3).HeaderCell.Value = "Identity Card No."
        dgv.Columns(6).HeaderCell.Value = "Contact No."
        dgv.Columns(7).HeaderCell.Value = "Email Address"
        dgv.Columns(11).HeaderCell.Value = "Postal Code"

        ''dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        ''dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub BindData()
        Dim db As New CMSDatabaseDataContext()
        ''dgv.DataSource = db.Patients

        Dim rs = From p In db.Patients

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmRecLogin.Show()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            frmUpdatePatient.SelectedId = id
            frmUpdatePatient.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim db As New CMSDatabaseDataContext()

        Dim rs = From p In db.Patients

        dgv.DataSource = rs
        ''lblResultsNo.Text = rs.Count()

        ''frmAddPatient.NextPatientId = rs.Count() + 1
        frmAddPatient.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub txtSearchPatient_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPatient.TextChanged
        If cboSearchPatient.SelectedIndex = 0 Then
            BindDataById()
        ElseIf cboSearchPatient.SelectedIndex = 1 Then
            BindDataByFirstName()
        ElseIf cboSearchPatient.SelectedIndex = 2 Then
            BindDataByLastName()
        ElseIf cboSearchPatient.SelectedIndex = 3 Then
            BindDataByIc()
        Else
            BindData()
        End If
    End Sub

    Private Sub BindDataById()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.PatientId.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByFirstName()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.FirstName.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByLastName()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.LastName.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByIc()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.IcNo.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByGender()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.Gender Is SpecifiedGender

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub ResetField()
        txtSearchPatient.Clear()
        cboGender.SelectedIndex = -1
    End Sub

    Private Sub cboSearchPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchPatient.SelectedIndexChanged

        BindData()
        ResetField()

        If cboSearchPatient.SelectedIndex = 4 Then
            txtSearchPatient.Enabled = False
            txtSearchPatient.Visible = False
            cboGender.Enabled = True
            cboGender.Visible = True
        Else
            txtSearchPatient.Enabled = True
            txtSearchPatient.Visible = True
            cboGender.Enabled = False
            cboGender.Visible = False
            txtSearchPatient.Focus()
        End If
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        If cboGender.SelectedIndex = 0 Then
            SpecifiedGender = "Male"

            BindDataByGender()
        ElseIf cboGender.SelectedIndex = 1 Then
            SpecifiedGender = "Female"

            BindDataByGender()
        Else
            BindData()
        End If

    End Sub

    Private Sub cboSortPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortPatient.SelectedIndexChanged
        If cboSortPatient.SelectedIndex <> -1 Then
            cboSortSequence.Enabled = True
            cboSortSequence.SelectedIndex = -1
            BindData()
        Else
            cboSortSequence.Enabled = False
        End If
    End Sub

    Private Sub cboSortSequence_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortSequence.SelectedIndexChanged
        If cboSortSequence.SelectedIndex = 0 Then
            If cboSortPatient.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Ascending)
            ElseIf cboSortPatient.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Ascending)
            ElseIf cboSortPatient.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(4), ListSortDirection.Ascending)
            End If
        ElseIf cboSortSequence.SelectedIndex = 1 Then
            If cboSortPatient.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Descending)
            ElseIf cboSortPatient.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Descending)
            ElseIf cboSortPatient.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(4), ListSortDirection.Descending)
            End If
        End If
    End Sub

    Private Sub btnDeletePatient_Click(sender As Object, e As EventArgs) Handles btnDeletePatient.Click
        Dim db As New CMSDatabaseDataContext()
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = ClickedId)

        If p Is Nothing Then
            MessageBox.Show("Patient not found, please select a patient to be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            db.Patients.DeleteOnSubmit(p)
            db.SubmitChanges()
            MessageBox.Show("Patient " + p.FirstName + " " + p.LastName + " had been deleted successfully.")
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