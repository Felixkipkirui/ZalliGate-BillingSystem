Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class CheckOutPop2
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub CheckOutPop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        FillComboBox()


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
        attendance()
        Clockin()

        txtCheckOut.Text = lblMyTime.Text

        'Dim starttime As DateTime = DateTime.Parse(txtCheckIn.Text)
        'Dim endtime As DateTime = DateTime.Parse(txtCheckOut.Text)



        Dim diff = Val(txtCheckOut.Text) - Val(txtCheckIn.Text)
        'Dim totalh As Integer = diff.TotalHours

        txtHours.Text = diff

        If txtCheckIn.Text = "No data found." Then
            txtStatus.Text = "ABSENT"
        Else
            txtStatus.Text = "PRESENT"

        End If



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

    Sub attendance()
        ' Construct your SQL query
        Dim query As String = "SELECT AttendanceID FROM attendance WHERE Username = '" & cmbServedBy.Text & "' AND Date = '" & lblDate.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        AttID.Text = result.ToString()
                    Else
                        AttID.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub Clockin()
        ' Construct your SQL query
        Dim query As String = "SELECT CheckInTime FROM attendance WHERE Username = '" & cmbServedBy.Text & "' AND Date = '" & lblDate.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtCheckIn.Text = result.ToString()
                    Else
                        txtCheckIn.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click

        If AttID.Text = "No data found" Then
            MsgBox("Employee  Clock Out Failed", vbCritical, "ZalliGate PLC")
        Else
            ExecuteQuery1()
            AttID.Text = ""
            txtStaffID.Text = ""
            txtName.Text = ""
            txtCheckIn.Text = ""
            txtCheckOut.Text = ""
            txtHours.Text = ""
            txtStatus.Text = ""
            Close()

        End If




    End Sub

    Sub ExecuteQuery1()
        ' Construct and execute the first SQL query
        Dim query1 As String = "UPDATE attendance SET CheckOutTime = @checkout, TotalHours = @hours, Status = @status WHERE AttendanceID = @attid"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query1, connection)
                Try

                    command.Parameters.AddWithValue("@attid", AttID.Text)
                    command.Parameters.AddWithValue("@checkout", txtCheckOut.Text)
                    command.Parameters.AddWithValue("@hours", txtHours.Text)
                    command.Parameters.AddWithValue("@status", txtStatus.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox("Employee For SHIFT-2 Has Clocked Out Successfully", vbInformation, "ZalliGate PLC")

                Catch ex As Exception
                    MessageBox.Show("Error executing Query 1: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub ExecuteQuery2()
        ' Construct and execute the second SQL query
        Dim query2 As String = "UPDATE orders SET Stage = 'COMPLETED' WHERE TransactionNo = '" & CheckOut.cmbOrder.Text & "'"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query2, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error executing Query 2: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class