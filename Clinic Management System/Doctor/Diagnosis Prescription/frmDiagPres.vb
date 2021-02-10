Imports Clinic_Management_System.frmLogin
Imports System.Data.SqlClient
Public Class frmDiagPres
    ''Public MedicineName As String
    ''Public Amount As Integer
    ''Public Taken As String
    ''Public Remarks As String
    Public PrescriptionTable As New DataTable("Table")
    Public NextRecId As Integer
    Public ExistingSameRecId As Integer

    Private Sub Clear_Page()
        lblUser.Text = ""
        lblName.Text = ""
        dgvPatient.Rows.Clear()
        dgvPatient.Columns.Clear()
        PrescriptionTable.Clear()
        dgvMedicine.Visible = False
    End Sub

    Public Sub Load_Page()
        'TODO: This line of code loads data into the 'CMSDatabaseDataSet.MedicalRecord' table. You can move, or remove it, as needed.
        Timer1.Enabled = True
        lblUser.Text = "Hello, " + GlobalVariables.loginuser
        Load_Patient()
        BindRecord()
        dgvPatient.ReadOnly = True
        dgvPatient.RowHeadersVisible = False
        dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPatient.Columns(2).HeaderCell.Value = "Date"
        dgvPatient.Columns(5).HeaderCell.Value = "Diagnosis"
        dgvPatient.Columns(3).HeaderCell.Value = "Blood Pressure"
        dgvPatient.Columns(4).HeaderCell.Value = "Allergies"
        dgvPatient.Columns(6).HeaderCell.Value = "Caution"

        dgvMedicine.ReadOnly = True
        dgvMedicine.RowHeadersVisible = False
        dgvMedicine.Visible = False


    End Sub

    Private Sub Load_Patient()
        Try
            Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CMSDatabase.mdf;Integrated Security=True"
            Dim sql As String = "select * from Patient where Status = 'Consulting' and Queue = 1"
            Dim dr As SqlDataReader
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    dr = cmd.ExecuteReader
                    dr.Read()
                    lblPatientID.Text = dr("PatientId")
                    Dim FirstName As String
                    Dim LastName As String
                    FirstName = dr("FirstName")
                    LastName = dr("LastName")
                    lblName.Text = FirstName + " " + LastName

                    Conn.Close()
                End Using
            End Using
        Catch ex As Exception
            Clear_Page()
        End Try

    End Sub

    Private Sub BindRecord()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From r In db.MedicalRecords Where r.PatientId.Equals(lblPatientID.Text)
        dgvPatient.DataSource = rs
    End Sub

    Private Sub PatientListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientListToolStripMenuItem.Click
        Me.Hide()
        frmPatientList.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim theDate As DateTime = System.DateTime.Now
        lblTime.Text = theDate.ToString("dd/MM/yyyy  h:mm:ss tt")
    End Sub

    Private Sub frmDiagPres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Page()
        dgvPrescription.RowHeadersVisible = False
        dgvPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        PrescriptionTable.Columns.Add("Medicine Name", Type.GetType("System.String"))
        PrescriptionTable.Columns.Add("Amount", Type.GetType("System.Int32"))
        PrescriptionTable.Columns.Add("Taken", Type.GetType("System.String"))
        PrescriptionTable.Columns.Add("Remarks", Type.GetType("System.String"))
        dgvPrescription.DataSource = PrescriptionTable

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Me.Hide()
        frmPatientList.Show()
    End Sub

    Private Sub dgvPatient_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatient.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim selectRecord As String = CStr(dgvPatient.Rows(i).Cells(0).Value)
            Dim db As New CMSDatabaseDataContext()
            Dim mt = From t In db.MedicalTakens Where t.RecId.Equals(selectRecord)
            ''Dim mt As MedicineTaken = db.MedicineTakens.FirstOrDefault(Function(o) o.VisitDate = selectDate)
            dgvMedicine.Visible = True
            dgvMedicine.DataSource = mt
            dgvMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            ''Dim rows = dgvMedicine.Rows.Count
            ''Dim columns = dgvMedicine.Columns.Count

            ''For i = 0 To columns - 1
            ''Dim counter = 0
            ''For j = 0 To rows - 1
            ''If IsNothing(dgvMedicine.Rows(j).Cells(i).Value) OrElse IsDBNull(dgvMedicine.Rows(j).Cells(i).Value) Then
            ''counter = counter + 1
            ''Else
            ''Exit For
            ''End If''
            ''Next
            ''If counter = rows Then
            ''dgvMedicine.Columns(i).Visible = False
            ''End If
            ''Next
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Load_Page()
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim Pid As String = lblPatientID.Text
        frmAddAppointment.SelectedPatient = Pid
        frmAddAppointment.ShowDialog(Me)
    End Sub

    Private Sub btnAddPrescription_Click(sender As Object, e As EventArgs) Handles btnAddPrescription.Click
        frmAddPrescription.ShowDialog(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            NextRecId = 1
            Dim db As New CMSDatabaseDataContext()
            Dim rs0 = From o In db.MedicalRecords
                      Where o.RecordId Is "R" + NextRecId.ToString()

            ExistingSameRecId = rs0.Count()

            While ExistingSameRecId <> 0
                NextRecId += 1
                ExistingSameRecId = rs0.Count()
            End While

            Dim RID As String = "R" + NextRecId.ToString

            Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CMSDatabase.mdf;Integrated Security=True"
            Dim sqlP As String = "update Patient set Status = 'Ready For Collection', Queue = 0 where PatientId = '" + lblPatientID.Text + "'"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sqlP, Conn)
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    GlobalVariables.currentPatient = lblPatientID.Text
                End Using
            End Using

            Dim sqlQ As String = "update Patient set Queue -= 1 where Status = 'Consulting'"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sqlQ, Conn)
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Dim rs = From o In db.MedicalRecords
                     Where o.PatientId Is lblPatientID.Text

            Dim mr As New MedicalRecord()
            mr.RecordId = RID
            mr.PatientId = lblPatientID.Text
            mr.VisitDate = lblTime.Text
            mr.BloodPressure = txtBloodPresure.Text
            mr.Allergies = txtAllergies.Text
            mr.Disease = txtDiagnosis.Text
            mr.Caution = txtCaution.Text

            db.MedicalRecords.InsertOnSubmit(mr)
            db.SubmitChanges()

            ''Dim sqlMT As String = "insert into MedicalTaken values(@RecId, @PatientId, @Medicine, @Amount, @Taken, @Remarks)"
            ''Using Conn As New SqlConnection(str)
            ''Using cmd As New SqlCommand(sqlMT, Conn)
            ''cmd.Parameters.Add("@RecordId", SqlDbType.VarChar, 10)
            ''cmd.Parameters.Add("@PatientId", SqlDbType.VarChar, 10)
            ''cmd.Parameters.Add("@Medicine", SqlDbType.VarChar, 50)
            ''cmd.Parameters.Add("@Amount", SqlDbType.Int)
            ''cmd.Parameters.Add("@Taken", SqlDbType.VarChar, 50)
            ''cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, -1)


            ''Conn.Open()

            For i As Integer = 0 To dgvPrescription.Rows.Count - 1
                Dim sqlMT As String = "insert into MedicalTaken (RecId, PatientId, Medicine, Amount, Taken, Remarks) values(@RecId, @PatientId, @Medicine, @Amount, @Taken, @Remarks)"
                Using Conn As New SqlConnection(str)
                    Using cmd As New SqlCommand(sqlMT, Conn)
                        ''cmd.Parameters.Add("@RecordId", SqlDbType.VarChar, 10)
                        ''cmd.Parameters.Add("@PatientId", SqlDbType.VarChar, 10)
                        ''cmd.Parameters.Add("@Medicine", SqlDbType.VarChar, 50)
                        ''cmd.Parameters.Add("@Amount", SqlDbType.Int)
                        ''cmd.Parameters.Add("@Taken", SqlDbType.VarChar, 50)
                        ''cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, -1)


                        Conn.Open()
                        cmd.Parameters.AddWithValue("@RecId", mr.RecordId)
                        cmd.Parameters.AddWithValue("@PatientId", lblPatientID.Text)
                        cmd.Parameters.AddWithValue("@Medicine", dgvPrescription.Rows(i).Cells(0).Value)
                        cmd.Parameters.AddWithValue("@Amount", dgvPrescription.Rows(i).Cells(1).Value)
                        cmd.Parameters.AddWithValue("@Taken", dgvPrescription.Rows(i).Cells(2).Value)
                        cmd.Parameters.AddWithValue("@Remarks", dgvPrescription.Rows(i).Cells(3).Value)
                        ''cmd.Parameters(0).Value = RecID
                        ''cmd.Parameters(1).Value = lblPatientID.Text
                        ''cmd.Parameters(2).Value = dgvPrescription.Rows(i).Cells(0).Value
                        ''cmd.Parameters(3).Value = dgvPrescription.Rows(i).Cells(1).Value
                        ''cmd.Parameters(4).Value = dgvPrescription.Rows(i).Cells(2).Value
                        ''cmd.Parameters(5).Value = dgvPrescription.Rows(i).Cells(3).Value
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Next
            ''End Using
            ''End Using
            MessageBox.Show("Save Medical Record successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear_Page()

        Catch ex As Exception
            MessageBox.Show("Save Medical Record successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Clear_Page()
        End Try

    End Sub
End Class