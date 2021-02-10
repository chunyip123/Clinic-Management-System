Imports System.ComponentModel
Imports Clinic_Management_System.frmLogin
Imports System.Data.SqlClient

Public Class frmPatientList

    Public SpecifiedGender As String
    Public ClickedId As String
    Public ExistingSameResult As Integer
    ''Public PatientQueue As Queue = New Queue()
    Public QueueNo As Integer

    Private Sub Check_Database()
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CMSDatabase.mdf;Integrated Security=True"
        Dim sql As String = "select * from Employee where UserName=@username"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@username", GlobalVariables.loginuser)
                ''Dim value = cmd.ExecuteScalar()
                Dim dr = cmd.ExecuteReader
                dr.Read()
                ''If value > 0 Then
                If dr.HasRows = True Then
                    ''GlobalVariables.loginuser = txtUsername.Text
                    Dim employeeType As String = dr("EmployeeType").ToString
                    If employeeType = "Receptionist" Then
                        ''Me.Hide()
                        Me.Close()
                        frmMenu.Show()
                        ''MessageBox.Show("Login sucessfully!")
                        btnBack.Text = "Back to Dashboard"
                    ElseIf employeeType = "Doctor" Then
                        ''Me.Hide()
                        Me.Close()
                        frmDiagPres.Show()
                        ''MessageBox.Show("Login sucessfully!")
                        btnBack.Text = "Back"
                    End If
                End If
            End Using

        End Using
    End Sub

    Private Sub ChangeBtnName()
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CMSDatabase.mdf;Integrated Security=True"
        Dim sql As String = "select * from Employee where UserName=@username"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@username", GlobalVariables.loginuser)
                ''Dim value = cmd.ExecuteScalar()
                Dim dr = cmd.ExecuteReader
                dr.Read()
                ''If value > 0 Then
                If dr.HasRows = True Then
                    ''GlobalVariables.loginuser = txtUsername.Text
                    Dim employeeType As String = dr("EmployeeType").ToString
                    If employeeType = "Receptionist" Then
                        ''Me.Hide()
                        ''MessageBox.Show("Login sucessfully!")
                        btnBack.Text = "Back to Dashboard"
                    ElseIf employeeType = "Doctor" Then
                        ''Me.Hide()
                        ''MessageBox.Show("Login sucessfully!")
                        btnBack.Text = "Back"
                    End If
                End If
            End Using

        End Using
    End Sub

    Private Sub frmPatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        ChangeBtnName()
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgv.Columns(0).HeaderCell.Value = "Patient ID"
        dgv.Columns(1).HeaderCell.Value = "First Name"
        dgv.Columns(2).HeaderCell.Value = "Last Name"
        dgv.Columns(3).HeaderCell.Value = "Identity Card No."
        dgv.Columns(6).HeaderCell.Value = "Contact No."
        dgv.Columns(7).HeaderCell.Value = "Email Address"
        dgv.Columns(11).HeaderCell.Value = "Postal Code"

        Timer2.Enabled = True

        ''dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        ''dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub BindData()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Check_Database()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            frmUpdatePatient.SelectedId = id
            frmUpdatePatient.ShowDialog(Me)
            ''BindData()
        End If
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnRegisterPatient.Click
        Dim db As New CMSDatabaseDataContext()

        Dim rs = From p In db.Patients

        dgv.DataSource = rs
        frmRegisterPatient.ShowDialog(Me)
        ''BindData()
    End Sub

    Private Sub txtSearchPatient_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPatient.TextChanged
        MakeSearch()
    End Sub

    Private Sub MakeSearch()
        If cboSearchPatient.SelectedIndex = 0 Then
            BindDataById()
        ElseIf cboSearchPatient.SelectedIndex = 1 Then
            BindDataByFirstName()
        ElseIf cboSearchPatient.SelectedIndex = 2 Then
            BindDataByLastName()
        ElseIf cboSearchPatient.SelectedIndex = 3 Then
            BindDataByIc()
        Else
            BindData()
        End If
    End Sub

    Private Sub BindDataById()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.PatientId.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByFirstName()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.FirstName.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByLastName()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.LastName.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByIc()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.IcNo.Contains(txtSearchPatient.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByGender()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.Gender Is SpecifiedGender

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub ResetField()
        txtSearchPatient.Clear()
        cboGender.SelectedIndex = -1
    End Sub

    Private Sub cboSearchPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchPatient.SelectedIndexChanged

        BindData()
        ResetField()

        If cboSearchPatient.SelectedIndex = 4 Then
            txtSearchPatient.Enabled = False
            txtSearchPatient.Visible = False
            cboGender.Enabled = True
            cboGender.Visible = True
        Else
            txtSearchPatient.Enabled = True
            txtSearchPatient.Visible = True
            cboGender.Enabled = False
            cboGender.Visible = False
            txtSearchPatient.Focus()
        End If
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        If cboGender.SelectedIndex = 0 Then
            SpecifiedGender = "Male"

            BindDataByGender()
        ElseIf cboGender.SelectedIndex = 1 Then
            SpecifiedGender = "Female"

            BindDataByGender()
        Else
            BindData()
        End If

    End Sub

    Private Sub cboSortPatient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortPatient.SelectedIndexChanged
        If cboSortPatient.SelectedIndex <> -1 Then
            cboSortSequence.Enabled = True
            cboSortSequence.SelectedIndex = -1
            BindData()
        Else
            cboSortSequence.Enabled = False
        End If
    End Sub

    Private Sub cboSortSequence_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortSequence.SelectedIndexChanged
        MakeSort()
    End Sub

    Private Sub MakeSort()
        If cboSortSequence.SelectedIndex = 0 Then
            If cboSortPatient.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Ascending)
            ElseIf cboSortPatient.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Ascending)
            ElseIf cboSortPatient.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(4), ListSortDirection.Ascending)
            End If
        ElseIf cboSortSequence.SelectedIndex = 1 Then
            If cboSortPatient.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Descending)
            ElseIf cboSortPatient.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(2), ListSortDirection.Descending)
            ElseIf cboSortPatient.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(4), ListSortDirection.Descending)
            End If
        End If
    End Sub

    Private Sub btnDeletePatient_Click(sender As Object, e As EventArgs) Handles btnDeletePatient.Click
        Dim db As New CMSDatabaseDataContext()
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = ClickedId)

        If p Is Nothing Then
            MessageBox.Show("Patient not found, please select a patient to be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            db.Patients.DeleteOnSubmit(p)
            db.SubmitChanges()
            MessageBox.Show("Patient " + p.FirstName + " " + p.LastName + " had been deleted successfully.")
        End If

        BindData()

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            ClickedId = id
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    BindData()

    '    Dim db As New CMSDatabaseDataContext()
    '    Dim c As UpdateCheck = db.UpdateChecks.FirstOrDefault(Function(o) o.TableName = "Patient")

    '    c.GotUpdate = "No"
    '    db.SubmitChanges()
    'End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim db As New CMSDatabaseDataContext()
        Dim c As UpdateCheck = db.UpdateChecks.FirstOrDefault(Function(o) o.TableName = "Patient")

        If c.GotUpdate = "Yes" Then

            If cboSortSequence.SelectedIndex <> -1 Then
                BindData()
                MakeSort()
            ElseIf cboSearchPatient.SelectedIndex <> -1 Then
                MakeSearch()
            Else
                BindData()
            End If
            c.GotUpdate = "No"
            db.SubmitChanges()
        End If
    End Sub

    Public Sub CountQueue()
        Dim db As New CMSDatabaseDataContext()
        Dim ds = From p In db.Patients Where p.Status = "Consulting"
        QueueNo = ds.Count()
    End Sub

    Private Sub btnAddPatient_Click_1(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        CountQueue()
        Dim db As New CMSDatabaseDataContext()
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = ClickedId)

        If p Is Nothing Then
            MessageBox.Show("Patient not found, please select a patient to be added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
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

            Dim sqlChkVisit As String = "Select * from Patient where Status = 'Consulting'"
            Using ConnChkVisit As New SqlConnection(str)
                Using cmdChkVisit As New SqlCommand(sqlChkVisit, ConnChkVisit)
                    ConnChkVisit.Open()
                    Dim rd = cmdChkVisit.ExecuteReader
                    rd.Read()
                    If rd.HasRows = True Then
                        Dim PatientID As String = rd("PatientId").ToString
                        If p.PatientId = ClickedId And p.Status = "Consulting" Then
                            MessageBox.Show("Patient already in the queue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim sql As String = "update Patient set Status=@Status, Queue=@Queue where PatientId = '" + p.PatientId + "'"
                            Using Conn As New SqlConnection(str)
                                Using cmd As New SqlCommand(sql, Conn)
                                    cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Consulting"
                                    cmd.Parameters.Add("@Queue", SqlDbType.Int).Value = QueueNo + 1
                                    Conn.Open()
                                    cmd.ExecuteNonQuery()
                                    GlobalVariables.currentPatient = p.PatientId
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
                        Dim sql As String = "update Patient set Status=@Status, Queue=@Queue where PatientId = '" + p.PatientId + "'"
                        Using Conn As New SqlConnection(str)
                            Using cmd As New SqlCommand(sql, Conn)
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Consulting"
                                cmd.Parameters.Add("@Queue", SqlDbType.Int).Value = QueueNo + 1
                                Conn.Open()
                                cmd.ExecuteNonQuery()
                                GlobalVariables.currentPatient = p.PatientId
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
        End If
    End Sub

End Class