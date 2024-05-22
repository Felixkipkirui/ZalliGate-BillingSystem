Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.PBar.Value = PBar.Value + 1
        If PBar.Value >= 100 Then
            Timer1.Stop()
            LoginForm.Show()
            Me.Hide()

        End If
    End Sub
End Class
