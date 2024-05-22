Imports System.IO
Imports MySql.Data.MySqlClient
Public Class TransactionPerIndividual
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub TransactionPerIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        StartDatePicker.Value = DateTime.Today
        EndDatePicker.Value = DateTime.Today
        FillComboBox()
        'loadinfo()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Sub FillComboBox()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Username FROM customerDesk"
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
    Sub TodaysSales()
        ' Construct your SQL query


        Dim query As String = "Select SUM(TotalPrice) FROM orders WHERE ServedBy = '" & cmbServedBy.Text & "' AND TransactionDate = '" & lblDate.Text & "'"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblToday.Text = result.ToString()
                    Else
                        lblToday.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub TotalSales()
        ' Construct your SQL query

        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")


        Dim query As String = "Select SUM(TotalPrice) FROM orders WHERE ServedBy = '" & cmbServedBy.Text & "' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "'"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblTotal.Text = result.ToString()
                    Else
                        lblTotal.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub loadinfo()
        Dim query As String = "SELECT * FROM orders LIMIT 300"

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
    Sub loadinfostaff()
        Dim query As String = "SELECT * FROM orders WHERE ServedBy = '" & cmbServedBy.Text & "'"

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

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If cmbServedBy.SelectedIndex <> -1 Then

            TodaysSales()
            TotalSales()
            loadinfostaff()


        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please select a value from the combo box.")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TransactionFrm.Show()
        Me.Hide()

    End Sub

    Private Sub cmbServedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServedBy.SelectedIndexChanged

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class