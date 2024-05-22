Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Imports DGVPrinterHelper
Public Class MyAttendance
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub btnShift1_Click(sender As Object, e As EventArgs) Handles btnShift1.Click
        AttendanceModule.Show()
        Close()

    End Sub

    Private Sub btnShift2_Click(sender As Object, e As EventArgs) Handles btnShift2.Click
        AttendanceModule2.Show()
        Close()

    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub MyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()

        TotalProd()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Sub TotalProd()
        ' Construct your SQL query
        Dim query As String = "SELECT COUNT(*) FROM staff"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblStaff.Text = result.ToString()
                    Else
                        lblStaff.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        POS.Show()
        Close()

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        AdminDashboard.Show()
        Close()

    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        LoginForm.Show()
        Close()

    End Sub
End Class