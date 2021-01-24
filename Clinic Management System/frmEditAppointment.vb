Public Class frmEditAppointment

    Public SelectedDate As String
    Public SelectedTime As TimeSpan
    Public SlotOccupied As String

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
        chkEnableEdit.Enabled = False
    End Sub

    Private Sub frmEditAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConsultationDate.Text = SelectedDate
        lblConsultationTime.Text = SelectedTime.ToString

        If SlotOccupied = "Yes" Then
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
        Else
            chkEnableEdit.Visible = False
        End If
        ''txtOrganizationName.Text = SelectedDate
        ''txtOrganizationCode.Text = SelectedTime
        ''txtOrganizationNature.Text = SlotOccupied

    End Sub
End Class