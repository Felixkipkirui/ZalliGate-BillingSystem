Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CatUpdate
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
    Sub Load_fooddata()
        Dim query As String = "SELECT CatCode, CatName FROM category"

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

    Private Sub CatUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_fooddata()

    End Sub
    Sub ProdName()
        ' Construct your SQL query
        Dim query As String = "SELECT CatName FROM category WHERE CatCode = '" & txtSearch.Text & "'"

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
        Dim query As String = "SELECT Description FROM category WHERE CatCode = '" & txtSearch.Text & "'"

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtProductName.Text = "" Or txtUnitPrice.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim cmd As New MySqlCommand("UPDATE `category` SET `CatName`=@foodname,`Description`=@price  WHERE `CatCode`=@foodcode", Con)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@foodname", txtProductName.Text)
                cmd.Parameters.AddWithValue("@price", txtUnitPrice.Text)
                cmd.Parameters.AddWithValue("@foodcode", txtSearch.Text)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Category Edit Successfully !", vbInformation, "FAST FOOD")
                Else
                    MsgBox("Warning : Category Edit Failed !", vbCritical, "FAST FOOD")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Con.Close()
            txtProductName.Text = ""
            txtSearch.Text = ""
            txtUnitPrice.Text = ""
            Categories.Load_fooddata()
            Load_fooddata()

        End If
    End Sub
End Class