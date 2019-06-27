<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnLoginCu = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnLoginAd = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtUname = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.BtnLoginCu)
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.BtnLoginAd)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 424)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Hotel.My.Resources.Resources.password
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(60, 217)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 40)
        Me.PictureBox1.TabIndex = 141
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(97, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE LOGIN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Hotel.My.Resources.Resources.account2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(60, 169)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 40)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'BtnLoginCu
        '
        Me.BtnLoginCu.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BtnLoginCu.FlatAppearance.BorderSize = 0
        Me.BtnLoginCu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginCu.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLoginCu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLoginCu.Location = New System.Drawing.Point(130, 325)
        Me.BtnLoginCu.Name = "BtnLoginCu"
        Me.BtnLoginCu.Size = New System.Drawing.Size(197, 36)
        Me.BtnLoginCu.TabIndex = 140
        Me.BtnLoginCu.Text = "Login Form Customer"
        Me.BtnLoginCu.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Transparent
        Me.BtnBack.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(13, 14)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(50, 50)
        Me.BtnBack.TabIndex = 139
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnLoginAd
        '
        Me.BtnLoginAd.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BtnLoginAd.FlatAppearance.BorderSize = 0
        Me.BtnLoginAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginAd.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLoginAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLoginAd.Location = New System.Drawing.Point(130, 275)
        Me.BtnLoginAd.Name = "BtnLoginAd"
        Me.BtnLoginAd.Size = New System.Drawing.Size(197, 36)
        Me.BtnLoginAd.TabIndex = 9
        Me.BtnLoginAd.Text = "Login Form Admin"
        Me.BtnLoginAd.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.TxtUname)
        Me.Panel5.Location = New System.Drawing.Point(116, 173)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(226, 30)
        Me.Panel5.TabIndex = 8
        '
        'TxtUname
        '
        Me.TxtUname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtUname.Location = New System.Drawing.Point(3, 3)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.Size = New System.Drawing.Size(220, 24)
        Me.TxtUname.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Controls.Add(Me.TxtPass)
        Me.Panel4.Location = New System.Drawing.Point(116, 222)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(226, 31)
        Me.Panel4.TabIndex = 7
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtPass.Location = New System.Drawing.Point(3, 4)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(220, 24)
        Me.TxtPass.TabIndex = 4
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 413)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtUname As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnLoginAd As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnLoginCu As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
