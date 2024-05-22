<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsPopUp
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProdPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnImagePick = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Open_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.pic_foodimg = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_foodimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Peru
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 48)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "New Product"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Product Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Product Image"
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
        Me.txtProductCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductCode.HoverState.Parent = Me.txtProductCode
        Me.txtProductCode.Location = New System.Drawing.Point(153, 84)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductCode.PlaceholderText = ""
        Me.txtProductCode.SelectedText = ""
        Me.txtProductCode.ShadowDecoration.Parent = Me.txtProductCode
        Me.txtProductCode.Size = New System.Drawing.Size(289, 36)
        Me.txtProductCode.TabIndex = 2
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
        Me.txtProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdName.HoverState.Parent = Me.txtProdName
        Me.txtProdName.Location = New System.Drawing.Point(153, 157)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdName.PlaceholderText = ""
        Me.txtProdName.SelectedText = ""
        Me.txtProdName.ShadowDecoration.Parent = Me.txtProdName
        Me.txtProdName.Size = New System.Drawing.Size(289, 36)
        Me.txtProdName.TabIndex = 2
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
        Me.txtProdPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProdPrice.HoverState.Parent = Me.txtProdPrice
        Me.txtProdPrice.Location = New System.Drawing.Point(153, 230)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdPrice.PlaceholderText = ""
        Me.txtProdPrice.SelectedText = ""
        Me.txtProdPrice.ShadowDecoration.Parent = Me.txtProdPrice
        Me.txtProdPrice.Size = New System.Drawing.Size(289, 36)
        Me.txtProdPrice.TabIndex = 2
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.HoverState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Location = New System.Drawing.Point(36, 402)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = ""
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.ShadowDecoration.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Size = New System.Drawing.Size(10, 36)
        Me.Guna2TextBox4.TabIndex = 2
        Me.Guna2TextBox4.Visible = False
        '
        'btnImagePick
        '
        Me.btnImagePick.CheckedState.Parent = Me.btnImagePick
        Me.btnImagePick.CustomImages.Parent = Me.btnImagePick
        Me.btnImagePick.FillColor = System.Drawing.Color.Peru
        Me.btnImagePick.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagePick.ForeColor = System.Drawing.Color.White
        Me.btnImagePick.HoverState.Parent = Me.btnImagePick
        Me.btnImagePick.Location = New System.Drawing.Point(153, 311)
        Me.btnImagePick.Name = "btnImagePick"
        Me.btnImagePick.ShadowDecoration.Parent = Me.btnImagePick
        Me.btnImagePick.Size = New System.Drawing.Size(289, 36)
        Me.btnImagePick.TabIndex = 3
        Me.btnImagePick.Text = "Choose Item From File"
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.CheckedState.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.CustomImages.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.FillColor = System.Drawing.Color.Peru
        Me.btnSaveProduct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProduct.ForeColor = System.Drawing.Color.White
        Me.btnSaveProduct.HoverState.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.Location = New System.Drawing.Point(431, 402)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.ShadowDecoration.Parent = Me.btnSaveProduct
        Me.btnSaveProduct.Size = New System.Drawing.Size(160, 36)
        Me.btnSaveProduct.TabIndex = 3
        Me.btnSaveProduct.Text = "Save Product"
        '
        'btnClose
        '
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Peru
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(597, 402)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(107, 36)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'Open_Timer
        '
        Me.Open_Timer.Enabled = True
        Me.Open_Timer.Interval = 8
        '
        'pic_foodimg
        '
        Me.pic_foodimg.Location = New System.Drawing.Point(476, 84)
        Me.pic_foodimg.Name = "pic_foodimg"
        Me.pic_foodimg.Size = New System.Drawing.Size(217, 263)
        Me.pic_foodimg.TabIndex = 4
        Me.pic_foodimg.TabStop = False
        '
        'ProductsPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 450)
        Me.Controls.Add(Me.pic_foodimg)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveProduct)
        Me.Controls.Add(Me.btnImagePick)
        Me.Controls.Add(Me.Guna2TextBox4)
        Me.Controls.Add(Me.txtProdPrice)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductsPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ProductsPopUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_foodimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProdPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnImagePick As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Open_Timer As Timer
    Friend WithEvents pic_foodimg As PictureBox
    Friend WithEvents Label5 As Label
End Class
