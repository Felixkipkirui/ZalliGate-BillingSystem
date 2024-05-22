<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ZalliGateCheckOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZalliGateCheckOut))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRecieved = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbMode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbStaff = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSave = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Open_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtShift = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel7)
        Me.Guna2Panel1.Controls.Add(Me.lblDate)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Peru
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 170)
        Me.Guna2Panel1.TabIndex = 0
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Poppins SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(184, 42)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(418, 48)
        Me.GunaLabel7.TabIndex = 11
        Me.GunaLabel7.Text = "ZalliGate Payement Gateway"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(663, 120)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 28)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "2024-01-20"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGrandTotal.DefaultText = ""
        Me.txtGrandTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGrandTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGrandTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGrandTotal.DisabledState.Parent = Me.txtGrandTotal
        Me.txtGrandTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGrandTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrandTotal.FocusedState.Parent = Me.txtGrandTotal
        Me.txtGrandTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrandTotal.HoverState.Parent = Me.txtGrandTotal
        Me.txtGrandTotal.Location = New System.Drawing.Point(167, 215)
        Me.txtGrandTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGrandTotal.PlaceholderText = ""
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.SelectedText = ""
        Me.txtGrandTotal.ShadowDecoration.Parent = Me.txtGrandTotal
        Me.txtGrandTotal.Size = New System.Drawing.Size(200, 36)
        Me.txtGrandTotal.TabIndex = 1
        '
        'txtRecieved
        '
        Me.txtRecieved.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRecieved.DefaultText = ""
        Me.txtRecieved.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRecieved.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRecieved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecieved.DisabledState.Parent = Me.txtRecieved
        Me.txtRecieved.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecieved.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRecieved.FocusedState.Parent = Me.txtRecieved
        Me.txtRecieved.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecieved.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRecieved.HoverState.Parent = Me.txtRecieved
        Me.txtRecieved.Location = New System.Drawing.Point(167, 281)
        Me.txtRecieved.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRecieved.Name = "txtRecieved"
        Me.txtRecieved.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecieved.PlaceholderText = ""
        Me.txtRecieved.SelectedText = ""
        Me.txtRecieved.ShadowDecoration.Parent = Me.txtRecieved
        Me.txtRecieved.Size = New System.Drawing.Size(200, 36)
        Me.txtRecieved.TabIndex = 1
        '
        'txtBalance
        '
        Me.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBalance.DefaultText = ""
        Me.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBalance.DisabledState.Parent = Me.txtBalance
        Me.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBalance.FocusedState.Parent = Me.txtBalance
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBalance.HoverState.Parent = Me.txtBalance
        Me.txtBalance.Location = New System.Drawing.Point(167, 365)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBalance.PlaceholderText = ""
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.SelectedText = ""
        Me.txtBalance.ShadowDecoration.Parent = Me.txtBalance
        Me.txtBalance.Size = New System.Drawing.Size(200, 36)
        Me.txtBalance.TabIndex = 1
        '
        'txtStage
        '
        Me.txtStage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStage.DefaultText = ""
        Me.txtStage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStage.DisabledState.Parent = Me.txtStage
        Me.txtStage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStage.FocusedState.Parent = Me.txtStage
        Me.txtStage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStage.HoverState.Parent = Me.txtStage
        Me.txtStage.Location = New System.Drawing.Point(563, 379)
        Me.txtStage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStage.Name = "txtStage"
        Me.txtStage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStage.PlaceholderText = ""
        Me.txtStage.ReadOnly = True
        Me.txtStage.SelectedText = ""
        Me.txtStage.ShadowDecoration.Parent = Me.txtStage
        Me.txtStage.Size = New System.Drawing.Size(200, 36)
        Me.txtStage.TabIndex = 1
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 215)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(101, 28)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "GrandTotal"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(27, 281)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(85, 28)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Recieved"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(28, 365)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(78, 28)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Balance"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(2, 429)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(132, 28)
        Me.GunaLabel4.TabIndex = 2
        Me.GunaLabel4.Text = "Payment Mode"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(452, 193)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(104, 28)
        Me.GunaLabel5.TabIndex = 2
        Me.GunaLabel5.Text = "RecievedBy"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(478, 387)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(59, 28)
        Me.GunaLabel6.TabIndex = 2
        Me.GunaLabel6.Text = "Stage"
        '
        'btnClose
        '
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Peru
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(680, 465)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(120, 42)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        '
        'cmbMode
        '
        Me.cmbMode.BackColor = System.Drawing.Color.Transparent
        Me.cmbMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMode.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMode.FocusedState.Parent = Me.cmbMode
        Me.cmbMode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.HoverState.Parent = Me.cmbMode
        Me.cmbMode.ItemHeight = 30
        Me.cmbMode.Items.AddRange(New Object() {"CASH-AT-HAND", "MOBILE MONEY", "BANK TRANSFER", "E-PAYMENT"})
        Me.cmbMode.ItemsAppearance.Parent = Me.cmbMode
        Me.cmbMode.Location = New System.Drawing.Point(167, 421)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.ShadowDecoration.Parent = Me.cmbMode
        Me.cmbMode.Size = New System.Drawing.Size(208, 36)
        Me.cmbMode.TabIndex = 5
        '
        'cmbStaff
        '
        Me.cmbStaff.BackColor = System.Drawing.Color.Transparent
        Me.cmbStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaff.FocusedColor = System.Drawing.Color.Empty
        Me.cmbStaff.FocusedState.Parent = Me.cmbStaff
        Me.cmbStaff.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbStaff.FormattingEnabled = True
        Me.cmbStaff.HoverState.Parent = Me.cmbStaff
        Me.cmbStaff.ItemHeight = 30
        Me.cmbStaff.ItemsAppearance.Parent = Me.cmbStaff
        Me.cmbStaff.Location = New System.Drawing.Point(563, 193)
        Me.cmbStaff.Name = "cmbStaff"
        Me.cmbStaff.ShadowDecoration.Parent = Me.cmbStaff
        Me.cmbStaff.Size = New System.Drawing.Size(200, 36)
        Me.cmbStaff.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.BorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSave.CheckedForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedImage = CType(resources.GetObject("btnSave.CheckedImage"), System.Drawing.Image)
        Me.btnSave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(483, 465)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Size = New System.Drawing.Size(168, 42)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Open_Timer
        '
        Me.Open_Timer.Enabled = True
        Me.Open_Timer.Interval = 8
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(454, 257)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(102, 28)
        Me.GunaLabel8.TabIndex = 8
        Me.GunaLabel8.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.Parent = Me.txtDescription
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.FocusedState.Parent = Me.txtDescription
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.HoverState.Parent = Me.txtDescription
        Me.txtDescription.Location = New System.Drawing.Point(563, 257)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = "E.g: M-PESA CODE"
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.Parent = Me.txtDescription
        Me.txtDescription.Size = New System.Drawing.Size(200, 36)
        Me.txtDescription.TabIndex = 7
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(454, 320)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(90, 28)
        Me.GunaLabel9.TabIndex = 10
        Me.GunaLabel9.Text = "Work Shift"
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
        Me.txtShift.Location = New System.Drawing.Point(563, 320)
        Me.txtShift.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtShift.Name = "txtShift"
        Me.txtShift.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtShift.PlaceholderText = ""
        Me.txtShift.ReadOnly = True
        Me.txtShift.SelectedText = ""
        Me.txtShift.ShadowDecoration.Parent = Me.txtShift
        Me.txtShift.Size = New System.Drawing.Size(200, 36)
        Me.txtShift.TabIndex = 9
        '
        'ZalliGateCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.txtShift)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbStaff)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtStage)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtRecieved)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ZalliGateCheckOut"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZalliGateCheckOut"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtGrandTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRecieved As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbMode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbStaff As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Open_Timer As Timer
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtShift As Guna.UI2.WinForms.Guna2TextBox
End Class
