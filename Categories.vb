Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Categories
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")

    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub btnNewProd_Click(sender As Object, e As EventArgs) Handles btnNewProd.Click
        Dim frm As New CatPopUp
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frm As New CatUpdate
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim frm As New CatDelete
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        TransaparentBG.ShowForm(frm)
    End Sub

    Sub Load_fooddata()
        DataGridView1.Rows.Clear()
        Try
            Con.Open()
            cmd = New MySqlCommand("SELECT * FROM `category`", Con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("CatCode"), dr.Item("CatName"), dr.Item("Description"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
    End Sub

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_fooddata()
        Total()
        TotalCat()
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()


    End Sub
    Sub Total()
        ' Construct your SQL query
        Dim query As String = "SELECT COUNT(*) FROM product"

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
    Sub TotalCat()
        ' Construct your SQL query
        Dim query As String = "SELECT COUNT(*) FROM category"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblCategories.Text = result.ToString()
                    Else
                        lblCategories.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AdminDashboard.Show()
        Me.Close()

    End Sub
End Class