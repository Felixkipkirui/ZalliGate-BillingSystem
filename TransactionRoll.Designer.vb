<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionRoll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionRoll))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMyTime = New System.Windows.Forms.Label()
        Me.lblMyDate = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EndDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.StartDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnCheck = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CartDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'lblMyTime
        '
        Me.lblMyTime.AutoSize = True
        Me.lblMyTime.BackColor = System.Drawing.Color.Transparent
        Me.lblMyTime.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyTime.Location = New System.Drawing.Point(117, 110)
        Me.lblMyTime.Name = "lblMyTime"
        Me.lblMyTime.Size = New System.Drawing.Size(73, 28)
        Me.lblMyTime.TabIndex = 22
        Me.lblMyTime.Text = "14:50:59"
        '
        'lblMyDate
        '
        Me.lblMyDate.AutoSize = True
        Me.lblMyDate.BackColor = System.Drawing.Color.Transparent
        Me.lblMyDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyDate.Location = New System.Drawing.Point(5, 82)
        Me.lblMyDate.Name = "lblMyDate"
        Me.lblMyDate.Size = New System.Drawing.Size(222, 28)
        Me.lblMyDate.TabIndex = 23
        Me.lblMyDate.Text = "Saturday, 28 January 2024"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(5, 110)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 28)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "2024-01-20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 37)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ZalliGate Billing System"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CheckedState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.EndDatePicker.HoverState.Parent = Me.EndDatePicker
        Me.EndDatePicker.Location = New System.Drawing.Point(575, 82)
        Me.EndDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.EndDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.ShadowDecoration.Parent = Me.EndDatePicker
        Me.EndDatePicker.Size = New System.Drawing.Size(238, 36)
        Me.EndDatePicker.TabIndex = 20
        Me.EndDatePicker.Value = New Date(2024, 3, 30, 22, 57, 7, 890)
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CheckedState.Parent = Me.StartDatePicker
        Me.StartDatePicker.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.StartDatePicker.HoverState.Parent = Me.StartDatePicker
        Me.StartDatePicker.Location = New System.Drawing.Point(319, 82)
        Me.StartDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.StartDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.ShadowDecoration.Parent = Me.StartDatePicker
        Me.StartDatePicker.Size = New System.Drawing.Size(238, 36)
        Me.StartDatePicker.TabIndex = 21
        Me.StartDatePicker.Value = New Date(2024, 3, 30, 22, 57, 7, 890)
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Transparent
        Me.btnCheck.BorderRadius = 10
        Me.btnCheck.CheckedState.Parent = Me.btnCheck
        Me.btnCheck.CustomImages.Parent = Me.btnCheck
        Me.btnCheck.FillColor = System.Drawing.Color.Gold
        Me.btnCheck.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.Black
        Me.btnCheck.HoverState.Parent = Me.btnCheck
        Me.btnCheck.Location = New System.Drawing.Point(401, 124)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.ShadowDecoration.Parent = Me.btnCheck
        Me.btnCheck.Size = New System.Drawing.Size(167, 42)
        Me.btnCheck.TabIndex = 16
        Me.btnCheck.Text = "Generate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(520, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Transactions"
        '
        'CartDGV
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.CartDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.CartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CartDGV.BackgroundColor = System.Drawing.Color.White
        Me.CartDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CartDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CartDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CartDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.CartDGV.ColumnHeadersHeight = 25
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDGV.DefaultCellStyle = DataGridViewCellStyle6
        Me.CartDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CartDGV.EnableHeadersVisualStyles = False
        Me.CartDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CartDGV.Location = New System.Drawing.Point(0, 226)
        Me.CartDGV.Name = "CartDGV"
        Me.CartDGV.ReadOnly = True
        Me.CartDGV.RowHeadersVisible = False
        Me.CartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CartDGV.Size = New System.Drawing.Size(1267, 370)
        Me.CartDGV.TabIndex = 8
        Me.CartDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.CartDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CartDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CartDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CartDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CartDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CartDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CartDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CartDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CartDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CartDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CartDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CartDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CartDGV.ThemeStyle.HeaderStyle.Height = 25
        Me.CartDGV.ThemeStyle.ReadOnly = True
        Me.CartDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CartDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CartDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CartDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CartDGV.ThemeStyle.RowsStyle.Height = 22
        Me.CartDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CartDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.Transparent
        Me.txt_search.BorderRadius = 10
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.Parent = Me.txt_search
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.FocusedState.Parent = Me.txt_search
        Me.txt_search.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.HoverState.Parent = Me.txt_search
        Me.txt_search.Location = New System.Drawing.Point(878, 6)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search Bar"
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(375, 45)
        Me.txt_search.TabIndex = 7
        Me.txt_search.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnPrint)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblMyTime)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblMyDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.EndDatePicker)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.StartDatePicker)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnCheck)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.CartDGV)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txt_search)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1267, 596)
        Me.Guna2CustomGradientPanel1.TabIndex = 7
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
        Me.btnPrint.Location = New System.Drawing.Point(599, 124)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(167, 42)
        Me.btnPrint.TabIndex = 31
        Me.btnPrint.Text = "Print"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Poppins SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(396, 6)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(400, 48)
        Me.GunaLabel4.TabIndex = 30
        Me.GunaLabel4.Text = "Transaction Roll Generation"
        '
        'TransactionRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 596)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransactionRoll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionRoll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMyTime As Label
    Friend WithEvents lblMyDate As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EndDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents StartDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnCheck As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CartDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
End Class
