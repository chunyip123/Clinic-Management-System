Imports System.Data.SqlClient
Public Class frmAddAppointment
    Public SelectedPatient As String
    Public NextAppointmentId As Integer
    Public ExistingSameAppId As Integer

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ResetForm()
        NextAppointmentId = 1

        cboTime.SelectedIndex = -1
        dtpDate.Value = DateTime.Now

        Dim db As New CMSDatabaseDataContext()
        Dim rs = From o In db.Appointments
                 Where o.AppointId Is "A" + NextAppointmentId.ToString()

        ExistingSameAppId = rs.Count()

        While ExistingSameAppId <> 0
            NextAppointmentId += 1
            ExistingSameAppId = rs.Count()
        End While

        lblAppointmentID.Text = "A" + NextAppointmentId.ToString
        dtpDate.Focus()
    End Sub

    Private Sub frmAddAppointment_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
        Dim db As New CMSDatabaseDataContext()
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = SelectedPatient)

        If p Is Nothing Then
            MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        lblPatientID.Text = p.PatientId
        lblFirstName.Text = p.FirstName
        lblLastName.Text = p.LastName
        lblContactNo.Text = p.ContactNo
        lblIcNo.Text = p.IcNo
        lblEmailAddress.Text = p.EmailAdd
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From o In db.Appointments

        Dim a As New Appointment()
        a.AppointId = lblAppointmentID.Text
        a.PatientId = lblPatientID.Text
        a.FirstName = lblFirstName.Text
        a.LastName = lblLastName.Text
        a.IcNo = lblIcNo.Text
        a.ContactNo = lblContactNo.Text
        a.EmailAdd = lblEmailAddress.Text
        a.Date = dtpDate.Value
        ''Dim Time As String = cboTime.SelectedItem
        a.Time = cboTime.Text

        db.Appointments.InsertOnSubmit(a)
        db.SubmitChanges()
        MessageBox.Show("Appointment Successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ResetForm()
        Me.Close()
    End Sub
End Class