Imports System.ComponentModel

Public Class frmPatientList
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSearchPatient.Click

    End Sub

    Private Sub frmPatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
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

        frmAddPatient.NextPatientId = "P" + (rs.Count() + 1).ToString
        frmAddPatient.ShowDialog(Me)
        BindData()
    End Sub
End Class