Imports System.Data.SqlClient
Public Class frmAddPrescription
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ResetForm()
        cboMedicine.SelectedIndex = -1
        txtAmount.Clear()
        rbBeforeMeal.Checked = True
        txtRemarks.Clear()
    End Sub

    Private Sub frmAddPrescription_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CMSDatabase.mdf;Integrated Security=True")
        Dim adapter As New SqlDataAdapter("select ItemId, ItemName from Inventory where Quantity > 0", conn)
        Dim table As New DataTable()

        adapter.Fill(table)

        cboMedicine.DataSource = table
        cboMedicine.ValueMember = "ItemId"
        cboMedicine.DisplayMember = "ItemName"

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Taken As String
        If rbBeforeMeal.Checked = True Then
            Taken = "Before Meal"
        ElseIf rbAfterMeal.Checked = True Then
            Taken = "After Meal"
        ElseIf rbBetweenMeal.Checked = True Then
            Taken = "Between Meal"
        End If
        frmDiagPres.PrescriptionTable.Rows.Add(cboMedicine.Text, txtAmount.Text, Taken, txtRemarks.Text)
        frmDiagPres.dgvPrescription.DataSource = frmDiagPres.PrescriptionTable
        ResetForm()
    End Sub
End Class