Public Class frmAppointmentList
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmRecLogin.Show()
    End Sub

    Private Sub frmAppointmentList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BindData()
    End Sub

    Private Sub BindData()
        Dim Result1 = CheckResults("9:00")
        If Result1 <> 0 Then
            btn900AM.ForeColor = Color.Red
        Else
            btn900AM.ForeColor = Color.Green
        End If

        Dim Result2 = CheckResults("9:15")
        If Result2 <> 0 Then
            btn915AM.ForeColor = Color.Red
        Else
            btn915AM.ForeColor = Color.Green
        End If

        Dim Result3 = CheckResults("9:30")
        If Result3 <> 0 Then
            btn930AM.ForeColor = Color.Red
        Else
            btn930AM.ForeColor = Color.Green
        End If

        Dim Result4 = CheckResults("9:45")
        If Result4 <> 0 Then
            btn945AM.ForeColor = Color.Red
        Else
            btn945AM.ForeColor = Color.Green
        End If

        Dim Result5 = CheckResults("10:00")
        If Result5 <> 0 Then
            btn1000AM.ForeColor = Color.Red
        Else
            btn1000AM.ForeColor = Color.Green
        End If

        Dim Result6 = CheckResults("10:15")
        If Result6 <> 0 Then
            btn1015AM.ForeColor = Color.Red
        Else
            btn1015AM.ForeColor = Color.Green
        End If

        Dim Result7 = CheckResults("10:30")
        If Result7 <> 0 Then
            btn1030AM.ForeColor = Color.Red
        Else
            btn1030AM.ForeColor = Color.Green
        End If

        Dim Result8 = CheckResults("10:45")
        If Result8 <> 0 Then
            btn1045AM.ForeColor = Color.Red
        Else
            btn1045AM.ForeColor = Color.Green
        End If

        Dim Result9 = CheckResults("11:00")
        If Result9 <> 0 Then
            btn1100AM.ForeColor = Color.Red
        Else
            btn1100AM.ForeColor = Color.Green
        End If
    End Sub

    Private Function CheckResults(ByVal TimeofDay As String) As Integer
        Dim db As New CMSDatabaseDataContext()
        Dim rs = From a In db.Appointments
                 Where a.Date.Equals(mcAppointmentDate.SelectionRange.Start.ToShortDateString()) And a.Time.Equals(TimeofDay)

        Dim totalresult As Integer
        totalresult = rs.Count()
        Return totalresult
    End Function

    Private Sub mcAppointmentDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcAppointmentDate.DateChanged
        BindData()
    End Sub

    Private Sub TimeButtons_Click(sender As Object, e As EventArgs) Handles btn900AM.Click, btn915AM.Click, btn930AM.Click, btn945AM.Click, btn945AM.Click, btn1000AM.Click, btn1015AM.Click, btn1030AM.Click, btn1045AM.Click
        Dim timeButton = DirectCast(sender, Button)
        frmEditAppointment.SelectedDate = mcAppointmentDate.SelectionRange.Start.ToShortDateString()
        frmEditAppointment.SelectedTime = TimeSpan.Parse(timeButton.Text)

        If timeButton.ForeColor = Color.Red Then
            frmEditAppointment.SlotOccupied = "Yes"
        Else
            frmEditAppointment.SlotOccupied = "No"
        End If

        frmEditAppointment.ShowDialog(Me)
        BindData()
    End Sub
End Class