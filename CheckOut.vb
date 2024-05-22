Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class CheckOut
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
    Sub FillComboBox()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT TransactionNo FROM orders WHERE Stage = 'PENDING' GROUP BY TransactionNo"
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbOrder.Items.Add(reader.GetString("TransactionNo"))
                    End While
                End Using
                connection.Close()

            End Using
        End Using
    End Sub

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboBox()
        Pending()
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Timer1.Interval = 1000
        Timer1.Start()

    End Sub

    Private Sub btnCheckOrder_Click(sender As Object, e As EventArgs) Handles btnCheckOrder.Click
        ' Check if a value is selected in the combo box
        If cmbOrder.SelectedIndex <> -1 Then

            Dim query As String = "SELECT * FROM orders WHERE TransactionNo = '" & cmbOrder.Text & "'"

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

        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please select a value from the combo box.")
        End If

    End Sub

    Private Sub SelectInfoFromDatabase(selectedValue As String)
        ' Construct your SQL query based on the selected value
        Dim query As String = "SELECT * FROM orders WHERE TransactionNo = '" & cmbOrder.SelectedValue.ToString & "'"

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

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        If cmbOrder.SelectedIndex <> -1 Then

            Dim frm As New ZalliGateCheckOut
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            TransaparentBG.ShowForm(frm)
            'frm.ShowDialog()





        Else
            ' Display an error message if nothing is selected from the combo box
            MessageBox.Show("Please select a value from the combo box.")
        End If
        Me.Refresh()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        POS.Show()
        Close()



    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        POS.Show()
        Close()

        FillComboBox()

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs)
        Categories.Show()
        Me.Hide()

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs)
        Products.Show()
        Me.Hide()

    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs)
        Orders.Show()
        Me.Hide()

    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton4_Click_1(sender As Object, e As EventArgs)
        TransactionFrm.Show()
        Me.Hide()


    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        LoginForm.Show()
        Me.Close()


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

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub

    Private Sub GunaAdvenceButton2_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        AdminDashboard.Show()
        Close()


    End Sub

    Private Sub CartDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CartDGV.CellContentClick

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
End Class