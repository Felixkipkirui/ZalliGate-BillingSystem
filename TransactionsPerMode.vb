Imports System.IO
Imports MySql.Data.MySqlClient
Public Class TransactionsPerMode
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Private Sub TransactionsPerMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        StartDatePicker.Value = DateTime.Today
        EndDatePicker.Value = DateTime.Today
        loadinfo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Sub loadinfo()
        Dim query As String = "SELECT * FROM transactions LIMIT 300"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        CartDGV.DataSource = dataTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub CashTotal()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT Sum(GrandTotal) FROM transactions WHERE PaymentMode = 'CASH-AT-HAND' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblCash.Text = result.ToString()
                    Else
                        lblCash.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If cmbMode.SelectedIndex <> -1 Then

            loadinfo_MODE()




        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please select a value from the combo box.")
        End If
    End Sub
    Sub MobileTotal()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT Sum(GrandTotal) FROM transactions WHERE PaymentMode = 'MOBILE MONEY' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblmobile.Text = result.ToString()
                    Else
                        lblmobile.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub BankTotal()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT Sum(GrandTotal) FROM transactions WHERE PaymentMode = 'BANK TRANSFER' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblbank.Text = result.ToString()
                    Else
                        lblbank.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub ETotal()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT Sum(GrandTotal) FROM transactions WHERE PaymentMode = 'E-PAYMENT' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblE.Text = result.ToString()
                    Else
                        lblE.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnCheckCash_Click(sender As Object, e As EventArgs) Handles btnCheckCash.Click
        CashTotal()
    End Sub

    Private Sub btnCheckMobile_Click(sender As Object, e As EventArgs) Handles btnCheckMobile.Click
        MobileTotal()

    End Sub

    Private Sub btnCheckBank_Click(sender As Object, e As EventArgs) Handles btnCheckBank.Click
        BankTotal()

    End Sub

    Private Sub btnCheckE_Click(sender As Object, e As EventArgs) Handles btnCheckE.Click
        ETotal()

    End Sub
    Sub loadinfo_MODE()
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")
        Dim query As String = "SELECT * FROM transactions WHERE PaymentMode = '" & cmbMode.Text & "' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        CartDGV.DataSource = dataTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TransactionFrm.Show()
        Me.Hide()

    End Sub
End Class