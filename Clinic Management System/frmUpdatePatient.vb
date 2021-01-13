Public Class frmUpdatePatient

    Public SelectedId As String

    Private Sub lblIdentityNo_Click(sender As Object, e As EventArgs) Handles lblIdentityNo.Click

    End Sub

    Private Sub txtIdentityNo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmUpdatePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEnableEdit.Checked = False
    End Sub

    Private Sub frmUpdatePatient_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim db As New CMSDatabaseDataContext()
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = SelectedId)

        If p Is Nothing Then
            MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

        txtPatientId.Text = p.PatientId
        txtFirstName.Text = p.FirstName
        txtLastName.Text = p.LastName
        mskIdentityNo.Text = p.IcNo
        txtAge.Text = p.Age
        Select Case p.Gender
            Case "Male" : radMale.Checked = True
            Case "Female" : radFemale.Checked = True
        End Select
        txtContactNo.Text = p.ContactNo
        txtEmailAddress.Text = p.EmailAdd
        txtAddress.Text = p.Address
        cboState.SelectedItem = p.State
        cboCity.SelectedItem = p.City
        txtPostalCode.Text = p.PostCode

    End Sub

    Private Sub btnUpdateDetail_Click(sender As Object, e As EventArgs) Handles btnUpdateDetail.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New CMSDatabaseDataContext()
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = SelectedId)

        If p Is Nothing Then
            MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

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

        db.SubmitChanges()

        MessageBox.Show("Details of item " + SelectedId + " had been updated successfully.")

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkEnableEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableEdit.CheckedChanged
        If chkEnableEdit.Checked = True Then
            txtFirstName.Enabled = True
            txtLastName.Enabled = True
            mskIdentityNo.Enabled = True
            txtAge.Enabled = True
            radMale.Enabled = True
            radFemale.Enabled = True
            txtContactNo.Enabled = True
            txtEmailAddress.Enabled = True
            txtAddress.Enabled = True
            cboCity.Enabled = True
            cboState.Enabled = True
            txtPostalCode.Enabled = True
            btnUpdateDetail.Enabled = True
        Else
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            mskIdentityNo.Enabled = False
            txtAge.Enabled = False
            radMale.Enabled = False
            radFemale.Enabled = False
            txtContactNo.Enabled = False
            txtEmailAddress.Enabled = False
            txtAddress.Enabled = False
            cboCity.Enabled = False
            cboState.Enabled = False
            txtPostalCode.Enabled = False
            btnUpdateDetail.Enabled = False
        End If
    End Sub
End Class