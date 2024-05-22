<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceModule2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceModule2))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCheckOut = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCheckIn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AttendanceDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.EndDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.StartDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.lblMyTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lblMyDate = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(28, 59)
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
        Me.btnCheckOut.Location = New System.Drawing.Point(3, 314)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheckOut.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCheckOut.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCheckOut.OnHoverImage = Nothing
        Me.btnCheckOut.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCheckOut.OnPressedColor = System.Drawing.Color.Black
        Me.btnCheckOut.Size = New System.Drawing.Size(202, 42)
        Me.btnCheckOut.TabIndex = 0
        Me.btnCheckOut.Text = "Check-Out"
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
        Me.btnCheckIn.Location = New System.Drawing.Point(3, 266)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheckIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCheckIn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCheckIn.OnHoverImage = Nothing
        Me.btnCheckIn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCheckIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnCheckIn.Size = New System.Drawing.Size(202, 42)
        Me.btnCheckIn.TabIndex = 0
        Me.btnCheckIn.Text = "Check-In"
        Me.btnCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaAdvenceButton6.Location = New System.Drawing.Point(3, 362)
        Me.GunaAdvenceButton6.Name = "GunaAdvenceButton6"
        Me.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.OnHoverImage = Nothing
        Me.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.Size = New System.Drawing.Size(202, 42)
        Me.GunaAdvenceButton6.TabIndex = 0
        Me.GunaAdvenceButton6.Text = "Shift-2 Report"
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
        'AttendanceDGV
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.AttendanceDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.AttendanceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendanceDGV.BackgroundColor = System.Drawing.Color.White
        Me.AttendanceDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AttendanceDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AttendanceDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttendanceDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.AttendanceDGV.ColumnHeadersHeight = 25
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceDGV.DefaultCellStyle = DataGridViewCellStyle12
        Me.AttendanceDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AttendanceDGV.EnableHeadersVisualStyles = False
        Me.AttendanceDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDGV.Location = New System.Drawing.Point(208, 266)
        Me.AttendanceDGV.Name = "AttendanceDGV"
        Me.AttendanceDGV.ReadOnly = True
        Me.AttendanceDGV.RowHeadersVisible = False
        Me.AttendanceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AttendanceDGV.Size = New System.Drawing.Size(1043, 291)
        Me.AttendanceDGV.TabIndex = 27
        Me.AttendanceDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.AttendanceDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AttendanceDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AttendanceDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AttendanceDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AttendanceDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AttendanceDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.AttendanceDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AttendanceDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.AttendanceDGV.ThemeStyle.HeaderStyle.Height = 25
        Me.AttendanceDGV.ThemeStyle.ReadOnly = True
        Me.AttendanceDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AttendanceDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.AttendanceDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.AttendanceDGV.ThemeStyle.RowsStyle.Height = 22
        Me.AttendanceDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.btnPrint.Location = New System.Drawing.Point(741, 215)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(167, 42)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.Text = "Print"
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
        Me.btnSearch.Location = New System.Drawing.Point(509, 215)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(167, 42)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "View Attendance"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CheckedState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.EndDatePicker.HoverState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Location = New System.Drawing.Point(727, 132)
        Me.EndDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.EndDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.ShadowDecoration.Parent = Me.EndDatePicker
        Me.EndDatePicker.Size = New System.Drawing.Size(238, 36)
        Me.EndDatePicker.TabIndex = 23
        Me.EndDatePicker.Value = New Date(2024, 3, 30, 22, 57, 7, 890)
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CheckedState.Parent = Me.StartDatePicker
        Me.StartDatePicker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.StartDatePicker.HoverState.Parent = Me.StartDatePicker
        Me.StartDatePicker.Location = New System.Drawing.Point(460, 132)
        Me.StartDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.StartDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.ShadowDecoration.Parent = Me.StartDatePicker
        Me.StartDatePicker.Size = New System.Drawing.Size(238, 36)
        Me.StartDatePicker.TabIndex = 24
        Me.StartDatePicker.Value = New Date(2024, 3, 30, 22, 57, 7, 890)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Poppins SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(501, 54)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(528, 48)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "Shift-2 Employee Attendance Module"
        '
        'lblMyTime
        '
        Me.lblMyTime.AutoSize = True
        Me.lblMyTime.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyTime.Location = New System.Drawing.Point(328, 74)
        Me.lblMyTime.Name = "lblMyTime"
        Me.lblMyTime.Size = New System.Drawing.Size(73, 28)
        Me.lblMyTime.TabIndex = 3
        Me.lblMyTime.Text = "14:50:59"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ZalliGate Billing System"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel3.Controls.Add(Me.PictureBox3)
        Me.Guna2Panel3.Controls.Add(Me.btnCheckOut)
        Me.Guna2Panel3.Controls.Add(Me.btnCheckIn)
        Me.Guna2Panel3.Controls.Add(Me.GunaAdvenceButton6)
        Me.Guna2Panel3.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(208, 557)
        Me.Guna2Panel3.TabIndex = 2
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Beige
        Me.GunaPanel1.Controls.Add(Me.AttendanceDGV)
        Me.GunaPanel1.Controls.Add(Me.btnPrint)
        Me.GunaPanel1.Controls.Add(Me.btnSearch)
        Me.GunaPanel1.Controls.Add(Me.EndDatePicker)
        Me.GunaPanel1.Controls.Add(Me.StartDatePicker)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel1.Controls.Add(Me.lblMyTime)
        Me.GunaPanel1.Controls.Add(Me.lblMyDate)
        Me.GunaPanel1.Controls.Add(Me.lblDate)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.Guna2Panel3)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1251, 557)
        Me.GunaPanel1.TabIndex = 1
        '
        'lblMyDate
        '
        Me.lblMyDate.AutoSize = True
        Me.lblMyDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyDate.Location = New System.Drawing.Point(216, 46)
        Me.lblMyDate.Name = "lblMyDate"
        Me.lblMyDate.Size = New System.Drawing.Size(222, 28)
        Me.lblMyDate.TabIndex = 4
        Me.lblMyDate.Text = "Saturday, 28 January 2024"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(216, 74)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 28)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "2024-01-20"
        '
        'AttendanceModule2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 557)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AttendanceModule2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttendanceModule2"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCheckOut As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnCheckIn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AttendanceDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EndDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents StartDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblMyTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblMyDate As Label
    Friend WithEvents lblDate As Label
End Class
