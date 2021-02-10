Public Class frmMakePayment

    Public SelectedId As String
    Public NextInvoiceId As Integer
    Public ExistingSameId As Integer
    Public totalPrice As Double
    Public serviceFee As Double
    Public discountTotal As Double
    Public grandTotal As Double

    Private Sub lblPatientId_Click(sender As Object, e As EventArgs) Handles lblPatientId.Click

    End Sub

    Private Sub lblPatientIdR_Click(sender As Object, e As EventArgs) Handles lblPatientIdR.Click

    End Sub

    Private Sub lblFirstName_Click(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub lblFirstNameR_Click(sender As Object, e As EventArgs) Handles lblFirstNameR.Click

    End Sub

    Private Sub lblLastName_Click(sender As Object, e As EventArgs) Handles lblLastName.Click

    End Sub

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmCollectionDetails.Show()
    End Sub

    Private Sub radCashPayment_CheckedChanged(sender As Object, e As EventArgs) Handles radCashPayment.CheckedChanged

    End Sub

    Private Sub radCreditCardPayment_CheckedChanged(sender As Object, e As EventArgs) Handles radCreditCardPayment.CheckedChanged

    End Sub

    Private Sub chkPanelOrg_CheckedChanged(sender As Object, e As EventArgs) Handles chkPanelOrg.CheckedChanged
        If chkPanelOrg.Checked = True Then
            txtOrganizationCode.Enabled = True
            btnApplyPanel.Enabled = True
        Else
            txtOrganizationCode.Enabled = False
            btnApplyPanel.Enabled = False
            discountTotal = 0
            CalculatePrice()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmMakePayment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        totalPrice = 0
        serviceFee = 0
        chkPanelOrg.Checked = False
        discountTotal = 0
        grandTotal = 0

        NextInvoiceId = 1

        Panel1.VerticalScroll.Value = 0

        Dim db As New CMSDatabaseDataContext()

        Dim rt = From k In db.Invoices
                 Where k.InvoiceId Is "K" + NextInvoiceId.ToString()

        ExistingSameId = rt.Count()

        While ExistingSameId <> 0
            NextInvoiceId += 1
            ExistingSameId = rt.Count()
        End While

        lblInvoiceIdR.Text = "K" + NextInvoiceId.ToString()

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

        lblInvoiceDateR.Text = DateTime.Now.Date
        lblInvoiceTimeR.Text = DateTime.Now.ToString("hh:mm:ss")

        Dim rs = From m In db.Inventories
                 Join l In db.Medicals On l.ItemId Equals m.ItemId
                 Where l.PatientId = SelectedId
                 Select l.ItemId, m.ItemName, m.ItemDescription, m.UnitPrice, l.AmountTaken

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

        If dgv.RowCount > 1 Then
            For index As Integer = 0 To dgv.RowCount - 1
                totalPrice += Convert.ToDouble(dgv.Rows(index).Cells(5).Value)
            Next

            'lblSubtotalR.Text = "RM" + totalPrice.ToString("N2")

            'serviceFee = totalPrice * 6 / 100
            'lblServiceFeeR.Text = "RM" + serviceFee.ToString("N2")
            'lblDiscountR.Text = "RM" + discountTotal.ToString("N2")
            'grandTotal = totalPrice + serviceFee
            'lblGrandTotalR.Text = "RM" + grandTotal.ToString("N2")
            CalculatePrice()
        End If
    End Sub

    Private Sub CalculatePrice()
        lblSubtotalR.Text = "RM" + totalPrice.ToString("N2")
        serviceFee = totalPrice * 6 / 100
        lblServiceFeeR.Text = "RM" + serviceFee.ToString("N2")
        If discountTotal = 0 Then
            lblDiscountR.Text = "None"
        Else
            lblDiscountR.Text = "RM" + discountTotal.ToString("N2")
        End If
        grandTotal = totalPrice + serviceFee - discountTotal
        If grandTotal < 0 Then
            grandTotal = 0
        End If
        lblGrandTotalR.Text = "RM" + grandTotal.ToString("N2")
    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub frmMakePayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub frmMakePayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dgv.Columns.RemoveAt(5)
    End Sub

    Private Sub btnApplyPanel_Click(sender As Object, e As EventArgs) Handles btnApplyPanel.Click
        Dim db As New CMSDatabaseDataContext()
        Dim c As PanelOrganisation = db.PanelOrganisations.FirstOrDefault(Function(o) o.OrgCode = txtOrganizationCode.Text.ToUpper)

        If c Is Nothing Then
            MessageBox.Show("The organisation code cannot be found in the panel list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOrganizationCode.Clear()
            discountTotal = 0
        Else
            discountTotal = Double.Parse(c.CoverLimit)
        End If

        'lblDiscountR.Text = "RM" + discountTotal.ToString("N2")
        'lblGrandTotalR.Text = "RM" + (totalPrice + serviceFee - discountTotal).ToString("N2")
        CalculatePrice()
    End Sub
End Class