Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LabelReportProgress.Text = ProgressBarLoading1.Value & "%"


        ProgressBarLoading1.Value += 1
        If ProgressBarLoading1.Value > 10 Then
            Label4.Text = "Loading... please wait"
        End If
        If ProgressBarLoading1.Value > 40 Then
            Label4.Text = "Still Loading..."
        End If
        If ProgressBarLoading1.Value > 80 Then
            Label4.Text = " almost done..."
        End If
        If ProgressBarLoading1.Value = 100 Then
            Label4.Text = "Launching the app"
            Login.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub


End Class
