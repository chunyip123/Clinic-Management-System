Public Class frmCollectionDetails

    Public SelectedId As String

    Private Sub frmCollectionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMedicineCollection.Show()
    End Sub

    Private Sub chkCollectionDone_CheckedChanged(sender As Object, e As EventArgs) Handles chkCollectionDone.CheckedChanged
        If chkCollectionDone.Checked = True Then
            btnProceedCheckout.Enabled = True
        Else
            btnProceedCheckout.Enabled = False
        End If
    End Sub

    Private Sub frmCollectionDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim db As New CMSDatabaseDataContext()
        Dim p As Patient = db.Patients.FirstOrDefault(Function(o) o.PatientId = SelectedId)

        If p Is Nothing Then
            MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

        lblPatientIdR.Text = p.PatientId
        lblFirstNameR.Text = p.FirstName
        lblLastNameR.Text = p.LastName
        lblIentityNoR.Text = p.IcNo
        lblAgeR.Text = p.Age
        lblGenderR.Text = p.Gender
        lblContactNoR.Text = p.ContactNo
        lblEmailAddressR.Text = p.EmailAdd

        Dim rs = From m In db.Inventories
                 Join l In db.Medicals On l.ItemId Equals m.ItemId
                 Where l.PatientId = SelectedId
                 Select m.ItemName, l.AmountTaken, l.ItemId

        dgv.DataSource = rs
    End Sub
End Class