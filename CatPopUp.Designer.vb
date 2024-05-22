<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatPopUp
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
        Me.btnSaveProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.txtProdPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Open_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Peru
        Me.btnClose.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(622, 353)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(107, 36)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.CheckedState.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.CustomImages.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.FillColor = System.Drawing.Color.Blue
        Me.btnSaveProduct.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProduct.ForeColor = System.Drawing.Color.White
        Me.btnSaveProduct.HoverState.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.Location = New System.Drawing.Point(456, 353)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.ShadowDecoration.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.Size = New System.Drawing.Size(160, 36)
        Me.btnSaveProduct.TabIndex = 15
        Me.btnSaveProduct.Text = "Save Category"
        '
        'txtProdPrice
        '
        Me.txtProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdPrice.DefaultText = ""
        Me.txtProdPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdPrice.DisabledState.Parent = Me.txtProdPrice
        Me.txtProdPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdPrice.FocusedState.Parent = Me.txtProdPrice
        Me.txtProdPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdPrice.HoverState.Parent = Me.txtProdPrice
        Me.txtProdPrice.Location = New System.Drawing.Point(250, 215)
        Me.txtProdPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProdPrice.Multiline = True
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdPrice.PlaceholderText = ""
        Me.txtProdPrice.SelectedText = ""
        Me.txtProdPrice.ShadowDecoration.Parent = Me.txtProdPrice
        Me.txtProdPrice.Size = New System.Drawing.Size(289, 110)
        Me.txtProdPrice.TabIndex = 11
        '
        'txtProdName
        '
        Me.txtProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProdName.DefaultText = ""
        Me.txtProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdName.DisabledState.Parent = Me.txtProdName
        Me.txtProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdName.FocusedState.Parent = Me.txtProdName
        Me.txtProdName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdName.HoverState.Parent = Me.txtProdName
        Me.txtProdName.Location = New System.Drawing.Point(250, 142)
        Me.txtProdName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdName.PlaceholderText = ""
        Me.txtProdName.SelectedText = ""
        Me.txtProdName.ShadowDecoration.Parent = Me.txtProdName
        Me.txtProdName.Size = New System.Drawing.Size(289, 36)
        Me.txtProdName.TabIndex = 12
        '
        'txtProductCode
        '
        Me.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductCode.DefaultText = ""
        Me.txtProductCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductCode.DisabledState.Parent = Me.txtProductCode
        Me.txtProductCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductCode.FocusedState.Parent = Me.txtProductCode
        Me.txtProductCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductCode.HoverState.Parent = Me.txtProductCode
        Me.txtProductCode.Location = New System.Drawing.Point(250, 69)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductCode.PlaceholderText = ""
        Me.txtProductCode.SelectedText = ""
        Me.txtProductCode.ShadowDecoration.Parent = Me.txtProductCode
        Me.txtProductCode.Size = New System.Drawing.Size(289, 36)
        Me.txtProductCode.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Category Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Category Code"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Peru
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 48)
        Me.Panel1.TabIndex = 5
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(300, 10)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(125, 28)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "New Category"
        '
        'Open_Timer
        '
        Me.Open_Timer.Enabled = True
        Me.Open_Timer.Interval = 8
        '
        'CatPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 389)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveProduct)
        Me.Controls.Add(Me.txtProdPrice)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CatPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CatPopUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtProdPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProductCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Open_Timer As Timer
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
