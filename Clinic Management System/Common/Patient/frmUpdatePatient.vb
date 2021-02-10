Imports System.Text
Imports System.Data.SqlClient
Imports Clinic_Management_System.frmLogin

Public Class frmUpdatePatient

    Public SelectedId As String

    Protected Overrides Sub WndProc(ByRef message As Message)
        If message.Msg = &H84 Then ' WM_NCHITTEST
            message.Result = CType(1, IntPtr)
            Return
        End If
        MyBase.WndProc(message)
    End Sub

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
        mskAge.Text = p.Age
        Select Case p.Gender
            Case "Male" : radMale.Checked = True
            Case "Female" : radFemale.Checked = True
        End Select
        mskContactNo.Text = p.ContactNo
        txtEmailAddress.Text = p.EmailAdd
        txtAddress.Text = p.Address
        cboState.SelectedItem = p.State
        cboCity.SelectedItem = p.City
        mskPostalCode.Text = p.PostCode

    End Sub

    Private Sub btnUpdateDetail_Click(sender As Object, e As EventArgs) Handles btnUpdateDetail.Click
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

        db.SubmitChanges()

        MessageBox.Show("Details of item " + SelectedId + " had been updated successfully.")

        Dim c As UpdateCheck = db.UpdateChecks.FirstOrDefault(Function(o) o.TableName = "Patient")
        c.GotUpdate = "Yes"
        db.SubmitChanges()

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
            mskAge.Enabled = True
            radMale.Enabled = True
            radFemale.Enabled = True
            mskContactNo.Enabled = True
            txtEmailAddress.Enabled = True
            txtAddress.Enabled = True
            cboCity.Enabled = True
            cboState.Enabled = True
            mskPostalCode.Enabled = True
            btnUpdateDetail.Enabled = True
        Else
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            mskIdentityNo.Enabled = False
            mskAge.Enabled = False
            radMale.Enabled = False
            radFemale.Enabled = False
            mskContactNo.Enabled = False
            txtEmailAddress.Enabled = False
            txtAddress.Enabled = False
            cboCity.Enabled = False
            cboState.Enabled = False
            mskPostalCode.Enabled = False
            btnUpdateDetail.Enabled = False
        End If
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim db As New CMSDatabaseDataContext()
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CMSDatabase.mdf;Integrated Security=True"
        ''Dim sqlDel As String = "delete from RecToDoc"
        ''Using Conn As New SqlConnection(str)
        ''Using cmd As New SqlCommand(sqlDel, Conn)
        ''Conn.Open()
        ''cmd.ExecuteNonQuery()
        ''End Using
        ''End Using
        ''Dim sql As String = "insert into RecToDoc values('" + p.PatientId + "','" + p.IcNo + "')"
        ''Using Conn As New SqlConnection(str)
        ''Using cmd As New SqlCommand(sql, Conn)
        ''Conn.Open()
        ''cmd.ExecuteNonQuery()
        ''MessageBox.Show("Add Patient Successfully!")
        ''End Using
        ''End Using
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = SelectedId)

        If p Is Nothing Then
            MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

        Dim sqlChkVisit As String = "Select * from Patient where Status = 'Consulting'"
        Using ConnChkVisit As New SqlConnection(str)
            Using cmdChkVisit As New SqlCommand(sqlChkVisit, ConnChkVisit)
                ConnChkVisit.Open()
                Dim rd = cmdChkVisit.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    Dim PatientID As String = rd("PatientId").ToString
                    If p.PatientId = SelectedId And p.Status = "Consulting" Then
                        MessageBox.Show("Patient already in the queue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim sql As String = "update Patient set Status=@Status, Queue=@Queue where PatientId = '" + txtPatientId.Text + "'"
                        Using Conn As New SqlConnection(str)
                            Using cmd As New SqlCommand(sql, Conn)
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Consulting"
                                cmd.Parameters.Add("@Queue", SqlDbType.Int).Value = frmPatientList.QueueNo + 1
                                Conn.Open()
                                cmd.ExecuteNonQuery()
                                GlobalVariables.currentPatient = txtPatientId.Text
                                MessageBox.Show("Add Patient Successfully!")
                                ''PatientQueue.Enqueue(p.PatientId)
                                Dim sqlCheck As String = "select * from Employee where UserName=@username"
                                Using ConnCheck As New SqlConnection(str)
                                    Using cmdCheck As New SqlCommand(sqlCheck, ConnCheck)
                                        ConnCheck.Open()
                                        cmdCheck.Parameters.AddWithValue("@username", GlobalVariables.loginuser)
                                        Dim dr = cmdCheck.ExecuteReader
                                        dr.Read()
                                        If dr.HasRows = True Then
                                            Dim employeeType As String = dr("EmployeeType").ToString
                                            If employeeType = "Doctor" Then
                                                frmDiagPres.Show()
                                                frmDiagPres.Load_Page()
                                                Me.Close()
                                            End If
                                        End If
                                    End Using
                                End Using
                            End Using
                        End Using
                    End If
                Else
                    Dim sql As String = "update Patient set Status=@Status, Queue=@Queue where PatientId = '" + txtPatientId.Text + "'"
                    Using Conn As New SqlConnection(str)
                        Using cmd As New SqlCommand(sql, Conn)
                            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Consulting"
                            cmd.Parameters.Add("@Queue", SqlDbType.Int).Value = frmPatientList.QueueNo + 1
                            Conn.Open()
                            cmd.ExecuteNonQuery()
                            GlobalVariables.currentPatient = txtPatientId.Text
                            MessageBox.Show("Add Patient Successfully!")
                            ''PatientQueue.Enqueue(p.PatientId)
                            Dim sqlCheck As String = "select * from Employee where UserName=@username"
                            Using ConnCheck As New SqlConnection(str)
                                Using cmdCheck As New SqlCommand(sqlCheck, ConnCheck)
                                    ConnCheck.Open()
                                    cmdCheck.Parameters.AddWithValue("@username", GlobalVariables.loginuser)
                                    Dim dr = cmdCheck.ExecuteReader
                                    dr.Read()
                                    If dr.HasRows = True Then
                                        Dim employeeType As String = dr("EmployeeType").ToString
                                        If employeeType = "Doctor" Then
                                            frmDiagPres.Show()
                                            frmDiagPres.Load_Page()
                                            Me.Close()
                                        End If
                                    End If
                                End Using
                            End Using
                        End Using
                    End Using
                End If
            End Using
        End Using
    End Sub
End Class