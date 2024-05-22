<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionFrm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionFrm))
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TransDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCheckOut = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCheckIn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbShift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMyDate = New System.Windows.Forms.Label()
        Me.lblMyTime = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.EndDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.StartDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTOT = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.TransDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnSearch.Location = New System.Drawing.Point(375, 200)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(167, 42)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(514, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Transactions"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TransDGV)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbShift)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GunaLabel7)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnPrint)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblMyDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblMyTime)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnSearch)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.EndDatePicker)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.StartDatePicker)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1267, 596)
        Me.Guna2CustomGradientPanel1.TabIndex = 3
        '
        'TransDGV
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.TransDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.TransDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TransDGV.BackgroundColor = System.Drawing.Color.White
        Me.TransDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TransDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TransDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.TransDGV.ColumnHeadersHeight = 25
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransDGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.TransDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TransDGV.EnableHeadersVisualStyles = False
        Me.TransDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransDGV.Location = New System.Drawing.Point(220, 287)
        Me.TransDGV.Name = "TransDGV"
        Me.TransDGV.ReadOnly = True
        Me.TransDGV.RowHeadersVisible = False
        Me.TransDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TransDGV.Size = New System.Drawing.Size(1047, 309)
        Me.TransDGV.TabIndex = 37
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.Controls.Add(Me.PictureBox3)
        Me.Guna2Panel1.Controls.Add(Me.btnCheckOut)
        Me.Guna2Panel1.Controls.Add(Me.btnCheckIn)
        Me.Guna2Panel1.Controls.Add(Me.GunaAdvenceButton2)
        Me.Guna2Panel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.Guna2Panel1.Controls.Add(Me.GunaAdvenceButton6)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(220, 596)
        Me.Guna2Panel1.TabIndex = 34
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(32, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(143, 140)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'btnCheckOut
        '
        Me.btnCheckOut.AnimationHoverSpeed = 0.07!
        Me.btnCheckOut.AnimationSpeed = 0.03!
        Me.btnCheckOut.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.BaseColor = System.Drawing.Color.DeepPink
        Me.btnCheckOut.BorderColor = System.Drawing.Color.Black
        Me.btnCheckOut.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCheckOut.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCheckOut.CheckedForeColor = System.Drawing.Color.White
        Me.btnCheckOut.CheckedImage = CType(resources.GetObject("btnCheckOut.CheckedImage"), System.Drawing.Image)
        Me.btnCheckOut.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCheckOut.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCheckOut.FocusedColor = System.Drawing.Color.Empty
        Me.btnCheckOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Image = CType(resources.GetObject("btnCheckOut.Image"), System.Drawing.Image)
        Me.btnCheckOut.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnCheckOut.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCheckOut.Location = New System.Drawing.Point(15, 350)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheckOut.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCheckOut.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCheckOut.OnHoverImage = Nothing
        Me.btnCheckOut.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCheckOut.OnPressedColor = System.Drawing.Color.Black
        Me.btnCheckOut.Size = New System.Drawing.Size(202, 42)
        Me.btnCheckOut.TabIndex = 0
        Me.btnCheckOut.Text = "Mobile Money"
        Me.btnCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCheckIn
        '
        Me.btnCheckIn.AnimationHoverSpeed = 0.07!
        Me.btnCheckIn.AnimationSpeed = 0.03!
        Me.btnCheckIn.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckIn.BaseColor = System.Drawing.Color.SeaGreen
        Me.btnCheckIn.BorderColor = System.Drawing.Color.Black
        Me.btnCheckIn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCheckIn.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCheckIn.CheckedForeColor = System.Drawing.Color.White
        Me.btnCheckIn.CheckedImage = CType(resources.GetObject("btnCheckIn.CheckedImage"), System.Drawing.Image)
        Me.btnCheckIn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCheckIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCheckIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnCheckIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.Image = CType(resources.GetObject("btnCheckIn.Image"), System.Drawing.Image)
        Me.btnCheckIn.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnCheckIn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCheckIn.Location = New System.Drawing.Point(15, 295)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheckIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCheckIn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCheckIn.OnHoverImage = Nothing
        Me.btnCheckIn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCheckIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnCheckIn.Size = New System.Drawing.Size(202, 42)
        Me.btnCheckIn.TabIndex = 0
        Me.btnCheckIn.Text = "Cash-In-Hand"
        Me.btnCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(12, 527)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(202, 42)
        Me.GunaAdvenceButton2.TabIndex = 0
        Me.GunaAdvenceButton2.Text = "Transaction Roll"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(12, 464)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(202, 42)
        Me.GunaAdvenceButton1.TabIndex = 0
        Me.GunaAdvenceButton1.Text = "E-Payment"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton6
        '
        Me.GunaAdvenceButton6.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton6.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton6.BaseColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.CheckedImage = CType(resources.GetObject("GunaAdvenceButton6.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton6.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.Image = CType(resources.GetObject("GunaAdvenceButton6.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton6.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.Location = New System.Drawing.Point(15, 405)
        Me.GunaAdvenceButton6.Name = "GunaAdvenceButton6"
        Me.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.OnHoverImage = Nothing
        Me.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.Size = New System.Drawing.Size(202, 42)
        Me.GunaAdvenceButton6.TabIndex = 0
        Me.GunaAdvenceButton6.Text = "Bank Transfer"
        Me.GunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
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
        Me.cmbShift.Location = New System.Drawing.Point(463, 90)
        Me.cmbShift.Name = "cmbShift"
        Me.cmbShift.ShadowDecoration.Parent = Me.cmbShift
        Me.cmbShift.Size = New System.Drawing.Size(243, 36)
        Me.cmbShift.TabIndex = 33
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(345, 90)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(94, 28)
        Me.GunaLabel7.TabIndex = 32
        Me.GunaLabel7.Text = "Work-Shift"
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
        Me.btnPrint.Location = New System.Drawing.Point(558, 200)
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
        Me.Guna2Button4.Location = New System.Drawing.Point(718, 0)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(167, 42)
        Me.Guna2Button4.TabIndex = 21
        Me.Guna2Button4.Text = "Dashboard"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(315, 37)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 28)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "2024-01-20"
        '
        'lblMyDate
        '
        Me.lblMyDate.AutoSize = True
        Me.lblMyDate.BackColor = System.Drawing.Color.Transparent
        Me.lblMyDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyDate.Location = New System.Drawing.Point(238, 9)
        Me.lblMyDate.Name = "lblMyDate"
        Me.lblMyDate.Size = New System.Drawing.Size(222, 28)
        Me.lblMyDate.TabIndex = 18
        Me.lblMyDate.Text = "Saturday, 28 January 2024"
        '
        'lblMyTime
        '
        Me.lblMyTime.AutoSize = True
        Me.lblMyTime.BackColor = System.Drawing.Color.Transparent
        Me.lblMyTime.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyTime.Location = New System.Drawing.Point(247, 37)
        Me.lblMyTime.Name = "lblMyTime"
        Me.lblMyTime.Size = New System.Drawing.Size(73, 28)
        Me.lblMyTime.TabIndex = 17
        Me.lblMyTime.Text = "14:50:59"
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
        Me.Guna2Button3.Location = New System.Drawing.Point(891, 0)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(167, 42)
        Me.Guna2Button3.TabIndex = 21
        Me.Guna2Button3.Text = "Transaction Search"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Gold
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(1064, 1)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(198, 42)
        Me.Guna2Button1.TabIndex = 21
        Me.Guna2Button1.Text = "Individual Staff Sales"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CheckedState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.EndDatePicker.HoverState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Location = New System.Drawing.Point(558, 142)
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
        Me.StartDatePicker.Location = New System.Drawing.Point(296, 142)
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
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMin.Location = New System.Drawing.Point(12, 26)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(30, 37)
        Me.lblMin.TabIndex = 5
        Me.lblMin.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(69, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lowest"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 10
        Me.Guna2Panel4.Controls.Add(Me.lblTOT)
        Me.Guna2Panel4.Controls.Add(Me.lblTotal)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(833, 158)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel4.TabIndex = 0
        '
        'lblTOT
        '
        Me.lblTOT.AutoSize = True
        Me.lblTOT.BackColor = System.Drawing.Color.Transparent
        Me.lblTOT.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTOT.Location = New System.Drawing.Point(15, 26)
        Me.lblTOT.Name = "lblTOT"
        Me.lblTOT.Size = New System.Drawing.Size(30, 37)
        Me.lblTOT.TabIndex = 5
        Me.lblTOT.Text = "5"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.Location = New System.Drawing.Point(74, 63)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(55, 28)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total "
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
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.BackColor = System.Drawing.Color.Transparent
        Me.lblMax.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMax.Location = New System.Drawing.Point(12, 29)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(30, 37)
        Me.lblMax.TabIndex = 5
        Me.lblMax.Text = "5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(63, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Highest"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.lblToday)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(833, 52)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel2.TabIndex = 0
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.BackColor = System.Drawing.Color.Transparent
        Me.lblToday.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblToday.Location = New System.Drawing.Point(15, 26)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(30, 37)
        Me.lblToday.TabIndex = 5
        Me.lblToday.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Today's Transactions"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TransactionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 596)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransactionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.TransDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents EndDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents StartDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTOT As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMax As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblToday As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblMyTime As Label
    Friend WithEvents lblMyDate As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbShift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCheckOut As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnCheckIn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TransDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
End Class
