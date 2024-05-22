Imports System.IO
Imports MySql.Data.MySqlClient
Imports DGVPrinterHelper
Public Class Orders
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        StartDatePicker.Value = DateTime.Today
        EndDatePicker.Value = DateTime.Today
        TodaysOrders()
        Pending()
        TodaysTOT()
        TodaysMax()
        loadinfo()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Sub TodaysOrders()
        ' Construct your SQL query
        Dim query As String = "SELECT COUNT(*) FROM orders WHERE TransactionDate = '" & lblDate.Text & "'"

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
    Sub Pending()
        ' Construct your SQL query
        Dim query As String = "SELECT COUNT(*) FROM orders WHERE Stage = 'PENDING'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblPending.Text = result.ToString()
                    Else
                        lblPending.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub TodaysTOT()
        ' Construct your SQL query
        Dim query As String = "SELECT SUM(TotalPrice) FROM orders WHERE TransactionDate = '" & lblDate.Text & "'"

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
        Dim query As String = "SELECT MAX(GrandTotal) FROM orders WHERE TransactionDate = '" & lblDate.Text & "'"

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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If cmbShift.SelectedIndex <> -1 Then
            Dim dTable As New DataTable()
            Dim StartSelectedDate As DateTime = StartDatePicker.Value
            Dim EndSelectedDate As DateTime = EndDatePicker.Value

            Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
            Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

            Dim query As String = "SELECT TransactionNo, TransactionDate, ProductName, UnitPrice, Qty, TotalPrice, ServedBy, Stage FROM orders WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the SQL command to prevent SQL injection
                    'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                    Try
                        connection.Open()
                        Using adapter As New MySqlDataAdapter(query, connection)

                            adapter.Fill(dTable)
                            CartDGV.DataSource = dTable
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End Using

            Dim total As Double
            For i As Integer = 0 To CartDGV.RowCount - 2
                total += CartDGV.Rows(i).Cells(5).Value
            Next

            dTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "GRAND-TOTAL", total)
            For Each row As DataGridViewRow In CartDGV.Rows
                If row.Index = CartDGV.Rows.Count - 2 Then
                    row.DefaultCellStyle.BackColor = Color.Green
                    row.DefaultCellStyle.ForeColor = Color.White
                    Dim font1 As Font = New Font("Arial", 12, FontStyle.Bold)
                    row.DefaultCellStyle.Font = font1
                End If
            Next


            Trans()
            Totalx()
            Max()
            PendingN()







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

        Dim query As String = "SELECT COUNT(*) FROM orders WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

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
    Sub Totalx()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT SUM(TotalPrice) FROM orders WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

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

        Dim query As String = "SELECT MAX(GrandTotal) FROM orders WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

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
    Sub PendingN()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT COUNT(*) FROM orders WHERE Stage = 'PENDING' AND WorkShift = '" & cmbShift.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblPending.Text = result.ToString()
                    Else
                        lblPending.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub loadinfo()
        Dim dTable As New DataTable()
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")
        Dim query As String = "SELECT TransactionNo, TransactionDate, ProductName, UnitPrice, Qty, TotalPrice, ServedBy, Stage, WorkShift FROM orders WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)

                        adapter.Fill(dTable)
                        CartDGV.DataSource = dTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Dim total As Double
        For i As Integer = 0 To CartDGV.RowCount - 2
            total += CartDGV.Rows(i).Cells(5).Value
        Next

        dTable.Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "GRAND-TOTAL", total)
        For Each row As DataGridViewRow In CartDGV.Rows
            If row.Index = CartDGV.Rows.Count - 2 Then
                row.DefaultCellStyle.BackColor = Color.Green
                row.DefaultCellStyle.ForeColor = Color.White
                Dim font1 As Font = New Font("Arial", 12, FontStyle.Bold)
                row.DefaultCellStyle.Font = font1
            End If
        Next

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        OrderSearch.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AdminDashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Printer = New DGVPrinter
        Printer.Title = "LOA HOTEL,TENWEK"
        Printer.SubTitle = "Order Report For: " & StartDatePicker.Value & " - " & EndDatePicker.Value & vbCrLf & "Work Shift: " & cmbShift.Text
        Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
        Printer.PageNumbers = True
        Printer.PageNumberInHeader = False
        Printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth

        Printer.HeaderCellAlignment = StringAlignment.Near
        Printer.Footer = "N.B: ALL CURRENCY VALUES ARE IN KENYA SHILLINGS"
        Printer.FooterSpacing = 15
        Printer.PrintDataGridView(Me.CartDGV)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        AdminDashboard.Show()
        Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        TransactionFrm.Show()
        Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        ProductSale.Show()
        Close()

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class