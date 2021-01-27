Imports System.Text

Public Class frmUpdateInventory

    Public SelectedId As String

    Protected Overrides Sub WndProc(ByRef message As Message)
        If message.Msg = &H84 Then ' WM_NCHITTEST
            message.Result = CType(1, IntPtr)
            Return
        End If
        MyBase.WndProc(message)
    End Sub

    Private Sub frmUpdateInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEnableEdit.Checked = False
        ''dtpExpiryDate.MinDate = DateTime.Today
    End Sub

    Private Sub frmUpdateInventory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim db As New CMSDatabaseDataContext()
        Dim m As Inventory = db.Inventories.FirstOrDefault(Function(o) o.ItemId = SelectedId)

        If m Is Nothing Then
            MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

        txtItemId.Text = m.ItemDescription
        txtItemName.Text = m.ItemName
        txtItemDescription.Text = m.ItemDescription
        mskUnitPrice.Text = m.UnitPrice
        txtQuantity.Text = m.Quantity
        dtpExpiryDate.Value = m.ExpiryDate
        dtpExpiryDate.MinDate = DateTime.Today
    End Sub

    Private Sub btnUpdateDetail_Click(sender As Object, e As EventArgs) Handles btnUpdateDetail.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim itemname As String = txtItemName.Text
        Dim unitprice As String = mskUnitPrice.Text
        Dim quantity As String = txtQuantity.Text
        Dim expirydate As String = dtpExpiryDate.Value.Date

        If itemname = "" Then
            err.AppendLine("-Please fill in item's name.")
            ctr = If(ctr, txtItemName)
        End If

        If unitprice = "" Then
            err.AppendLine("-Please fill in item's unit price.")
            ctr = If(ctr, mskUnitPrice)
        End If

        If quantity = "" Then
            err.AppendLine("-Please fill in item's quantity.")
            ctr = If(ctr, txtQuantity)
        End If

        If expirydate = "" Then
            err.AppendLine("-Please fill in item's expiry date.")
            ctr = If(ctr, dtpExpiryDate)
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
        Dim m As Inventory = db.Inventories.FirstOrDefault(Function(o) o.ItemId = SelectedId)

        If m Is Nothing Then
            MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If

        m.ItemDescription = txtItemId.Text
        m.ItemName = txtItemName.Text
        m.ItemDescription = txtItemDescription.Text
        m.UnitPrice = mskUnitPrice.Text
        m.Quantity = txtQuantity.Text
        m.ExpiryDate = dtpExpiryDate.Value.Date

        db.SubmitChanges()

        MessageBox.Show("Details of item " + SelectedId + " had been updated successfully.")

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkEnableEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableEdit.CheckedChanged

        If chkEnableEdit.Checked = True Then
            txtItemName.Enabled = True
            txtItemDescription.Enabled = True
            mskUnitPrice.Enabled = True
            txtQuantity.Enabled = True
            dtpExpiryDate.Enabled = True
        Else
            txtItemName.Enabled = False
            txtItemDescription.Enabled = False
            mskUnitPrice.Enabled = False
            txtQuantity.Enabled = False
            dtpExpiryDate.Enabled = False
        End If
    End Sub
End Class