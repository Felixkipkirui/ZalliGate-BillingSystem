Imports System.IO
Imports MySql.Data.MySqlClient
Public Class ProductsPopUp
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Private Sub Open_Timer_Tick(sender As Object, e As EventArgs) Handles Open_Timer.Tick
        If Me.Location.Y >= YLocation Then
            Open_Timer.Stop()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnImagePick_Click(sender As Object, e As EventArgs) Handles btnImagePick.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pic_foodimg.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Sub auto_foodcode()
        Try
            Con.Open()
            cmd = New MySqlCommand("SELECT * FROM `product` order by ProductID desc", Con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txtProductCode.Text = dr.Item("ProductCode").ToString + 1

            Else
                txtProductCode.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
    End Sub

    Private Sub ProductsPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto_foodcode()


    End Sub
    Sub clear()
        txtProdName.Clear()
        txtProdPrice.Clear()
        pic_foodimg.Image = Nothing
    End Sub

    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        Try
            Con.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `product`(`ProductCode`, `ProductName`, `UnitPrice`, `Img`) VALUES (@foodcode,@foodname,@price,@img)", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@foodcode", txtProductCode.Text)
            cmd.Parameters.AddWithValue("@foodname", txtProdName.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txtProdPrice.Text))
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_foodimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Product Saved Successfully !", vbInformation, "ZalliGate PLC")
            Else
                MsgBox("Warning : Product Save Failed !", vbCritical, "ZalliGate PLC")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
        clear()
        auto_foodcode()
        Products.Load_fooddata()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label5.Click

    End Sub

    Private Sub txtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged

    End Sub

    Private Sub txtProdName_TextChanged(sender As Object, e As EventArgs) Handles txtProdName.TextChanged

    End Sub

    Private Sub txtProdPrice_TextChanged(sender As Object, e As EventArgs) Handles txtProdPrice.TextChanged

    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged

    End Sub

    Private Sub pic_foodimg_Click(sender As Object, e As EventArgs) Handles pic_foodimg.Click

    End Sub
End Class