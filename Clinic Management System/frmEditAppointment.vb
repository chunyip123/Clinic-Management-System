Imports System.Text

Public Class frmEditAppointment

    Public SelectedDate As String
    Public SelectedTime As TimeSpan
    Public SlotOccupied As String
    Public NextItemId As Integer
    Public ExistingSameId As Integer
    Public ExistingSamePatientId As Integer

    Protected Overrides Sub WndProc(ByRef message As Message)
        If message.Msg = &H84 Then ' WM_NCHITTEST
            message.Result = CType(1, IntPtr)
            Return
        End If
        MyBase.WndProc(message)
    End Sub

    Private Sub ResetForm()
        txtAppointmentId.Clear()
        radNewPatient.Checked = False
        radExistingPatient.Checked = False
        txtPatientID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        mskIdentityNo.Clear()
        mskContactNo.Clear()
        txtEmailAddress.Clear()
        lblConsultationDate.Text = ""
        lblConsultationTime.Text = ""
        chkEnableEdit.Checked = False
    End Sub

    Private Sub ResetFormForAdd()
        NextItemId = 1

        Dim db As New CMSDatabaseDataContext()
        Dim rs = From a In db.Appointments
                 Where a.AppointId Is "A" + NextItemId.ToString()

        ExistingSameId = rs.Count()

        While ExistingSameId <> 0
            NextItemId += 1
            ExistingSameId = rs.Count()
        End While

        txtAppointmentId.Text = "A" + NextItemId.ToString
        txtFirstName.Focus()

    End Sub

    Private Sub frmEditAppointment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lblConsultationDate.Text = SelectedDate
        lblConsultationTime.Text = SelectedTime.ToString

        If SelectedDate + " " + SelectedTime.ToString < DateTime.Now Then ''Or (SelectedDate = DateTime.Today And SelectedTime.ToString < DateTime.Now.ToString) Then


            If SlotOccupied = "Yes" Then

                Dim db As New CMSDatabaseDataContext()

                Dim a As Appointment = db.Appointments.FirstOrDefault(Function(o) o.Date = SelectedDate And o.Time = SelectedTime)

                If a Is Nothing Then
                    MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Me.Close()
                    Return
                End If

                txtAppointmentId.Text = a.AppointId
                txtPatientID.Text = a.PatientId
                txtFirstName.Text = a.FirstName
                txtLastName.Text = a.LastName
                mskIdentityNo.Text = a.IcNo
                mskContactNo.Text = a.ContactNo
                txtEmailAddress.Text = a.EmailAdd

                If txtPatientID.Text <> "" Then
                    radExistingPatient.Checked = True
                Else
                    radNewPatient.Checked = True
                End If

                chkEnableEdit.Visible = False
                btnUpdateAppointment.Enabled = False
                btnUpdateAppointment.Visible = False
                radNewPatient.Enabled = False
                radExistingPatient.Enabled = False
                txtAppointmentId.Enabled = False
                txtPatientID.Enabled = False
                txtFirstName.Enabled = False
                txtLastName.Enabled = False
                mskIdentityNo.Enabled = False
                mskContactNo.Enabled = False
                txtEmailAddress.Enabled = False
            ElseIf SlotOccupied = "No" Then
                chkEnableEdit.Visible = False
                btnUpdateAppointment.Enabled = False
                btnUpdateAppointment.Visible = False
                radNewPatient.Enabled = False
                radExistingPatient.Enabled = False
                txtAppointmentId.Enabled = False
                txtPatientID.Enabled = False
                txtFirstName.Enabled = False
                txtLastName.Enabled = False
                mskIdentityNo.Enabled = False
                mskContactNo.Enabled = False
                txtEmailAddress.Enabled = False
            End If

            btnDeleteAppointment.Enabled = False
            btnDeleteAppointment.Visible = False

        ElseIf SlotOccupied = "Yes" Then
            chkEnableEdit.Visible = True
            Dim db As New CMSDatabaseDataContext()

            Dim a As Appointment = db.Appointments.FirstOrDefault(Function(o) o.Date = SelectedDate And o.Time = SelectedTime)

            If a Is Nothing Then
                MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Me.Close()
                Return
            End If
            txtAppointmentId.Text = a.AppointId
            txtPatientID.Text = a.PatientId
            txtFirstName.Text = a.FirstName
            txtLastName.Text = a.LastName
            mskIdentityNo.Text = a.IcNo
            mskContactNo.Text = a.ContactNo
            txtEmailAddress.Text = a.EmailAdd

            radNewPatient.Enabled = False
            radExistingPatient.Enabled = False
            txtAppointmentId.Enabled = False
            txtPatientID.Enabled = False
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            mskIdentityNo.Enabled = False
            mskContactNo.Enabled = False
            txtEmailAddress.Enabled = False
            btnUpdateAppointment.Text = "Update Appointment"

            chkEnableEdit.Visible = True
            btnUpdateAppointment.Enabled = True
            btnUpdateAppointment.Visible = True
            btnDeleteAppointment.Enabled = True
            btnDeleteAppointment.Visible = True

        Else
            ResetFormForAdd()
            chkEnableEdit.Visible = False
            btnUpdateAppointment.Text = "Add Appointment"
            radNewPatient.Checked = True
            btnUpdateAppointment.Enabled = True
            btnUpdateAppointment.Visible = True
            btnDeleteAppointment.Enabled = False
            btnDeleteAppointment.Visible = False
        End If
        ''txtOrganizationName.Text = SelectedDate
        ''txtOrganizationCode.Text = SelectedTime
        ''txtOrganizationNature.Text = SlotOccupied

    End Sub

    Private Sub radNewOrExistingPatient_CheckedChanged(sender As Object, e As EventArgs) Handles radNewPatient.CheckedChanged, radExistingPatient.CheckedChanged
        If radNewPatient.Checked = True Then
            txtPatientID.Clear()
            txtPatientID.Enabled = False
            txtFirstName.Enabled = True
            txtLastName.Enabled = True
            mskContactNo.Enabled = True
            txtEmailAddress.Enabled = True
        Else
            txtPatientID.Enabled = True
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            mskContactNo.Enabled = False
            txtEmailAddress.Enabled = False
        End If
    End Sub

    Private Sub btnUpdateAppointment_Click(sender As Object, e As EventArgs) Handles btnUpdateAppointment.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim patientid As String = txtPatientID.Text
        Dim firstname As String = txtFirstName.Text
        Dim lastname As String = txtLastName.Text
        Dim identityno As String = mskIdentityNo.Text
        Dim contactno As String = mskContactNo.Text
        Dim emailaddress As String = txtEmailAddress.Text

        If patientid = "" And radExistingPatient.Checked = True Then
            err.AppendLine("-Please fill in patient's ID.")
            ctr = If(ctr, txtPatientID)
        End If

        If firstname = "" Then
            err.AppendLine("-Please fill in patient's first name.")
            ctr = If(ctr, txtFirstName)
        End If

        If lastname = "" Then
            err.AppendLine("-Please fill in patient's last name.")
            ctr = If(ctr, txtLastName)
        End If

        If identityno = "      -  -" Then
            err.AppendLine("-Please fill in patient's identity card number.")
            ctr = If(ctr, mskIdentityNo)
        End If

        If contactno = "   -" Then
            err.AppendLine("-Please fill in patient's contact number.")
            ctr = If(ctr, mskContactNo)
        End If

        If emailaddress = "" Then
            err.AppendLine("-Please fill in patient's email address.")
            ctr = If(ctr, txtEmailAddress)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        If SlotOccupied = "Yes" Then

            Dim db As New CMSDatabaseDataContext()
            Dim a As Appointment = db.Appointments.FirstOrDefault(Function(o) o.AppointId = txtAppointmentId.Text)

            a.PatientId = txtPatientID.Text
            a.FirstName = txtFirstName.Text
            a.LastName = txtLastName.Text
            a.IcNo = mskIdentityNo.Text
            a.ContactNo = mskContactNo.Text
            a.EmailAdd = txtEmailAddress.Text

            db.SubmitChanges()

            MessageBox.Show("Details of appointment for date " + SelectedDate.ToString + " on " + SelectedTime.ToString + " had been updated successfully.")

            Me.Close()
            ResetForm()
        Else
            Dim a As New Appointment()
            a.AppointId = txtAppointmentId.Text
            a.PatientId = txtPatientID.Text
            a.FirstName = txtFirstName.Text
            a.LastName = txtLastName.Text
            a.IcNo = mskIdentityNo.Text
            a.ContactNo = mskContactNo.Text
            a.EmailAdd = txtEmailAddress.Text
            a.Date = lblConsultationDate.Text
            a.Time = TimeSpan.Parse(lblConsultationTime.Text)

            Dim db As New CMSDatabaseDataContext()
            db.Appointments.InsertOnSubmit(a)
            db.SubmitChanges()
            MessageBox.Show("Details of appointment for date " + SelectedDate.ToString + " on " + SelectedTime.ToString + " had been added successfully.")
            Me.Close()
        End If
    End Sub

    Private Sub chkEnableEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableEdit.CheckedChanged
        If chkEnableEdit.Checked = True Then
            If radNewPatient.Checked = True Then
                txtPatientID.Enabled = False
                txtFirstName.Enabled = True
                txtLastName.Enabled = True
                mskContactNo.Enabled = True
                txtEmailAddress.Enabled = True
            Else
                txtPatientID.Enabled = True
                txtFirstName.Enabled = False
                txtLastName.Enabled = False
                mskContactNo.Enabled = False
                txtEmailAddress.Enabled = False
            End If
            radNewPatient.Enabled = True
            radExistingPatient.Enabled = True
            mskIdentityNo.Enabled = True
        Else
            txtPatientID.Enabled = False
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            mskIdentityNo.Enabled = False
            mskContactNo.Enabled = False
            txtEmailAddress.Enabled = False
            radNewPatient.Enabled = False
            radExistingPatient.Enabled = False
        End If
    End Sub

    Private Sub frmEditAppointment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SlotOccupied = "No"
        ResetForm()

        radNewPatient.Enabled = True
        radExistingPatient.Enabled = True
        txtPatientID.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        mskIdentityNo.Enabled = True
        mskContactNo.Enabled = True
        txtEmailAddress.Enabled = True
    End Sub

    Private Sub txtPatientID_LostFocus(sender As Object, e As EventArgs) Handles txtPatientID.LostFocus
        If radExistingPatient.Checked = True Then
            Dim db As New CMSDatabaseDataContext()
            Dim rs = From p In db.Patients
                     Where p.PatientId Is txtPatientID.Text

            ExistingSamePatientId = rs.Count()

            If ExistingSamePatientId <> 0 Then
                Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = txtPatientID.Text)
                txtFirstName.Text = p.FirstName
                txtLastName.Text = p.LastName
                mskIdentityNo.Text = p.IcNo
                mskContactNo.Text = p.ContactNo
                txtEmailAddress.Text = p.EmailAdd
            Else
                MessageBox.Show("The patient details could not be retrieved as the patient ID specified cannot be found in the system. If is unregistered patient please select new patient.", "Patient ID not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub mskIdentityNo_LostFocus(sender As Object, e As EventArgs) Handles mskIdentityNo.LostFocus
        If radExistingPatient.Checked = True Then
            Dim db As New CMSDatabaseDataContext()
            Dim rs = From p In db.Patients
                     Where p.IcNo Is mskIdentityNo.Text

            ExistingSamePatientId = rs.Count()

            If ExistingSamePatientId <> 0 Then
                Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.IcNo = mskIdentityNo.Text)
                txtPatientID.Text = p.PatientId
                txtFirstName.Text = p.FirstName
                txtLastName.Text = p.LastName
                mskContactNo.Text = p.ContactNo
                txtEmailAddress.Text = p.EmailAdd
            Else
                MessageBox.Show("The patient details could not be retrieved as the identity card number specified cannot be found in the system. If is unregistered patient please select new patient.", "Patient ID not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub frmEditAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDeleteAppointment_Click(sender As Object, e As EventArgs) Handles btnDeleteAppointment.Click
        Dim db As New CMSDatabaseDataContext()
        Dim a As Appointment = db.Appointments.FirstOrDefault(Function(o) o.Date = SelectedDate And o.Time = SelectedTime)
        db.Appointments.DeleteOnSubmit(a)
        db.SubmitChanges()
        MessageBox.Show("Details of appointment for date " + SelectedDate.ToString + " on " + SelectedTime.ToString + " had been deleted successfully.")
        Me.Close()
    End Sub
End Class