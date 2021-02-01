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

        Dim Result10 = CheckResults("11:15")
        If Result10 <> 0 Then
            btn1115AM.ForeColor = Color.Red
        Else
            btn1115AM.ForeColor = Color.Green
        End If

        Dim Result11 = CheckResults("11:30")
        If Result11 <> 0 Then
            btn1130AM.ForeColor = Color.Red
        Else
            btn1130AM.ForeColor = Color.Green
        End If

        Dim Result12 = CheckResults("11:45")
        If Result12 <> 0 Then
            btn1145AM.ForeColor = Color.Red
        Else
            btn1145AM.ForeColor = Color.Green
        End If

        Dim Result13 = CheckResults("12:00")
        If Result9 <> 0 Then
            btn1200PM.ForeColor = Color.Red
        Else
            btn1200PM.ForeColor = Color.Green
        End If

        Dim Result14 = CheckResults("12:15")
        If Result14 <> 0 Then
            btn1215PM.ForeColor = Color.Red
        Else
            btn1215PM.ForeColor = Color.Green
        End If

        Dim Result15 = CheckResults("12:30")
        If Result15 <> 0 Then
            btn1230PM.ForeColor = Color.Red
        Else
            btn1230PM.ForeColor = Color.Green
        End If

        Dim Result16 = CheckResults("12:45")
        If Result16 <> 0 Then
            btn1245PM.ForeColor = Color.Red
        Else
            btn1245PM.ForeColor = Color.Green
        End If

        Dim Result17 = CheckResults("14:00")
        If Result17 <> 0 Then
            btn200PM.ForeColor = Color.Red
        Else
            btn200PM.ForeColor = Color.Green
        End If

        Dim Result18 = CheckResults("14:15")
        If Result18 <> 0 Then
            btn215PM.ForeColor = Color.Red
        Else
            btn215PM.ForeColor = Color.Green
        End If

        Dim Result19 = CheckResults("14:30")
        If Result19 <> 0 Then
            btn230PM.ForeColor = Color.Red
        Else
            btn230PM.ForeColor = Color.Green
        End If

        Dim Result20 = CheckResults("14:45")
        If Result20 <> 0 Then
            btn245PM.ForeColor = Color.Red
        Else
            btn245PM.ForeColor = Color.Green
        End If

        Dim Result21 = CheckResults("15:00")
        If Result21 <> 0 Then
            btn300PM.ForeColor = Color.Red
        Else
            btn300PM.ForeColor = Color.Green
        End If

        Dim Result22 = CheckResults("15:15")
        If Result22 <> 0 Then
            btn315PM.ForeColor = Color.Red
        Else
            btn315PM.ForeColor = Color.Green
        End If

        Dim Result23 = CheckResults("15:30")
        If Result23 <> 0 Then
            btn330PM.ForeColor = Color.Red
        Else
            btn330PM.ForeColor = Color.Green
        End If

        Dim Result24 = CheckResults("15:45")
        If Result24 <> 0 Then
            btn345PM.ForeColor = Color.Red
        Else
            btn345PM.ForeColor = Color.Green
        End If

        Dim Result25 = CheckResults("16:00")
        If Result25 <> 0 Then
            btn400PM.ForeColor = Color.Red
        Else
            btn400PM.ForeColor = Color.Green
        End If

        Dim Result26 = CheckResults("16:15")
        If Result26 <> 0 Then
            btn415PM.ForeColor = Color.Red
        Else
            btn415PM.ForeColor = Color.Green
        End If

        Dim Result27 = CheckResults("16:30")
        If Result27 <> 0 Then
            btn430PM.ForeColor = Color.Red
        Else
            btn430PM.ForeColor = Color.Green
        End If

        Dim Result28 = CheckResults("16:45")
        If Result28 <> 0 Then
            btn445PM.ForeColor = Color.Red
        Else
            btn445PM.ForeColor = Color.Green
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

    Private Sub TimeButtons_Click(sender As Object, e As EventArgs) Handles btn900AM.Click, btn915AM.Click, btn930AM.Click, btn945AM.Click, btn1000AM.Click, btn1015AM.Click, btn1030AM.Click, btn1045AM.Click, btn1100AM.Click, btn1115AM.Click, btn1130AM.Click, btn1145AM.Click, btn1200PM.Click, btn1215PM.Click, btn1230PM.Click, btn1245PM.Click, btn200PM.Click, btn215PM.Click, btn230PM.Click, btn245PM.Click, btn300PM.Click, btn315PM.Click, btn330PM.Click, btn345PM.Click, btn400PM.Click, btn415PM.Click, btn430PM.Click, btn445PM.Click
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmAppointmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class