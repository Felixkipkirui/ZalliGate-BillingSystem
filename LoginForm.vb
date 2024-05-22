Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Con.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM systemadmin WHERE Username = @username AND  Password = @password", Con)
        cmd.Parameters.AddWithValue("username", txtUsername.Text)
        cmd.Parameters.AddWithValue("password", txtPassword.Text)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then

            If cmbSession.SelectedIndex <> -1 Then

                MsgBox("Login Successfull. The Current Active Session is " & cmbSession.Text, vbInformation, "ZalliGate PLC")

                POS.Show()
                POS.lblUser.Text = txtUsername.Text
                POS.lblSession.Text = cmbSession.Text
                Me.Close()

            Else
                ' Display an error message if nothing is selected from the combo box
                MsgBox("Please select a value from the combo box.")
            End If

        Else
            MsgBox("Make Sure Your Username and Password are matching")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If

        Con.Close()



    End Sub

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Confirm if your want to logout", " ZalliGate PLC ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class