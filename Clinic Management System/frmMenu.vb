Imports Clinic_Management_System.frmRecLogin

Public Class frmMenu
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblClinic.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Me.Hide()
        frmPatientList.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmRecLogin.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        lblUsername.Text = "Hello, " + GlobalVariables.loginuser
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim theDate As DateTime = System.DateTime.Now
        lblTime.Text = theDate.ToString("dd/MM/yyyy  h:mm:ss tt")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub btnPanel_Click(sender As Object, e As EventArgs) Handles btnPanel.Click
        Me.Hide()
        frmPanelList.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Hide()
        frmInventoryList.Show()
    End Sub

    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Me.Hide()
        frmAppointmentList.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Me.Hide()
        frmMedicineCollection.Show()
    End Sub
End Class