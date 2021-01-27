Imports System.Text

Public Class frmAddPatient

    Public NextPatientId As Integer
    Public ExistingSameResult As Integer
    Public ExistingSameId As Integer

    Protected Overrides Sub WndProc(ByRef message As Message)
        If message.Msg = &H84 Then ' WM_NCHITTEST
            message.Result = CType(1, IntPtr)
            Return
        End If
        MyBase.WndProc(message)
    End Sub

    Private Sub frmAddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ResetForm()
        NextPatientId = 1

        txtPatientId.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        mskIdentityNo.Clear()
        mskAge.Clear()
        radMale.Checked = False
        radFemale.Checked = False
        mskContactNo.Clear()
        txtEmailAddress.Clear()
        txtAddress.Clear()
        cboState.SelectedIndex = -1
        cboCity.SelectedIndex = -1
        mskPostalCode.Clear()

        Dim db As New CMSDatabaseDataContext()
        Dim rs = From o In db.Patients
                 Where o.PatientId Is "P" + NextPatientId.ToString()

        ExistingSameId = rs.Count()

        While ExistingSameId <> 0
            NextPatientId += 1
            ExistingSameId = rs.Count()
        End While

        txtPatientId.Text = "P" + NextPatientId.ToString
        txtFirstName.Focus()
    End Sub

    Private Sub frmAddPatient_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim firstname As String = txtFirstName.Text
        Dim lastname As String = txtLastName.Text
        Dim identityno As String = mskIdentityNo.Text
        Dim age As String = mskAge.Text
        Dim contactno As String = mskContactNo.Text
        Dim emailaddress As String = txtEmailAddress.Text
        Dim address As String = txtAddress.Text
        Dim city As String = cboCity.SelectedItem
        Dim state As String = cboState.SelectedItem
        Dim postalcode As String = mskPostalCode.Text

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

        If age = "" Then
            err.AppendLine("-Please fill in patient's age.")
            ctr = If(ctr, mskAge)
        End If

        If radMale.Checked = False And radFemale.Checked = False Then
            err.AppendLine("-Please specify patient's gender")
            ctr = If(ctr, radMale)
        End If

        If contactno = "   -" Then
            err.AppendLine("-Please fill in patient's contact number.")
            ctr = If(ctr, mskContactNo)
        End If

        If emailaddress = "" Then
            err.AppendLine("-Please fill in patient's email address.")
            ctr = If(ctr, txtEmailAddress)
        End If

        If address = "" Then
            err.AppendLine("-Please fill in patient's address.")
            ctr = If(ctr, txtAddress)
        End If

        If city = "" Then
            err.AppendLine("-Please select patient's city.")
            ctr = If(ctr, cboCity)
        End If

        If state = "" Then
            err.AppendLine("-Please select patient's state.")
            ctr = If(ctr, cboState)
        End If

        If postalcode = "" Then
            err.AppendLine("-Please fill in patient's postal code.")
            ctr = If(ctr, mskPostalCode)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim db As New CMSDatabaseDataContext()
        Dim rs = From o In db.Patients
                 Where o.IcNo Is mskIdentityNo.Text

        ExistingSameResult = rs.Count()

            If ExistingSameResult <> 0 Then

                MessageBox.Show("Patient details cound not be added to list as this IC number already exist in the system.", "Unable to Register", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                Dim p As New Patient()
                p.PatientId = txtPatientId.Text
                p.FirstName = txtFirstName.Text
                p.LastName = txtLastName.Text
                p.IcNo = mskIdentityNo.Text
                p.Age = mskAge.Text
                If radMale.Checked = True Then
                    p.Gender = "Male"
                ElseIf radFemale.Checked = True Then
                    p.Gender = "Female"
                End If
                p.ContactNo = mskContactNo.Text
                p.EmailAdd = txtEmailAddress.Text
                p.Address = txtAddress.Text
                p.City = cboCity.Text
                p.State = cboState.Text
            p.PostCode = mskPostalCode.Text
            p.Status = "Not Visiting"

            ''Dim db As New CMSDatabaseDataContext()
            db.Patients.InsertOnSubmit(p)
                db.SubmitChanges()
                MessageBox.Show("Patient details of " & p.FirstName & " " & p.LastName & " had been added to list successfully.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ''NextPatientId += 1

            Dim c As UpdateCheck = db.UpdateChecks.FirstOrDefault(Function(o) o.TableName = "Patient")
            c.GotUpdate = "Yes"
            db.SubmitChanges()

            ResetForm()
            End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class