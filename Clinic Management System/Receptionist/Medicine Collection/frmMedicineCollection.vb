Public Class frmMedicineCollection

    Public ClickedId As String

    Private Sub frmMedicineCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRFCtab.PerformClick()

        dgv.Columns(0).HeaderCell.Value = "Patient ID"
        dgv.Columns(1).HeaderCell.Value = "First Name"
        dgv.Columns(2).HeaderCell.Value = "Last Name"
        dgv.Columns(3).HeaderCell.Value = "Identity Card No."
        dgv.Columns(6).HeaderCell.Value = "Contact No."
        dgv.Columns(7).HeaderCell.Value = "Email Address"
        dgv.Columns(11).HeaderCell.Value = "Postal Code"

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnRFCtab_Click(sender As Object, e As EventArgs) Handles btnRFCtab.Click
        ''btnRFCtab.FlatStyle = FlatStyle.Flat
        btnRFCtab.BackColor = Color.White
        btnPendingtab.BackColor = Color.LightGray

        btnCheckCollection.Enabled = False
        btnCheckCollection.Visible = True

        BindDataForRFC()
    End Sub

    Private Sub BindDataForRFC()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.Status Is "Ready For Collection"

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub btnPendingtab_Click(sender As Object, e As EventArgs) Handles btnPendingtab.Click
        btnPendingtab.BackColor = Color.White
        btnRFCtab.BackColor = Color.LightGray

        btnCheckCollection.Enabled = False
        btnCheckCollection.Visible = False

        BindDataForPending()
    End Sub

    Private Sub BindDataForPending()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From p In db.Patients
                 Where p.Status Is "Consulting"

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            ClickedId = id
        End If

        btnCheckCollection.Enabled = True

    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            frmCollectionDetails.SelectedId = id
            frmCollectionDetails.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnCheckCollection_Click(sender As Object, e As EventArgs) Handles btnCheckCollection.Click
        frmCollectionDetails.SelectedId = ClickedId
        frmCollectionDetails.ShowDialog(Me)
    End Sub
End Class