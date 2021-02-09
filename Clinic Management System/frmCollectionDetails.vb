Public Class frmCollectionDetails

    Public SelectedId As String

    Private Sub frmCollectionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ''dgv.Columns.Add("Unit Total", "Unit Total (RM)")
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
        chkCollectionDone.Checked = False

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
                 Select l.ItemId, m.ItemName, m.ItemDescription, m.UnitPrice, l.AmountTaken

        ''Dim table As New DataTable("table")

        ''table.Columns.Add("Unit Total", Type.GetType("System.Double"))

        dgv.DataSource = rs

        dgv.Columns(0).HeaderCell.Value = "Item ID"
        dgv.Columns(1).HeaderCell.Value = "Item Name"
        dgv.Columns(2).HeaderCell.Value = "Item Description"
        dgv.Columns(3).HeaderCell.Value = "Unit Price (RM)"
        dgv.Columns(4).HeaderCell.Value = "Quantity"
        dgv.Columns.Add("Unit Total", "Unit Total (RM)")

        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim unitPrice As Double = dgv.Rows(i).Cells(3).Value
            Dim quantity As Integer = dgv.Rows(i).Cells(4).Value

            Dim unitTotal As Double = unitPrice * quantity

            dgv.Rows(i).Cells(5).Value = unitTotal.ToString("N2")
        Next
    End Sub

    Private Sub frmCollectionDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dgv.Columns.RemoveAt(5)
    End Sub

    Private Sub btnProceedCheckout_Click(sender As Object, e As EventArgs) Handles btnProceedCheckout.Click
        frmMakePayment.SelectedId = SelectedId
        frmMakePayment.ShowDialog(Me)
    End Sub
End Class