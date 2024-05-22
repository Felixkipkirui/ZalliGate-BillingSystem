Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CatPopUp
    Dim WorkingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 3
    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub Open_Timer_Tick(sender As Object, e As EventArgs) Handles Open_Timer.Tick
        If Me.Location.Y >= YLocation Then
            Open_Timer.Stop()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        End If
    End Sub

    Sub auto_foodcode()
        Try
            Con.Open()
            cmd = New MySqlCommand("SELECT * FROM `category` order by CatID desc", Con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txtProductCode.Text = dr.Item("CatCode").ToString + 1

            Else
                txtProductCode.Text = Date.Now.ToString("yyyy") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
    End Sub

    Private Sub CatPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto_foodcode()
    End Sub

    Sub clear()
        txtProdName.Clear()
        txtProdPrice.Clear()

    End Sub

    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        Try
            Con.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `category`(`CatCode`, `CatName`, `Description`) VALUES (@foodcode,@foodname,@price)", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@foodcode", txtProductCode.Text)
            cmd.Parameters.AddWithValue("@foodname", txtProdName.Text)
            cmd.Parameters.AddWithValue("@price", txtProdPrice.Text)


            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Category Save Successfully !", vbInformation, "ZalliGate PLC")
            Else
                MsgBox("Warning : Category Save Failed !", vbCritical, "ZalliGate PLC")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
        clear()
        auto_foodcode()
        Categories.Load_fooddata()
    End Sub
End Class