Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class ZalliGateCheckOut
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Private Sub ZalliGateCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoTextBox()
        LoadDataIntoTextBox2()
        Stage()
        FillComboBox()
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        CheckOut.FillComboBox()


    End Sub

    Sub LoadDataIntoTextBox()
        ' Construct your SQL query
        Dim query As String = "SELECT GrandTotal FROM orders WHERE TransactionNo = '" & CheckOut.cmbOrder.Text & "' GROUP BY TransactionNo"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtGrandTotal.Text = result.ToString()
                    Else
                        txtGrandTotal.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub LoadDataIntoTextBox2()
        ' Construct your SQL query
        Dim query As String = "SELECT WorkShift FROM orders WHERE TransactionNo = '" & CheckOut.cmbOrder.Text & "' GROUP BY TransactionNo"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtShift.Text = result.ToString()
                    Else
                        txtShift.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Sub Stage()
        ' Construct your SQL query
        Dim query As String = "SELECT Stage FROM orders WHERE TransactionNo = '" & CheckOut.cmbOrder.Text & "' GROUP BY TransactionNo"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtStage.Text = result.ToString()
                    Else
                        txtStage.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub txtRecieved_TextChanged(sender As Object, e As EventArgs) Handles txtRecieved.TextChanged
        txtBalance.Text = Val(txtRecieved.Text) - Val(txtGrandTotal.Text)
    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged
        If Val(txtBalance.Text) >= 0 Then
            txtStage.Text = "COMPLETED"
        Else
            txtStage.Text = "PENDING"
        End If
    End Sub

    Sub FillComboBox()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Username FROM staff"
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbStaff.Items.Add(reader.GetString("Username"))
                    End While
                End Using
                connection.Close()

            End Using
        End Using
    End Sub

    Sub ExecuteQuery1()
        ' Construct and execute the first SQL query
        Dim query1 As String = "INSERT INTO `transactions`(`TransactionNo`, `TransactionDate`, `GrandTotal`, `Recieved`, `Balance`, `PaymentMode`, `RecievedBy`, `Description`, `WorkShift`) VALUES (@transno,@transdate,@grandtotal,@recieved,@balance,@paymentmode,@recievedby,@description,@shift)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query1, connection)
                Try

                    command.Parameters.AddWithValue("@transno", CheckOut.cmbOrder.Text)
                    command.Parameters.AddWithValue("@transdate", CDate(lblDate.Text))
                    command.Parameters.AddWithValue("@grandtotal", txtGrandTotal.Text)
                    command.Parameters.AddWithValue("@recieved", txtRecieved.Text)
                    command.Parameters.AddWithValue("@balance", txtBalance.Text)
                    command.Parameters.AddWithValue("@paymentmode", cmbMode.Text)
                    command.Parameters.AddWithValue("@recievedby", cmbStaff.Text)
                    command.Parameters.AddWithValue("@description", txtDescription.Text)
                    command.Parameters.AddWithValue("@shift", txtShift.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox("TRANSACTION COMPLETED SUCCESFULLY")

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

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ExecuteQuery1()
        ExecuteQuery2()
        txtGrandTotal.Text = ""
        txtRecieved.Text = ""
        txtBalance.Text = ""
        txtStage.Text = ""

        POS.Show()
        CheckOut.Close()
        Me.Close()






    End Sub

    Private Sub Open_Timer_Tick(sender As Object, e As EventArgs) Handles Open_Timer.Tick
        If Me.Location.Y >= YLocation Then
            Open_Timer.Stop()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        End If
    End Sub

    Private Sub GunaLabel8_Click(sender As Object, e As EventArgs) Handles GunaLabel8.Click

    End Sub
End Class