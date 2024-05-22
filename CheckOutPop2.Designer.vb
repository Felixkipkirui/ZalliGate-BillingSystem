<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutPop2
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtHours = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMyTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMyDate = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnOut = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCheckout = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AttID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStaffID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCheckIn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbServedBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtCheckOut = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(521, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 28)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(477, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 28)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Total Hours"
        '
        'txtStatus
        '
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatus.DefaultText = ""
        Me.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.DisabledState.Parent = Me.txtStatus
        Me.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.FocusedState.Parent = Me.txtStatus
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.HoverState.Parent = Me.txtStatus
        Me.txtStatus.Location = New System.Drawing.Point(596, 345)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PlaceholderText = ""
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.ShadowDecoration.Parent = Me.txtStatus
        Me.txtStatus.Size = New System.Drawing.Size(231, 36)
        Me.txtStatus.TabIndex = 47
        '
        'txtHours
        '
        Me.txtHours.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHours.DefaultText = ""
        Me.txtHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHours.DisabledState.Parent = Me.txtHours
        Me.txtHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHours.FocusedState.Parent = Me.txtHours
        Me.txtHours.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHours.HoverState.Parent = Me.txtHours
        Me.txtHours.Location = New System.Drawing.Point(596, 294)
        Me.txtHours.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHours.PlaceholderText = ""
        Me.txtHours.ReadOnly = True
        Me.txtHours.SelectedText = ""
        Me.txtHours.ShadowDecoration.Parent = Me.txtHours
        Me.txtHours.Size = New System.Drawing.Size(231, 36)
        Me.txtHours.TabIndex = 46
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.lblMyTime)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lblMyDate)
        Me.Guna2Panel1.Controls.Add(Me.lblDate)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Orange
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(854, 137)
        Me.Guna2Panel1.TabIndex = 31
        '
        'lblMyTime
        '
        Me.lblMyTime.AutoSize = True
        Me.lblMyTime.BackColor = System.Drawing.Color.Transparent
        Me.lblMyTime.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyTime.Location = New System.Drawing.Point(126, 74)
        Me.lblMyTime.Name = "lblMyTime"
        Me.lblMyTime.Size = New System.Drawing.Size(73, 28)
        Me.lblMyTime.TabIndex = 7
        Me.lblMyTime.Text = "14:50:59"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ZalliGate Billing System"
        '
        'lblMyDate
        '
        Me.lblMyDate.AutoSize = True
        Me.lblMyDate.BackColor = System.Drawing.Color.Transparent
        Me.lblMyDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyDate.Location = New System.Drawing.Point(14, 46)
        Me.lblMyDate.Name = "lblMyDate"
        Me.lblMyDate.Size = New System.Drawing.Size(222, 28)
        Me.lblMyDate.TabIndex = 8
        Me.lblMyDate.Text = "Saturday, 28 January 2024"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(14, 74)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 28)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "2024-01-20"
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.DarkOrange
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(433, 406)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(156, 45)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Close"
        '
        'btnOut
        '
        Me.btnOut.BorderRadius = 10
        Me.btnOut.CheckedState.Parent = Me.btnOut
        Me.btnOut.CustomImages.Parent = Me.btnOut
        Me.btnOut.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnOut.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOut.ForeColor = System.Drawing.Color.White
        Me.btnOut.HoverState.Parent = Me.btnOut
        Me.btnOut.Location = New System.Drawing.Point(216, 406)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.ShadowDecoration.Parent = Me.btnOut
        Me.btnOut.Size = New System.Drawing.Size(147, 45)
        Me.btnOut.TabIndex = 45
        Me.btnOut.Text = "Check Out"
        '
        'lblCheckout
        '
        Me.lblCheckout.AutoSize = True
        Me.lblCheckout.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckout.Location = New System.Drawing.Point(432, 237)
        Me.lblCheckout.Name = "lblCheckout"
        Me.lblCheckout.Size = New System.Drawing.Size(157, 28)
        Me.lblCheckout.TabIndex = 38
        Me.lblCheckout.Text = "Check-Out Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(448, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 28)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Check-In Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 28)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Staff-Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 28)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Staff ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 28)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Attendance ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Username"
        '
        'AttID
        '
        Me.AttID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AttID.DefaultText = ""
        Me.AttID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AttID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AttID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AttID.DisabledState.Parent = Me.AttID
        Me.AttID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AttID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttID.FocusedState.Parent = Me.AttID
        Me.AttID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttID.HoverState.Parent = Me.AttID
        Me.AttID.Location = New System.Drawing.Point(152, 237)
        Me.AttID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttID.Name = "AttID"
        Me.AttID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AttID.PlaceholderText = ""
        Me.AttID.ReadOnly = True
        Me.AttID.SelectedText = ""
        Me.AttID.ShadowDecoration.Parent = Me.AttID
        Me.AttID.Size = New System.Drawing.Size(253, 36)
        Me.AttID.TabIndex = 35
        '
        'txtStaffID
        '
        Me.txtStaffID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStaffID.DefaultText = ""
        Me.txtStaffID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStaffID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStaffID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStaffID.DisabledState.Parent = Me.txtStaffID
        Me.txtStaffID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStaffID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStaffID.FocusedState.Parent = Me.txtStaffID
        Me.txtStaffID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStaffID.HoverState.Parent = Me.txtStaffID
        Me.txtStaffID.Location = New System.Drawing.Point(152, 283)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStaffID.PlaceholderText = ""
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.SelectedText = ""
        Me.txtStaffID.ShadowDecoration.Parent = Me.txtStaffID
        Me.txtStaffID.Size = New System.Drawing.Size(253, 36)
        Me.txtStaffID.TabIndex = 34
        '
        'txtCheckIn
        '
        Me.txtCheckIn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCheckIn.DefaultText = ""
        Me.txtCheckIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCheckIn.DisabledState.Parent = Me.txtCheckIn
        Me.txtCheckIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCheckIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCheckIn.FocusedState.Parent = Me.txtCheckIn
        Me.txtCheckIn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCheckIn.HoverState.Parent = Me.txtCheckIn
        Me.txtCheckIn.Location = New System.Drawing.Point(596, 182)
        Me.txtCheckIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCheckIn.Name = "txtCheckIn"
        Me.txtCheckIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCheckIn.PlaceholderText = ""
        Me.txtCheckIn.ReadOnly = True
        Me.txtCheckIn.SelectedText = ""
        Me.txtCheckIn.ShadowDecoration.Parent = Me.txtCheckIn
        Me.txtCheckIn.Size = New System.Drawing.Size(231, 36)
        Me.txtCheckIn.TabIndex = 37
        '
        'cmbServedBy
        '
        Me.cmbServedBy.BackColor = System.Drawing.Color.Transparent
        Me.cmbServedBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbServedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServedBy.FocusedColor = System.Drawing.Color.Empty
        Me.cmbServedBy.FocusedState.Parent = Me.cmbServedBy
        Me.cmbServedBy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbServedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbServedBy.FormattingEnabled = True
        Me.cmbServedBy.HoverState.Parent = Me.cmbServedBy
        Me.cmbServedBy.ItemHeight = 30
        Me.cmbServedBy.ItemsAppearance.Parent = Me.cmbServedBy
        Me.cmbServedBy.Location = New System.Drawing.Point(151, 184)
        Me.cmbServedBy.Name = "cmbServedBy"
        Me.cmbServedBy.ShadowDecoration.Parent = Me.cmbServedBy
        Me.cmbServedBy.Size = New System.Drawing.Size(254, 36)
        Me.cmbServedBy.TabIndex = 32
        '
        'txtCheckOut
        '
        Me.txtCheckOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCheckOut.DefaultText = ""
        Me.txtCheckOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCheckOut.DisabledState.Parent = Me.txtCheckOut
        Me.txtCheckOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCheckOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCheckOut.FocusedState.Parent = Me.txtCheckOut
        Me.txtCheckOut.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCheckOut.HoverState.Parent = Me.txtCheckOut
        Me.txtCheckOut.Location = New System.Drawing.Point(596, 237)
        Me.txtCheckOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCheckOut.Name = "txtCheckOut"
        Me.txtCheckOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCheckOut.PlaceholderText = ""
        Me.txtCheckOut.ReadOnly = True
        Me.txtCheckOut.SelectedText = ""
        Me.txtCheckOut.ShadowDecoration.Parent = Me.txtCheckOut
        Me.txtCheckOut.Size = New System.Drawing.Size(231, 36)
        Me.txtCheckOut.TabIndex = 36
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtName
        '
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(152, 337)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.ReadOnly = True
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(253, 36)
        Me.txtName.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(602, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 37)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "SHIFT-2 CHECK-OUT"
        '
        'CheckOutPop2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 488)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.lblCheckout)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AttID)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.txtCheckIn)
        Me.Controls.Add(Me.cmbServedBy)
        Me.Controls.Add(Me.txtCheckOut)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckOutPop2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckOutPop2"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtHours As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMyTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMyDate As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCheckout As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AttID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStaffID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCheckIn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbServedBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtCheckOut As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
End Class
