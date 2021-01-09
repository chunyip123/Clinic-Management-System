Imports System.ComponentModel

Public Class frmPatientList
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSearchPatient.Click

    End Sub

    Private Sub frmPatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub BindData()
        Dim db As New CMSDatabaseDataContext()
        dgv.DataSource = db.Patients
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmRecLogin.Show()
    End Sub
End Class