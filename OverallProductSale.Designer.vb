<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverallProductSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverallProductSale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMyTime = New System.Windows.Forms.Label()
        Me.lblMyDate = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EndDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.StartDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalProd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TransDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbShift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.TransDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Today's Sales"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMin.Location = New System.Drawing.Point(12, 26)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(37, 37)
        Me.lblMin.TabIndex = 5
        Me.lblMin.Text = "--"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderRadius = 10
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.FillColor = System.Drawing.Color.Gold
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(450, 250)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(167, 42)
        Me.btnPrint.TabIndex = 22
        Me.btnPrint.Text = "Print"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.FillColor = System.Drawing.Color.Gold
        Me.Guna2Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(515, 0)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(167, 42)
        Me.Guna2Button4.TabIndex = 21
        Me.Guna2Button4.Text = "Dashboard"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.BackColor = System.Drawing.Color.Transparent
        Me.lblMax.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMax.Location = New System.Drawing.Point(12, 29)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(37, 37)
        Me.lblMax.TabIndex = 5
        Me.lblMax.Text = "--"
        '
        'lblMyTime
        '
        Me.lblMyTime.AutoSize = True
        Me.lblMyTime.BackColor = System.Drawing.Color.Transparent
        Me.lblMyTime.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyTime.Location = New System.Drawing.Point(109, 101)
        Me.lblMyTime.Name = "lblMyTime"
        Me.lblMyTime.Size = New System.Drawing.Size(73, 28)
        Me.lblMyTime.TabIndex = 17
        Me.lblMyTime.Text = "14:50:59"
        '
        'lblMyDate
        '
        Me.lblMyDate.AutoSize = True
        Me.lblMyDate.BackColor = System.Drawing.Color.Transparent
        Me.lblMyDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyDate.Location = New System.Drawing.Point(3, 73)
        Me.lblMyDate.Name = "lblMyDate"
        Me.lblMyDate.Size = New System.Drawing.Size(222, 28)
        Me.lblMyDate.TabIndex = 18
        Me.lblMyDate.Text = "Saturday, 28 January 2024"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(3, 101)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 28)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "2024-01-20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ZalliGate Billing System"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.FillColor = System.Drawing.Color.Gold
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(267, 250)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(167, 42)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(63, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Highest Sale"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CheckedState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.EndDatePicker.HoverState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Location = New System.Drawing.Point(485, 195)
        Me.EndDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.EndDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.ShadowDecoration.Parent = Me.EndDatePicker
        Me.EndDatePicker.Size = New System.Drawing.Size(238, 36)
        Me.EndDatePicker.TabIndex = 10
        Me.EndDatePicker.Value = New Date(2024, 3, 30, 22, 57, 7, 890)
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CheckedState.Parent = Me.StartDatePicker
        Me.StartDatePicker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.StartDatePicker.HoverState.Parent = Me.StartDatePicker
        Me.StartDatePicker.Location = New System.Drawing.Point(196, 195)
        Me.StartDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.StartDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.ShadowDecoration.Parent = Me.StartDatePicker
        Me.StartDatePicker.Size = New System.Drawing.Size(238, 36)
        Me.StartDatePicker.TabIndex = 10
        Me.StartDatePicker.Value = New Date(2024, 3, 30, 22, 57, 7, 890)
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderRadius = 10
        Me.Guna2Panel5.Controls.Add(Me.lblMin)
        Me.Guna2Panel5.Controls.Add(Me.Label4)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2Panel5.Location = New System.Drawing.Point(1059, 158)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel5.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(69, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lowest Sale"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.Location = New System.Drawing.Point(17, 63)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(125, 28)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Products"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 10
        Me.Guna2Panel4.Controls.Add(Me.lblTotalProd)
        Me.Guna2Panel4.Controls.Add(Me.lblTotal)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(833, 158)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel4.TabIndex = 0
        '
        'lblTotalProd
        '
        Me.lblTotalProd.AutoSize = True
        Me.lblTotalProd.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalProd.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalProd.Location = New System.Drawing.Point(15, 26)
        Me.lblTotalProd.Name = "lblTotalProd"
        Me.lblTotalProd.Size = New System.Drawing.Size(37, 37)
        Me.lblTotalProd.TabIndex = 5
        Me.lblTotalProd.Text = "--"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(573, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sales"
        '
        'TransDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.TransDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TransDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TransDGV.BackgroundColor = System.Drawing.Color.White
        Me.TransDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TransDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TransDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TransDGV.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.TransDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TransDGV.EnableHeadersVisualStyles = False
        Me.TransDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransDGV.Location = New System.Drawing.Point(0, 342)
        Me.TransDGV.Name = "TransDGV"
        Me.TransDGV.ReadOnly = True
        Me.TransDGV.RowHeadersVisible = False
        Me.TransDGV.RowTemplate.ReadOnly = True
        Me.TransDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TransDGV.Size = New System.Drawing.Size(1267, 254)
        Me.TransDGV.TabIndex = 8
        Me.TransDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.TransDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TransDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TransDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TransDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TransDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TransDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TransDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TransDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.TransDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TransDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.TransDGV.ThemeStyle.HeaderStyle.Height = 25
        Me.TransDGV.ThemeStyle.ReadOnly = True
        Me.TransDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TransDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TransDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.TransDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TransDGV.ThemeStyle.RowsStyle.Height = 22
        Me.TransDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.Controls.Add(Me.lblMax)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(1059, 52)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.lblTotalSales)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(833, 52)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel2.TabIndex = 0
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSales.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalSales.Location = New System.Drawing.Point(15, 26)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(37, 37)
        Me.lblTotalSales.TabIndex = 5
        Me.lblTotalSales.Text = "--"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbShift)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GunaLabel7)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnPrint)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblMyTime)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblMyDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnSearch)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.EndDatePicker)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.StartDatePicker)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TransDGV)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1267, 596)
        Me.Guna2CustomGradientPanel1.TabIndex = 5
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Gold
        Me.Guna2Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(698, 0)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(220, 42)
        Me.Guna2Button3.TabIndex = 26
        Me.Guna2Button3.Text = "Orders"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Gold
        Me.Guna2Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(926, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(183, 42)
        Me.Guna2Button2.TabIndex = 27
        Me.Guna2Button2.Text = "Transactions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(317, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 37)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Overall Product Summary"
        '
        'cmbShift
        '
        Me.cmbShift.BackColor = System.Drawing.Color.Transparent
        Me.cmbShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShift.FocusedColor = System.Drawing.Color.Empty
        Me.cmbShift.FocusedState.Parent = Me.cmbShift
        Me.cmbShift.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbShift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbShift.FormattingEnabled = True
        Me.cmbShift.HoverState.Parent = Me.cmbShift
        Me.cmbShift.ItemHeight = 30
        Me.cmbShift.Items.AddRange(New Object() {"SHIFT-1", "SHIFT-2"})
        Me.cmbShift.ItemsAppearance.Parent = Me.cmbShift
        Me.cmbShift.Location = New System.Drawing.Point(428, 107)
        Me.cmbShift.Name = "cmbShift"
        Me.cmbShift.ShadowDecoration.Parent = Me.cmbShift
        Me.cmbShift.Size = New System.Drawing.Size(208, 36)
        Me.cmbShift.TabIndex = 29
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(319, 115)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(94, 28)
        Me.GunaLabel7.TabIndex = 28
        Me.GunaLabel7.Text = "Work-Shift"
        '
        'OverallProductSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 596)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OverallProductSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OverallProductSale"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.TransDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblMax As Label
    Friend WithEvents lblMyTime As Label
    Friend WithEvents lblMyDate As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents EndDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents StartDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalProd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TransDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbShift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
End Class
