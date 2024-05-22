Imports System.IO
Imports MySql.Data.MySqlClient
Imports DGVPrinterHelper
Public Class TransactionFrm
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        StartDatePicker.Value = DateTime.Today
        EndDatePicker.Value = DateTime.Today
        TodaysTrans()
        TodaysTotal()
        TodaysMax()
        TodaysMin()
        loadinfo()




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Sub TodaysTrans()
        ' Construct your SQL query
        Dim query As String = "SELECT COUNT(*) FROM transactions WHERE TransactionDate = '" & lblDate.Text & "'"

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
    Sub TodaysTotal()
        ' Construct your SQL query
        Dim query As String = "SELECT SUM(GrandTotal) FROM transactions WHERE TransactionDate = '" & lblDate.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblTOT.Text = result.ToString()
                    Else
                        lblTOT.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub TodaysMax()
        ' Construct your SQL query
        Dim query As String = "SELECT MAX(GrandTotal) FROM transactions WHERE TransactionDate = '" & lblDate.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblMax.Text = result.ToString()
                    Else
                        lblMax.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub TodaysMin()
        ' Construct your SQL query
        Dim query As String = "SELECT MIN(GrandTotal) FROM transactions WHERE TransactionDate = '" & lblDate.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblMin.Text = result.ToString()
                    Else
                        lblMin.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If cmbShift.SelectedIndex <> -1 Then

            Dim dTable As New DataTable()

            Dim StartSelectedDate As DateTime = StartDatePicker.Value
            Dim EndSelectedDate As DateTime = EndDatePicker.Value

            Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
            Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

            Dim query As String = "SELECT TransactionNo, GrandTotal, Recieved, Balance, PaymentMode, RecievedBy, DateTime FROM transactions WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the SQL command to prevent SQL injection
                    'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                    Try
                        connection.Open()
                        Using adapter As New MySqlDataAdapter(query, connection)

                            adapter.Fill(dTable)
                            TransDGV.DataSource = dTable
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End Using
            Dim totalA As Double
            Dim totalb As Double
            Dim totalc As Double
            For i As Integer = 0 To TransDGV.RowCount - 2
                totalA += TransDGV.Rows(i).Cells(1).Value
                totalb += TransDGV.Rows(i).Cells(2).Value
                totalc += TransDGV.Rows(i).Cells(3).Value
            Next

            dTable.Rows.Add(Nothing, totalA, totalb, totalc, Nothing, Nothing, Nothing)
            For Each row As DataGridViewRow In TransDGV.Rows
                If row.Index = TransDGV.Rows.Count - 2 Then
                    row.DefaultCellStyle.BackColor = Color.Green
                    row.DefaultCellStyle.ForeColor = Color.White
                    Dim font1 As Font = New Font("Arial", 12, FontStyle.Bold)
                    row.DefaultCellStyle.Font = font1
                End If
            Next

            Trans()
            Total()
            Max()
            Min()






        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please Select The Work Shift From The Combo Box")
        End If




    End Sub

    Sub Trans()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT COUNT(*) FROM transactions WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

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
    Sub Total()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT SUM(GrandTotal) FROM transactions WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblTOT.Text = result.ToString()
                    Else
                        lblTOT.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub Max()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT MAX(GrandTotal) FROM transactions WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblMax.Text = result.ToString()
                    Else
                        lblMax.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub Min()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT MIN(GrandTotal) FROM transactions WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblMin.Text = result.ToString()
                    Else
                        lblMin.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub loadinfo()
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")
        Dim dTable As New DataTable()
        Dim query As String = "SELECT TransactionNo, GrandTotal, Recieved, Balance, PaymentMode, RecievedBy, DateTime FROM transactions WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)

                        adapter.Fill(dTable)
                        TransDGV.DataSource = dTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Dim totalA As Double
        Dim totalb As Double
        Dim totalc As Double

        For i As Integer = 0 To TransDGV.RowCount - 2

            totalA += TransDGV.Rows(i).Cells(1).Value
            totalb += TransDGV.Rows(i).Cells(2).Value
            totalc += TransDGV.Rows(i).Cells(3).Value
        Next

        dTable.Rows.Add(Nothing, totalA, totalb, totalc, Nothing, Nothing, Nothing)
        For Each row As DataGridViewRow In TransDGV.Rows
            If row.Index = TransDGV.Rows.Count - 2 Then
                row.DefaultCellStyle.BackColor = Color.Green
                row.DefaultCellStyle.ForeColor = Color.White
                Dim font1 As Font = New Font("Arial", 12, FontStyle.Bold)
                row.DefaultCellStyle.Font = font1
            End If
        Next

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        TransactionsSearch.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        TransactionsPerMode.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TransactionPerIndividual.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        AdminDashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Printer = New DGVPrinter
        Printer.Title = "LOA HOTEL,TENWEK"
        Printer.SubTitle = "Transaction Report For: " & StartDatePicker.Value & " - " & EndDatePicker.Value & vbCrLf & "Work Shift: " & cmbShift.Text
        Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
        Printer.PageNumbers = True
        Printer.PageNumberInHeader = False
        Printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth

        Printer.HeaderCellAlignment = StringAlignment.Near
        Printer.Footer = "N.B: ALL CURRENCY VALUES ARE IN KENYA SHILLINGS"
        Printer.FooterSpacing = 15
        Printer.PrintDataGridView(Me.TransDGV)

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        CashTransactions.Show()
        Close()

    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        MobileMoneyTransactions.Show()
        Close()

    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        BankTransactions.Show()
        Close()

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        ElectronicTransactions.Show()
        Close()

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        TransactionRoll.Show()
        Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AdminDashboard.Show()
        Close()

    End Sub
End Class