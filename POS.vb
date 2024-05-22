Imports MySql.Data.MySqlClient

Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Public Class POS
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Dim Con As New MySqlConnection("Data Source=localhost;database=zalligatedb;username=root")
    Dim connectionString As String = "Data Source=localhost;database=zalligatedb;username=root"
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents foodcode As Label
    Private WithEvents foodname As Label
    Private WithEvents Price As Label

    Private WithEvents img As CirclePicturBox
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 350
    End Sub
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_Foods()
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        auto_Transno()
        Get_grandTotal()
        Get_pricedata()
        FillComboBox()
        Timer1.Interval = 1000
        Timer1.Start()


    End Sub
    Sub auto_Transno()
        Try
            Con.Open()
            cmd = New MySqlCommand("SELECT * FROM `orders` order by OrderID desc", Con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                lblAutoNumber.Text = dr.Item("TransactionNo").ToString + 1

            Else
                lblAutoNumber.Text = Date.Now.ToString("yyyyMMdd") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
    End Sub

    Sub Load_controls()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))


        pan = New Panel
        With pan
            .Width = 150
            .Height = 210
            .BackColor = Color.FromArgb(40, 40, 40)
            .Tag = dr.Item("ProductCode").ToString
        End With
        pan_top = New Panel
        With pan_top
            .Width = 150
            .Height = 10
            .BackColor = Color.FromArgb(40, 40, 40)
            .Dock = DockStyle.Top
            .Tag = dr.Item("ProductCode").ToString
        End With

        img = New CirclePicturBox
        With img
            .Height = 120
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = dr.Item("ProductCode").ToString
        End With

        foodcode = New Label
        With foodcode
            .ForeColor = Color.Orange
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("ProductCode").ToString
        End With
        foodname = New Label
        With foodname
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("ProductCode").ToString
        End With

        Price = New Label
        With Price
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("ProductCode").ToString
        End With

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        img.BackgroundImage = bitmap

        foodcode.Text = " Product Code   : " & dr.Item("ProductCode").ToString
        foodname.Text = " Product Name  : " & dr.Item("ProductName").ToString
        Price.Text = " Price              : KSH " & dr.Item("UnitPrice").ToString

        pan.Controls.Add(Price)
        pan.Controls.Add(foodname)
        pan.Controls.Add(foodcode)
        pan.Controls.Add(img)


        pan.Controls.Add(pan_top)
        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler foodcode.Click, AddressOf Selectimg_Click
        AddHandler foodname.Click, AddressOf Selectimg_Click
        AddHandler Price.Click, AddressOf Selectimg_Click
        AddHandler img.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub

    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        Con.Open()
        Try
            cmd = New MySqlCommand("SELECT `ProductCode`, `ProductName`, `UnitPrice` FROM `product` WHERE `ProductCode` like '" & sender.tag.ToString & "%' ", Con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
                For Each itm As DataGridViewRow In DataGridView1.Rows
                    If itm.Cells(1).Value IsNot Nothing Then
                        If itm.Cells(1).Value.ToString = dr.Item("ProductCode") Then
                            exist = True
                            numrow = itm.Index
                            numtext = CInt(itm.Cells(4).Value)
                            Exit For
                        End If
                    End If
                Next
                If exist = False Then
                    Dim price As Decimal = dr("UnitPrice")
                    Dim subtotalprice As Double
                    subtotalprice = price * 1
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ProductCode"), dr.Item("ProductName"), dr.Item("UnitPrice"), 1, subtotalprice)
                Else
                    DataGridView1.Rows(numrow).Cells(4).Value = CInt("1") + numtext
                    DataGridView1.Rows(numrow).Cells(5).Value = DataGridView1.Rows(numrow).Cells(3).Value * DataGridView1.Rows(numrow).Cells(4).Value
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Dispose()
        Con.Close()
        Get_grandTotal()
        Get_pricedata()

    End Sub



    Sub Load_Foods()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            Con.Open()
            cmd = New MySqlCommand("SELECT `Img`, `ProductCode`, `ProductName`, `UnitPrice` FROM `product`", Con)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
    End Sub

    Sub Get_grandTotal()
        Try
            Dim grandtotal As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + DataGridView1.Rows(i).Cells(5).Value

            Next
            lblOverallTotal.Text = Format(CDec(grandtotal), "Ksh #,##0.00")
            lblGrandTotal.Text = Format(CDec(grandtotal), "Ksh #,##0.00")
            lblTot.Text = grandtotal
        Catch ex As Exception

        End Try
    End Sub

    Sub Get_pricedata()
        Try
            Dim noofProducts As Double = 0

            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                noofProducts = noofProducts + DataGridView1.Rows(i).Cells(4).Value

            Next
            lblNoOfProducts.Text = noofProducts
        Catch ex As Exception

        End Try
    End Sub



    Sub new_order()
        Load_Foods()
        DataGridView1.Rows.Clear()
        lblDate.Text = Date.Now.ToString("yyyy-MM-dd")
        auto_Transno()

    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        new_order()
        Get_grandTotal()
        Get_pricedata()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            Con.Open()
            cmd = New MySqlCommand("SELECT `Img`, `ProductCode`, `ProductName`, `UnitPrice` FROM `product` WHERE ProductCode like '%" & txt_search.Text & "%' or ProductName like '%" & txt_search.Text & "%' or UnitPrice like '%" & txt_search.Text & "%'", Con)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Con.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Con.Open()
            cmd = New MySqlCommand("INSERT INTO `orders`(`TransactionNo`, `TransactionDate`, `TransactionMonth`, `ProductCode`, `ProductName`, `UnitPrice`, `Qty`, `TotalPrice`, `GrandTotal`, `NoOfProducts`, `ServedBy`, WorkShift) VALUES (@transno,@transdate,@transmonth,@foodcode,@foodname,@price,@qty,@totalprice,@grandtotal,@nooffoods, @servedby,@shift)", Con)
            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@transno", lblAutoNumber.Text)
                cmd.Parameters.AddWithValue("@transdate", CDate(lblDate.Text))
                cmd.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))
                cmd.Parameters.AddWithValue("@foodcode", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@foodname", DataGridView1.Rows(j).Cells(2).Value)
                cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(3).Value)
                cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(4).Value)
                cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(5).Value)
                cmd.Parameters.AddWithValue("@grandtotal", lblTot.Text)
                cmd.Parameters.AddWithValue("@nooffoods", lblNoOfProducts.Text)
                cmd.Parameters.AddWithValue("@servedby", cmbServedBy.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@shift", lblSession.Text)
                i = cmd.ExecuteNonQuery
            Next






        Catch ex As Exception

        End Try



        Con.Close()



        MsgBox("The Order Has Been Saved Successfully To The Database. Invoice Generation on Process", vbInformation, "ZalliGate PLC")

        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()  'Direct Print

        new_order()




        MsgBox("The Order Has Been Completed Sucessfully.", vbInformation, "ZalliGate PLC")


        CheckOut.Show()
        Me.Hide()




    End Sub

    Private Sub cmbServedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServedBy.SelectedIndexChanged
        Get_grandTotal()
        Get_pricedata()
    End Sub

    Sub FillComboBox()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Username FROM customerDesk"
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbServedBy.Items.Add(reader.GetString("Username"))
                    End While
                End Using
                connection.Close()

            End Using
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMyDate.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy")
        lblMyTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub


    Private Sub PD_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------"

        e.Graphics.DrawString("LOA HOTEL", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("TEL: 0710374885", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("*****FISCAL RECIEPT*****", f10, Brushes.Black, centermargin, 55, center)



        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 15, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 75)
        e.Graphics.DrawString(lblAutoNumber.Text, f8, Brushes.Black, 95, 75)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 15, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 85)
        e.Graphics.DrawString("CASHIER-IN-CHARGE", f8, Brushes.Black, 85, 85)

        e.Graphics.DrawString(lblMyDate.Text, f8, Brushes.Black, 15, 95)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 15, 110)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 40, 110)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 165, 110, right)
        e.Graphics.DrawString("Total", f8, Brushes.Black, 220, 110, right)
        '
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)
        Dim height As Integer 'DGV Position
        'Dim i As Long
        DataGridView1.AllowUserToAddRows = False
        'If DataGridView1.CurrentCell.Value Is Nothing Then
        '    Exit Sub
        'Else
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 15, 115 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 40, 115 + height)
            'e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 180, 115 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 165, 115 + height, right)
            'e.Graphics.DrawString(DataGridView1.Rows(row).Cells(5).Value.ToString, f8, Brushes.Black, 25, 115 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(5).Value.ToString, f8, Brushes.Black, 220, 115 + height, right)

            'i = DataGridView1.Rows(row).Cells(4).Value
            'DataGridView1.Rows(row).Cells(4).Value = Format(i, "##,##0")
            'e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 180, 115 + height, right)

            'totalprice
            'Dim totalprice As Long
            'totalprice = Val(DataGridView1.Rows(row).Cells(1).Value * DataGridView1.Rows(row).Cells(2).Value)
            'e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, rightmargin, 115 + height, right)
            '

        Next
        'End If

        Dim height2 As Integer
        height2 = 145 + height
        'sumprice() 'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total Amount: " & lblGrandTotal.Text, f10b, Brushes.Black, 220, 25 + height2, right)
        e.Graphics.DrawString("Served By: " & cmbServedBy.Text, f10b, Brushes.Black, 15, 50 + height2)
        e.Graphics.DrawString("Product QTY: " & lblNoOfProducts.Text, f10b, Brushes.Black, 15, 75 + height2)
        'e.Graphics.DrawString("Total: " & lblGrandTotal.Text, f10b, Brushes.Black, rightmargin, 70 + height2, right)
        e.Graphics.DrawString(lblNoOfProducts.Text, f10b, Brushes.Black, 15, 10 + height2)
        e.Graphics.DrawString(line, f8, Brushes.Black, 120, height2)

        'Barcode
        Dim gbarcode As New MessagingToolkit.Barcode.BarcodeEncoder
        Try
            Dim barcodeimage As Image
            barcodeimage = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, lblAutoNumber.Text))
            e.Graphics.DrawImage(barcodeimage, CInt((e.PageBounds.Width - 150) / 2), 100 + height2, 150, 35)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        e.Graphics.DrawString(line, f8, Brushes.Black, 160, height2)
        e.Graphics.DrawString("M-Pesa Till Number: 4247154", f10, Brushes.Black, centermargin, 130 + height2, center)
        e.Graphics.DrawString(lblMyTime.Text, f10, Brushes.Black, centermargin, 170 + height2, center)
        e.Graphics.DrawString("", f10, Brushes.Black, centermargin, 200 + height2, center)

    End Sub
    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice = countprice + Val(DataGridView1.Rows(rowitem).Cells(2).Value * DataGridView1.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice

        Dim countqty As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + DataGridView1.Rows(rowitem).Cells(1).Value
        Next
        t_qty = countqty
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        Dim msgRslt As MsgBoxResult = MsgBox("Have You Submitted The Order Before Generating The Report ?", MsgBoxStyle.YesNo)
        If msgRslt = MsgBoxResult.Yes Then
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
            'PD.Print()  'Direct Print

            new_order()



            MsgBox("Order Completed Succesfully")


            CheckOut.Show()
            Me.Hide()
            Me.Refresh()


        ElseIf msgRslt = MsgBoxResult.No Then
            MsgBox("Submit Your Order To The Database Before Printing The Invoice ")


        End If
    End Sub
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click


        CheckOut.Show()
        Me.Hide()




    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Confirm if your want to logout", " ZalliGate PLC ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class