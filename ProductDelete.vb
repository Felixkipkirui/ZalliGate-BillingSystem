Imports System.IO
Imports MySql.Data.MySqlClient
Public Class ProductDelete
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Private Sub ProductUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_fooddata()

    End Sub


    Sub Load_fooddata()
        Dim query As String = "SELECT ProductCode, ProductName FROM product"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the SQL command to prevent SQL injection
                'command.Parameters.AddWithValue("@SelectedValue", selectedValue)

                Try
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(query, connection)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        ProductDGV.DataSource = dataTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Sub ProdName()
        ' Construct your SQL query
        Dim query As String = "SELECT ProductName FROM product WHERE ProductCode = '" & txtSearch.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtProductName.Text = result.ToString()
                    Else
                        txtProductName.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Sub Price()
        ' Construct your SQL query
        Dim query As String = "SELECT UnitPrice FROM product WHERE ProductCode = '" & txtSearch.Text & "'"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the SQL query and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Set the text property of the text box with the result
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        txtUnitPrice.Text = result.ToString()
                    Else
                        txtUnitPrice.Text = "No data found."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ProdName()
        Price()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtProductName.Text = "" Or txtUnitPrice.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `product` WHERE `ProductCode`=@foodcode", Con)
                cmd.Parameters.Clear()


                cmd.Parameters.AddWithValue("@foodcode", txtSearch.Text)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Food Delete Successfully !", vbInformation, "FAST FOOD")
                Else
                    MsgBox("Warning : Food Delete Failed !", vbCritical, "FAST FOOD")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Con.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Location.Y >= YLocation Then
            Timer1.Stop()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        End If
    End Sub
End Class