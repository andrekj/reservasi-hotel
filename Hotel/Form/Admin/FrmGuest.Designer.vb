<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGuest
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.DGTamu = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtIdtamu = New System.Windows.Forms.TextBox()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DGTamu)
        Me.GroupBox1.Controls.Add(Me.BtnBack)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 608)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Transparent
        Me.btnCetak.BackgroundImage = Global.Hotel.My.Resources.Resources.print
        Me.btnCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Location = New System.Drawing.Point(159, 196)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(60, 60)
        Me.btnCetak.TabIndex = 142
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'DGTamu
        '
        Me.DGTamu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTamu.Location = New System.Drawing.Point(42, 134)
        Me.DGTamu.Name = "DGTamu"
        Me.DGTamu.Size = New System.Drawing.Size(706, 367)
        Me.DGTamu.TabIndex = 139
        '
        'BtnBack
        '
        Me.BtnBack.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(15, 15)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(50, 50)
        Me.BtnBack.TabIndex = 138
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Transparent
        Me.BtnHapus.BackgroundImage = Global.Hotel.My.Resources.Resources.delete2
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(58, 196)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(60, 60)
        Me.BtnHapus.TabIndex = 135
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(96, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 47)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "GUEST DATA"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCetak)
        Me.Panel1.Controls.Add(Me.TxtIdtamu)
        Me.Panel1.Controls.Add(Me.LblBaris)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Location = New System.Drawing.Point(0, 314)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 288)
        Me.Panel1.TabIndex = 143
        '
        'TxtIdtamu
        '
        Me.TxtIdtamu.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtIdtamu.Location = New System.Drawing.Point(451, 193)
        Me.TxtIdtamu.Name = "TxtIdtamu"
        Me.TxtIdtamu.Size = New System.Drawing.Size(78, 25)
        Me.TxtIdtamu.TabIndex = 140
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblBaris.Location = New System.Drawing.Point(541, 196)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(72, 18)
        Me.LblBaris.TabIndex = 141
        Me.LblBaris.Text = "Data ke-"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox3.Controls.Add(Me.TxtCari)
        Me.GroupBox3.Location = New System.Drawing.Point(100, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 29)
        Me.GroupBox3.TabIndex = 137
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(39, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Search"
        '
        'TxtCari
        '
        Me.TxtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCari.Location = New System.Drawing.Point(4, 4)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(333, 20)
        Me.TxtCari.TabIndex = 130
        '
        'FrmGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 586)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmGuest"
        Me.Text = "FrmGuest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGTamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents LblBaris As Label
    Friend WithEvents TxtIdtamu As TextBox
    Friend WithEvents DGTamu As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCari As TextBox
End Class
