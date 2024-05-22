Imports System.IO
Imports MySql.Data.MySqlClient
Public Class AdminDashboard
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()
        TotalProd()
        Cat()
        Sale()
        Transactions()
        Load_fooddata()
        trans()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Sub TotalProd()
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
                        lblTotalProd.Text = result.ToString()
                    Else
                        lblTotalProd.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub Cat()
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
                        lblCat.Text = result.ToString()
                    Else
                        lblCat.Text = "No data found."
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub Sale()
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
                        lblSale.Text = result.ToString()
                    Else
                        lblSale.Text = "No data found."
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub Transactions()
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
                        lblTrans.Text = result.ToString()
                    Else
                        lblTrans.Text = "No data found."
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub Load_fooddata()
        Dim query As String = "SELECT ProductCode, Qty, TotalPrice, ServedBy, Stage FROM orders LIMIT 20"

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

    Sub trans()
        Dim query As String = "SELECT TransactionNo, Recieved, Balance PaymentMode, RecievedBy FROM transactions LIMIT 20"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        TransactionsDGV.DataSource = dataTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        POS.Show()
        Me.Hide()

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Categories.Show()
        Me.Hide()

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Products.Show()
        Me.Hide()

    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs)
        Orders.Show()
        Me.Close()

    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton4_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        TransactionFrm.Show()
        Me.Close()


    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub GunaAdvenceButton5_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        Orders.Show()
        Me.Close()

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        ProductSale.Show()
        Me.Hide()

    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        MyAttendance.Show()
        Close()

    End Sub
End Class