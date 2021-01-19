Imports System.ComponentModel

Public Class frmInventoryList

    Public ClickedId As String

    Private Sub frmInventoryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgv.Columns(0).HeaderCell.Value = "Item ID"
        dgv.Columns(1).HeaderCell.Value = "Item Name"
        dgv.Columns(2).HeaderCell.Value = "Item Description"
        dgv.Columns(3).HeaderCell.Value = "Unit Price (RM)"
        dgv.Columns(5).HeaderCell.Value = "Expiry Date"
    End Sub

    Private Sub BindData()
        Dim db As New CMSDatabaseDataContext()

        Dim rs = From m In db.Inventories

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmRecLogin.Show()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            frmUpdateInventory.SelectedId = id
            frmUpdateInventory.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim db As New CMSDatabaseDataContext()

        Dim rs = From m In db.Inventories

        dgv.DataSource = rs
        frmAddInventory.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub txtSearchInventory_TextChanged(sender As Object, e As EventArgs) Handles txtSearchInventory.TextChanged
        If cboSearchInventory.SelectedIndex = 0 Then
            BindDataById()
        ElseIf cboSearchInventory.SelectedIndex = 1 Then
            BindDataByName()
        ElseIf cboSearchInventory.SelectedIndex = 2 Then
            If txtSearchInventory.Text = "" Then
                BindData()
            Else
                BindDataByPrice()
            End If
        End If
    End Sub

    Private Sub BindDataById()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From m In db.Inventories
                 Where m.ItemId.Contains(txtSearchInventory.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByName()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From m In db.Inventories
                 Where m.ItemName.Contains(txtSearchInventory.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub BindDataByPrice()
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From m In db.Inventories
                 Where m.UnitPrice.Equals(txtSearchInventory.Text)

        dgv.DataSource = rs
        lblResultsNo.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub ResetField()
        txtSearchInventory.Clear()
    End Sub

    Private Sub cboSearchInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchInventory.SelectedIndexChanged
        BindData()
        ResetField()
    End Sub

    Private Sub cboSortInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortInventory.SelectedIndexChanged
        If cboSortInventory.SelectedIndex <> -1 Then
            cboSortSequence.Enabled = True
            cboSortSequence.SelectedIndex = -1
            BindData()
        Else
            cboSortSequence.Enabled = False
        End If
    End Sub

    Private Sub cboSortSequence_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSortSequence.SelectedIndexChanged
        If cboSortSequence.SelectedIndex = 0 Then
            If cboSortInventory.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Ascending)
            ElseIf cboSortInventory.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(3), ListSortDirection.Ascending)
            ElseIf cboSortInventory.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(4), ListSortDirection.Ascending)
            ElseIf cboSortInventory.SelectedIndex = 3 Then
                dgv.Sort(dgv.Columns(5), ListSortDirection.Ascending)
            End If
        ElseIf cboSortSequence.SelectedIndex = 1 Then
            If cboSortInventory.SelectedIndex = 0 Then
                dgv.Sort(dgv.Columns(1), ListSortDirection.Descending)
            ElseIf cboSortInventory.SelectedIndex = 1 Then
                dgv.Sort(dgv.Columns(3), ListSortDirection.Descending)
            ElseIf cboSortInventory.SelectedIndex = 2 Then
                dgv.Sort(dgv.Columns(4), ListSortDirection.Descending)
            ElseIf cboSortInventory.SelectedIndex = 3 Then
                dgv.Sort(dgv.Columns(5), ListSortDirection.Descending)
            End If
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        Dim db As New CMSDatabaseDataContext()
        Dim m As Inventory = db.Inventories.FirstOrDefault(Function(o) o.ItemId = ClickedId)

        If m Is Nothing Then
            MessageBox.Show("Item not found, please select an item to be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            db.Inventories.DeleteOnSubmit(m)
            db.SubmitChanges()
            MessageBox.Show("Item " + m.ItemName + " had been deleted successfully.")
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

    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        If dgv.Rows(e.RowIndex).Cells("Quantity").Value.ToString() < 5 Then
            dgv.Rows(e.RowIndex).Cells("Quantity").Style.BackColor = Color.Orange
        End If
        If dgv.Rows(e.RowIndex).Cells("ExpiryDate").Value.ToString() < DateAdd("d", 7, DateTime.Today) Then
            dgv.Rows(e.RowIndex).Cells("ExpiryDate").Style.BackColor = Color.Orange
        End If
    End Sub
End Class