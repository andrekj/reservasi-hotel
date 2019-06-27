<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
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
        Me.DGKaryawan = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.GroupBoxkary = New System.Windows.Forms.GroupBox()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.RichTextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTelpon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdkaryawan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxkary.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.GroupBox1.Controls.Add(Me.DGKaryawan)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnBack)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 602)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'DGKaryawan
        '
        Me.DGKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKaryawan.Location = New System.Drawing.Point(42, 134)
        Me.DGKaryawan.Name = "DGKaryawan"
        Me.DGKaryawan.Size = New System.Drawing.Size(706, 206)
        Me.DGKaryawan.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(56, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 18)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Search"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.TxtCari)
        Me.GroupBox2.Location = New System.Drawing.Point(117, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 29)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(91, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(365, 47)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "DATA KARYAWAN"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnUbah)
        Me.Panel1.Controls.Add(Me.btnCetak)
        Me.Panel1.Controls.Add(Me.BtnTambah)
        Me.Panel1.Controls.Add(Me.BtnSimpan)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.GroupBoxkary)
        Me.Panel1.Controls.Add(Me.BtnBatal)
        Me.Panel1.Location = New System.Drawing.Point(-31, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 279)
        Me.Panel1.TabIndex = 145
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.Transparent
        Me.BtnUbah.BackgroundImage = Global.Hotel.My.Resources.Resources.update
        Me.BtnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUbah.FlatAppearance.BorderSize = 0
        Me.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUbah.Location = New System.Drawing.Point(70, 196)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(60, 60)
        Me.BtnUbah.TabIndex = 134
        Me.BtnUbah.Text = " "
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Transparent
        Me.btnCetak.BackgroundImage = Global.Hotel.My.Resources.Resources.print
        Me.btnCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCetak.Location = New System.Drawing.Point(524, 196)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(60, 60)
        Me.btnCetak.TabIndex = 142
        Me.btnCetak.Text = " "
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Transparent
        Me.BtnTambah.BackgroundImage = Global.Hotel.My.Resources.Resources.add2
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambah.Location = New System.Drawing.Point(256, 196)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(60, 60)
        Me.BtnTambah.TabIndex = 136
        Me.BtnTambah.Text = " "
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.BtnSimpan.BackgroundImage = Global.Hotel.My.Resources.Resources.save
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSimpan.FlatAppearance.BorderSize = 0
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSimpan.Location = New System.Drawing.Point(351, 196)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(60, 60)
        Me.BtnSimpan.TabIndex = 132
        Me.BtnSimpan.Text = " "
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Transparent
        Me.BtnHapus.BackgroundImage = Global.Hotel.My.Resources.Resources.delete2
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapus.Location = New System.Drawing.Point(160, 196)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(60, 60)
        Me.BtnHapus.TabIndex = 135
        Me.BtnHapus.Text = " "
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'GroupBoxkary
        '
        Me.GroupBoxkary.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxkary.Controls.Add(Me.LblBaris)
        Me.GroupBoxkary.Controls.Add(Me.TxtAlamat)
        Me.GroupBoxkary.Controls.Add(Me.TxtPass)
        Me.GroupBoxkary.Controls.Add(Me.Label5)
        Me.GroupBoxkary.Controls.Add(Me.TxtNama)
        Me.GroupBoxkary.Controls.Add(Me.Label4)
        Me.GroupBoxkary.Controls.Add(Me.TxtTelpon)
        Me.GroupBoxkary.Controls.Add(Me.Label3)
        Me.GroupBoxkary.Controls.Add(Me.TxtIdkaryawan)
        Me.GroupBoxkary.Controls.Add(Me.Label2)
        Me.GroupBoxkary.Controls.Add(Me.Label1)
        Me.GroupBoxkary.Location = New System.Drawing.Point(73, 29)
        Me.GroupBoxkary.Name = "GroupBoxkary"
        Me.GroupBoxkary.Size = New System.Drawing.Size(706, 161)
        Me.GroupBoxkary.TabIndex = 38
        Me.GroupBoxkary.TabStop = False
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblBaris.Location = New System.Drawing.Point(7, 11)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(72, 18)
        Me.LblBaris.TabIndex = 141
        Me.LblBaris.Text = "Data ke-"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAlamat.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtAlamat.Location = New System.Drawing.Point(484, 72)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(195, 56)
        Me.TxtAlamat.TabIndex = 6
        Me.TxtAlamat.Text = ""
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPass.Location = New System.Drawing.Point(139, 110)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(195, 18)
        Me.TxtPass.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(17, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password"
        '
        'TxtNama
        '
        Me.TxtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNama.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNama.Location = New System.Drawing.Point(139, 75)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(195, 18)
        Me.TxtNama.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(379, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'TxtTelpon
        '
        Me.TxtTelpon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelpon.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtTelpon.Location = New System.Drawing.Point(484, 41)
        Me.TxtTelpon.Name = "TxtTelpon"
        Me.TxtTelpon.Size = New System.Drawing.Size(195, 18)
        Me.TxtTelpon.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(379, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No Telpon"
        '
        'TxtIdkaryawan
        '
        Me.TxtIdkaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdkaryawan.Enabled = False
        Me.TxtIdkaryawan.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtIdkaryawan.Location = New System.Drawing.Point(139, 45)
        Me.TxtIdkaryawan.Name = "TxtIdkaryawan"
        Me.TxtIdkaryawan.Size = New System.Drawing.Size(195, 18)
        Me.TxtIdkaryawan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(17, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(17, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "kd Karyawan"
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Transparent
        Me.BtnBatal.BackgroundImage = Global.Hotel.My.Resources.Resources.cancel
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBatal.FlatAppearance.BorderSize = 0
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBatal.Location = New System.Drawing.Point(439, 196)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(60, 60)
        Me.BtnBatal.TabIndex = 133
        Me.BtnBatal.Text = " "
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'FrmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 586)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEmployee"
        Me.Text = "FrmKaryawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxkary.ResumeLayout(False)
        Me.GroupBoxkary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBoxkary As GroupBox
    Friend WithEvents TxtAlamat As RichTextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelpon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdkaryawan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents DGKaryawan As DataGridView
    Friend WithEvents LblBaris As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Panel1 As Panel
End Class
