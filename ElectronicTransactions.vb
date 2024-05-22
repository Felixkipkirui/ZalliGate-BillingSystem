Imports System.IO
Imports MySql.Data.MySqlClient
Imports DGVPrinterHelper
Public Class ElectronicTransactions
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Sub CashTotal()
        ' Construct your SQL query
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT Sum(GrandTotal) FROM transactions WHERE PaymentMode = 'E-PAYMENT' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

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
    Sub Loadgrid()
        Dim dTable As New DataTable()

        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")
        Dim query As String = "SELECT TransactionNo, GrandTotal, Recieved, Balance, PaymentMode, RecievedBy, DateTime FROM transactions WHERE PaymentMode = 'E-PAYMENT' AND TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)
                        'Dim dTable As New DataTable()
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cmbShift.SelectedIndex <> -1 Then

            Loadgrid()
            CashTotal()


        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please Select The Work Shift From The Combo Box")
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Printer = New DGVPrinter
        Printer.Title = "LOA HOTEL,TENWEK"
        Printer.SubTitle = "Electronic Payment Transaction Report For: " & StartDatePicker.Value & " - " & EndDatePicker.Value & vbCrLf & "Work Shift: " & cmbShift.Text
        Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
        Printer.PageNumbers = True
        Printer.PageNumberInHeader = False
        Printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth

        Printer.HeaderCellAlignment = StringAlignment.Near
        Printer.Footer = "N.B: ALL CURRENCY VALUES ARE IN KENYA SHILLINGS"
        Printer.FooterSpacing = 15
        Printer.PrintDataGridView(Me.TransDGV)
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        TransactionFrm.Show()
        Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TransactionFrm.Show()
        Close()

    End Sub

    Private Sub ElectronicTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        StartDatePicker.Value = DateTime.Today
        EndDatePicker.Value = DateTime.Today
    End Sub
End Class