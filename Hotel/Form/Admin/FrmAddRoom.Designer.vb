<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddRoom
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtFasilitas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtKdKamar = New System.Windows.Forms.TextBox()
        Me.CmbTipe = New System.Windows.Forms.ComboBox()
        Me.TxtNamaTp = New System.Windows.Forms.TextBox()
        Me.CmbTersedia = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnTmbh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.TxtFasilitas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtKdKamar)
        Me.GroupBox2.Controls.Add(Me.CmbTipe)
        Me.GroupBox2.Controls.Add(Me.TxtNamaTp)
        Me.GroupBox2.Controls.Add(Me.CmbTersedia)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNama)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtHarga)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 291)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'TxtFasilitas
        '
        Me.TxtFasilitas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFasilitas.Location = New System.Drawing.Point(21, 140)
        Me.TxtFasilitas.Multiline = True
        Me.TxtFasilitas.Name = "TxtFasilitas"
        Me.TxtFasilitas.Size = New System.Drawing.Size(209, 137)
        Me.TxtFasilitas.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(4, 90)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Harga Kamar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(280, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Tipe Kamar"
        '
        'TxtKdKamar
        '
        Me.TxtKdKamar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKdKamar.Location = New System.Drawing.Point(112, 31)
        Me.TxtKdKamar.Name = "TxtKdKamar"
        Me.TxtKdKamar.ReadOnly = True
        Me.TxtKdKamar.Size = New System.Drawing.Size(116, 13)
        Me.TxtKdKamar.TabIndex = 36
        '
        'CmbTipe
        '
        Me.CmbTipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTipe.FormattingEnabled = True
        Me.CmbTipe.Location = New System.Drawing.Point(392, 25)
        Me.CmbTipe.Name = "CmbTipe"
        Me.CmbTipe.Size = New System.Drawing.Size(116, 21)
        Me.CmbTipe.TabIndex = 35
        '
        'TxtNamaTp
        '
        Me.TxtNamaTp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNamaTp.Location = New System.Drawing.Point(392, 58)
        Me.TxtNamaTp.Name = "TxtNamaTp"
        Me.TxtNamaTp.Size = New System.Drawing.Size(116, 13)
        Me.TxtNamaTp.TabIndex = 17
        '
        'CmbTersedia
        '
        Me.CmbTersedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTersedia.FormattingEnabled = True
        Me.CmbTersedia.Items.AddRange(New Object() {"y", "t"})
        Me.CmbTersedia.Location = New System.Drawing.Point(392, 90)
        Me.CmbTersedia.Name = "CmbTersedia"
        Me.CmbTersedia.Size = New System.Drawing.Size(116, 21)
        Me.CmbTersedia.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(282, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tersedia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fasilitas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(282, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kd Tipe "
        '
        'TxtNama
        '
        Me.TxtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNama.Location = New System.Drawing.Point(112, 59)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(116, 13)
        Me.TxtNama.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(2, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nama Kamar"
        '
        'TxtHarga
        '
        Me.TxtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtHarga.Location = New System.Drawing.Point(112, 90)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(116, 13)
        Me.TxtHarga.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(2, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kd Kamar"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(15, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 96
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnTmbh
        '
        Me.btnTmbh.BackColor = System.Drawing.Color.Transparent
        Me.btnTmbh.BackgroundImage = Global.Hotel.My.Resources.Resources.add2
        Me.btnTmbh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTmbh.FlatAppearance.BorderSize = 0
        Me.btnTmbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTmbh.Location = New System.Drawing.Point(512, 433)
        Me.btnTmbh.Name = "btnTmbh"
        Me.btnTmbh.Size = New System.Drawing.Size(50, 50)
        Me.btnTmbh.TabIndex = 95
        Me.btnTmbh.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 150)
        Me.Panel1.TabIndex = 97
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(176, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(244, 47)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "ADD ROOM"
        '
        'FrmAddRoom
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.ClientSize = New System.Drawing.Size(592, 495)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTmbh)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddRoom"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAddRoom"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbTersedia As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnTmbh As Button
    Friend WithEvents TxtNamaTp As TextBox
    Friend WithEvents CmbTipe As ComboBox
    Friend WithEvents TxtKdKamar As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents Label7 As Label
    Friend WithEvents TxtFasilitas As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
End Class
