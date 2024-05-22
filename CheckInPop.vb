Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class CheckInPop
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3

    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub CheckInPop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        FillComboBox()

        txtShift.Text = "SHIFT-1"

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Sub FillComboBox()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Username FROM staff"
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbServedBy.Items.Add(reader.GetString("Username"))
                    End While
                End Using
                connection.Close()

            End Using
        End Using
    End Sub

    Sub StaffID()
        ' Construct your SQL query
        Dim query As String = "SELECT StaffID FROM staff WHERE Username = '" & cmbServedBy.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtStaffID.Text = result.ToString()
                    Else
                        txtStaffID.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmbServedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServedBy.SelectedIndexChanged
        StaffID()
        StaffName()
        StaffRole()


    End Sub
    Sub StaffName()
        ' Construct your SQL query
        Dim query As String = "SELECT StaffName FROM staff WHERE Username = '" & cmbServedBy.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtName.Text = result.ToString()
                    Else
                        txtName.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub StaffRole()
        ' Construct your SQL query
        Dim query As String = "SELECT Role FROM staff WHERE Username = '" & cmbServedBy.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtRole.Text = result.ToString()
                    Else
                        txtRole.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If cmbServedBy.SelectedIndex <> -1 Then

            'ClockIn()
            Try
                Con.Open()
                cmd = New MySqlCommand("INSERT INTO `attendance`(`StaffID`, `StaffName`, `Username`, `Date`, `WorkShift`, `CheckInTime`) VALUES (@staffid,@staffname,@username,@date,@shift,@timein)", Con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@staffid", txtStaffID.Text)
                cmd.Parameters.AddWithValue("@staffname", txtName.Text)
                cmd.Parameters.AddWithValue("@username", cmbServedBy.Text)
                cmd.Parameters.AddWithValue("@date", CDate(lblDate.Text))
                cmd.Parameters.AddWithValue("@shift", txtShift.Text)
                cmd.Parameters.AddWithValue("@timein", lblMyTime.Text)


                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Employee For SHIFT-1 Has Clocked Successfully For Work", vbInformation, "ZalliGate PLC")
                Else
                    MsgBox("Warning : Clock In Failed", vbCritical, "ZalliGate PLC")
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            txtName.Text = ""
            txtRole.Text = ""
            txtStaffID.Text = ""

            Close()







        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please select a value from the combo box.")
        End If
    End Sub

    Sub ClockIn()
        Try
            Con.Open()
            cmd = New MySqlCommand("INSERT INTO `attendance`(`StaffID`, `StaffName`, `Username`, `Date`, `CheckInTime`) VALUES (@staffid,@staffname,@username,@date,@timein)", Con)

            cmd.Parameters.AddWithValue("@staffid", txtStaffID.Text)
            cmd.Parameters.AddWithValue("@staffname", txtName.Text)
            cmd.Parameters.AddWithValue("@username", cmbServedBy.Text)
            cmd.Parameters.AddWithValue("@date", CDate(lblDate.Text))
            cmd.Parameters.AddWithValue("@timein", lblMyTime.Text)








        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



        Con.Close()


        MsgBox("The Employee Has Clocked In Successfully!!")
    End Sub

End Class