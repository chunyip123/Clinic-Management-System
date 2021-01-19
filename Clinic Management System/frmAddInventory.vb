Imports System.Text

Public Class frmAddInventory

    Public NextItemId As Integer
    Public ExistingSameId As Integer
    Public ExistingSameResult As Integer

    Protected Overrides Sub WndProc(ByRef message As Message)
        If message.Msg = &H84 Then ' WM_NCHITTEST
            message.Result = CType(1, IntPtr)
            Return
        End If
        MyBase.WndProc(message)
    End Sub

    Private Sub frmAddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ResetForm()
        NextItemId = 1

        txtItemId.Clear()
        txtItemName.Clear()
        txtItemDescription.Clear()
        mskUnitPrice.Clear()
        txtQuantity.Text = 0
        dtpExpiryDate.MinDate = DateTime.Today
        dtpExpiryDate.Value = DateTime.Now

        Dim db As New CMSDatabaseDataContext()
        Dim rs = From m In db.Inventories
                 Where m.ItemId Is "M" + NextItemId.ToString()

        ExistingSameId = rs.Count()

        While ExistingSameId <> 0
            NextItemId += 1
            ExistingSameId = rs.Count()
        End While

        txtItemId.Text = "M" + NextItemId.ToString
        txtItemName.Focus()
    End Sub

    Private Sub frmAddInventory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
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

        Dim db As New CMSDatabaseDataContext()
        Dim rs = From m In db.Inventories
                 Where m.ItemName Is txtItemName.Text

        ExistingSameResult = rs.Count()

        If ExistingSameResult <> 0 Then

            MessageBox.Show("Item details cound not be added to list as this item name already exist in the system.", "Unable to Register", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim m As New Inventory()
            m.ItemId = txtItemId.Text
            m.ItemName = txtItemName.Text
            m.ItemDescription = txtItemDescription.Text
            m.UnitPrice = mskUnitPrice.Text
            m.Quantity = txtQuantity.Text
            m.ExpiryDate = dtpExpiryDate.Value.Date

            db.Inventories.InsertOnSubmit(m)
            db.SubmitChanges()
            MessageBox.Show("Item details of " & m.ItemName & " had been added to list successfully.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ResetForm()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub mskUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskUnitPrice.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
End Class