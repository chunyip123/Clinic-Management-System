Public Class frmAddPatient

    Public NextPatientId As String

    Private Sub frmAddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ResetForm()
        txtPatientId.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        mskIdentityNo.Clear()
        txtAge.Clear()
        radMale.Checked = False
        radFemale.Checked = False
        txtContactNo.Clear()
        txtEmailAddress.Clear()
        txtAddress.Clear()
        cboState.SelectedIndex = -1
        cboCity.SelectedIndex = -1
        txtPostalCode.Clear()

        txtPatientId.Text = NextPatientId
        txtFirstName.Focus()
    End Sub

    Private Sub frmAddPatient_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim p As New Patient()
        p.PatientId = txtPatientId.Text
        p.FirstName = txtFirstName.Text
        p.LastName = txtLastName.Text
        p.IcNo = mskIdentityNo.Text
        p.Age = txtAge.Text
        If radMale.Checked = True Then
            p.Gender = "Male"
        ElseIf radFemale.Checked = True Then
            p.Gender = "Female"
        End If
        p.ContactNo = txtContactNo.Text
        p.EmailAdd = txtEmailAddress.Text
        p.Address = txtAddress.Text
        p.City = cboCity.Text
        p.State = cboState.Text
        p.PostCode = txtPostalCode.Text

        Dim db As New CMSDatabaseDataContext()
        db.Patients.InsertOnSubmit(p)
        db.SubmitChanges()
        MessageBox.Show("Patient details of " & p.FirstName & p.LastName & " had been added to list successfully.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)

        NextPatientId += 1

        ResetForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class