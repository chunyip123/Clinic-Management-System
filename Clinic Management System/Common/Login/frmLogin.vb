Imports System.Text
Imports System.Data.SqlClient

Public Class frmLogin

    Public Class GlobalVariables
        Public Shared loginuser As String
        Public Shared usertypename As String
        Public Shared currentPatient As String
    End Class

    Private Sub frmRecLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "" Then
            err.AppendLine("-Please key in your User ID.")
            ctr = If(ctr, txtUsername)
        End If

        If password = "" Then
            err.AppendLine("-Please key in your password.")
            ctr = If(ctr, txtPassword)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Check_Database()
    End Sub

    Private Sub Check_Database()
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CMSDatabase.mdf;Integrated Security=True"
        Dim sql As String = "select * from Employee where UserName=@username and Password=@password"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                ''Dim value = cmd.ExecuteScalar()
                Dim dr = cmd.ExecuteReader
                dr.Read()
                ''If value > 0 Then
                If dr.HasRows = True Then
                    GlobalVariables.loginuser = txtUsername.Text
                    Dim employeeType As String = dr("EmployeeType").ToString
                    If employeeType = "Receptionist" Then
                        Me.Hide()
                        frmMenu.Show()
                        ''MessageBox.Show("Login sucessfully!")
                    ElseIf employeeType = "Doctor" Then
                        Me.Hide()
                        frmDiagPres.Show()
                        ''MessageBox.Show("Login sucessfully!")
                    End If
                Else
                    MessageBox.Show("Please key in the valid Username or Password.")
                End If
            End Using

        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmRecLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
