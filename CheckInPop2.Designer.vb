<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckInPop2
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
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStaffID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRole = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbServedBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblMyTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMyDate = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtShift = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnClose.Location = New System.Drawing.Point(526, 432)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(156, 45)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        '
        'btnIn
        '
        Me.btnIn.BorderRadius = 10
        Me.btnIn.CheckedState.Parent = Me.btnIn
        Me.btnIn.CustomImages.Parent = Me.btnIn
        Me.btnIn.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnIn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn.ForeColor = System.Drawing.Color.White
        Me.btnIn.HoverState.Parent = Me.btnIn
        Me.btnIn.Location = New System.Drawing.Point(239, 432)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.ShadowDecoration.Parent = Me.btnIn
        Me.btnIn.Size = New System.Drawing.Size(147, 45)
        Me.btnIn.TabIndex = 30
        Me.btnIn.Text = "Check In"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 28)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Work Shift"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 28)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Role"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 28)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Staff-Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 28)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Staff-ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Username"
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
        Me.txtName.Location = New System.Drawing.Point(186, 245)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(350, 36)
        Me.txtName.TabIndex = 20
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
        Me.txtStaffID.Location = New System.Drawing.Point(186, 199)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStaffID.PlaceholderText = ""
        Me.txtStaffID.SelectedText = ""
        Me.txtStaffID.ShadowDecoration.Parent = Me.txtStaffID
        Me.txtStaffID.Size = New System.Drawing.Size(350, 36)
        Me.txtStaffID.TabIndex = 21
        '
        'txtRole
        '
        Me.txtRole.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRole.DefaultText = ""
        Me.txtRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRole.DisabledState.Parent = Me.txtRole
        Me.txtRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRole.FocusedState.Parent = Me.txtRole
        Me.txtRole.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRole.HoverState.Parent = Me.txtRole
        Me.txtRole.Location = New System.Drawing.Point(186, 306)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRole.PlaceholderText = ""
        Me.txtRole.SelectedText = ""
        Me.txtRole.ShadowDecoration.Parent = Me.txtRole
        Me.txtRole.Size = New System.Drawing.Size(350, 36)
        Me.txtRole.TabIndex = 22
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
        Me.cmbServedBy.Location = New System.Drawing.Point(185, 136)
        Me.cmbServedBy.Name = "cmbServedBy"
        Me.cmbServedBy.ShadowDecoration.Parent = Me.cmbServedBy
        Me.cmbServedBy.Size = New System.Drawing.Size(351, 36)
        Me.cmbServedBy.TabIndex = 19
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
        'txtShift
        '
        Me.txtShift.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShift.DefaultText = ""
        Me.txtShift.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtShift.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtShift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShift.DisabledState.Parent = Me.txtShift
        Me.txtShift.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShift.FocusedState.Parent = Me.txtShift
        Me.txtShift.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShift.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShift.HoverState.Parent = Me.txtShift
        Me.txtShift.Location = New System.Drawing.Point(186, 360)
        Me.txtShift.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtShift.Name = "txtShift"
        Me.txtShift.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtShift.PlaceholderText = ""
        Me.txtShift.ReadOnly = True
        Me.txtShift.SelectedText = ""
        Me.txtShift.ShadowDecoration.Parent = Me.txtShift
        Me.txtShift.Size = New System.Drawing.Size(350, 36)
        Me.txtShift.TabIndex = 23
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(703, 126)
        Me.Guna2Panel1.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(483, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 37)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "SHIFT-2 CHECK-IN"
        '
        'CheckInPop2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 483)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.cmbServedBy)
        Me.Controls.Add(Me.txtShift)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckInPop2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckInPop2"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStaffID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRole As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbServedBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblMyTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMyDate As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtShift As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
End Class
