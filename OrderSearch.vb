Imports System.IO
Imports MySql.Data.MySqlClient
Public Class OrderSearch
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Sub loadinfo()
        Dim query As String = "SELECT * FROM orders WHERE TransactionNo = '" & txtTransNo.Text & "'"

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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtTransNo.Text = "" Then
            MsgBox("Missing Information")
        Else
            loadinfo()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Orders.Show()
        Me.Close()
    End Sub
End Class