Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Imports DGVPrinterHelper
Public Class Shift1AttendanceReport
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub Shift2AttendanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartDatePicker.Value = DateTime.Today
        EndDatePicker.Value = DateTime.Today
    End Sub
    Sub LoadGrid()
        Dim dTable As New DataTable()
        Dim StartSelectedDate As DateTime = StartDatePicker.Value
        Dim EndSelectedDate As DateTime = EndDatePicker.Value

        Dim StartFormatted As String = StartSelectedDate.ToString("yyyy-MM-dd")
        Dim EndFormatted As String = EndSelectedDate.ToString("yyyy-MM-dd")

        Dim query As String = "SELECT StaffID, StaffName, Username, Date, WorkShift, sum(TotalHours) as 'Work Hours' FROM attendance WHERE Date BETWEEN '" & StartFormatted & "' AND '" & EndFormatted & "' AND WorkShift = 'SHIFT-1' GROUP by StaffID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)

                        adapter.Fill(dTable)
                        AttendanceDGV.DataSource = dTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadGrid()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Printer = New DGVPrinter
        Printer.Title = "LOA HOTEL,TENWEK"
        Printer.SubTitle = "Shift-1 Attendance Report For: " & StartDatePicker.Value & " - " & EndDatePicker.Value
        Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
        Printer.PageNumbers = True
        Printer.PageNumberInHeader = False
        Printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth

        Printer.HeaderCellAlignment = StringAlignment.Near
        Printer.Footer = "N.B ALL CURRENCY VALUES ARE IN KENYA SHILLINGS"
        Printer.FooterSpacing = 15
        Printer.PrintDataGridView(Me.AttendanceDGV)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub
End Class