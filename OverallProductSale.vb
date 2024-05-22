Imports System.IO
Imports MySql.Data.MySqlClient
Imports DGVPrinterHelper
Public Class OverallProductSale
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Private Sub OverallProductSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        StartDatePicker.Value = DateTime.Today
        EndDatePicker.Value = DateTime.Today


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Sub LoadGridA()
        Dim dTable As New DataTable()
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT ProductCode, ProductName, sum(TotalPrice) AS 'Grand-Total', Floor((sum(TotalPrice))/UnitPrice) as 'Total-QTY' from orders WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' GROUP BY ProductCode"

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
        Dim total As Double
        Dim totalQ As Double
        For i As Integer = 0 To TransDGV.RowCount - 2
            total += TransDGV.Rows(i).Cells(3).Value
            totalQ += TransDGV.Rows(i).Cells(2).Value
        Next

        dTable.Rows.Add(Nothing, Nothing, totalQ, total)
        For Each row As DataGridViewRow In TransDGV.Rows
            If row.Index = TransDGV.Rows.Count - 2 Then
                row.DefaultCellStyle.BackColor = Color.Green
                row.DefaultCellStyle.ForeColor = Color.White
                Dim font1 As Font = New Font("Arial", 12, FontStyle.Bold)
                row.DefaultCellStyle.Font = font1
            End If
        Next


    End Sub

    Sub LoadGrid()
        Dim dTable As New DataTable()
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT ProductCode, ProductName, sum(TotalPrice) AS 'Grand-Total', Floor((sum(TotalPrice))/UnitPrice) as 'Total-QTY' from orders WHERE TransactionDate BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = '" & cmbShift.Text & "' GROUP BY ProductCode"

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
        Dim total As Double
        Dim totalQ As Double
        For i As Integer = 0 To TransDGV.RowCount - 2
            total += TransDGV.Rows(i).Cells(3).Value
            totalQ += TransDGV.Rows(i).Cells(2).Value
        Next

        dTable.Rows.Add(Nothing, Nothing, totalQ, total)
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
            LoadGrid()
            'LoadGridA()






        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please Select The Work Shift From The Combo Box")
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim Printer = New DGVPrinter
        Printer.Title = "LOA HOTEL,TENWEK"
        Printer.SubTitle = "Overall Product Sales Summary For: " & StartDatePicker.Value & " - " & EndDatePicker.Value & vbCrLf & "Work-Shift Session: " & cmbShift.Text
        Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
        Printer.PageNumbers = True
        Printer.PageNumberInHeader = False
        Printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth

        Printer.HeaderCellAlignment = StringAlignment.Near
        Printer.Footer = "N.B ALL CURRENCY VALUES ARE IN KENYA SHILLINGS"
        Printer.FooterSpacing = 15
        Printer.PrintDataGridView(Me.TransDGV)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ProductSale.Show()
        Me.Close()

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        AdminDashboard.Show()
        Me.Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        TransactionFrm.Show()
        Me.Close()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Orders.Show()
        Me.Close()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub StartDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles StartDatePicker.ValueChanged

    End Sub
End Class