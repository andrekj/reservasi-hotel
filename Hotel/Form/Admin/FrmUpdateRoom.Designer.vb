<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateRoom
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKdTipe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTipeKmr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNama_Kmr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFasilitas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga_Kmr = New System.Windows.Forms.TextBox()
        Me.CmbTersedia = New System.Windows.Forms.ComboBox()
        Me.TxtKdKamar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-5, -8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 509)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtKdTipe)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtTipeKmr)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNama_Kmr)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtFasilitas)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtHarga_Kmr)
        Me.GroupBox2.Controls.Add(Me.CmbTersedia)
        Me.GroupBox2.Controls.Add(Me.TxtKdKamar)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 291)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kd Kamar"
        '
        'TxtKdTipe
        '
        Me.TxtKdTipe.BackColor = System.Drawing.SystemColors.Window
        Me.TxtKdTipe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKdTipe.Enabled = False
        Me.TxtKdTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtKdTipe.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtKdTipe.Location = New System.Drawing.Point(390, 29)
        Me.TxtKdTipe.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKdTipe.Name = "TxtKdTipe"
        Me.TxtKdTipe.ReadOnly = True
        Me.TxtKdTipe.Size = New System.Drawing.Size(116, 16)
        Me.TxtKdTipe.TabIndex = 26
        Me.TxtKdTipe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(287, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Kd Tipe "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(286, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipe Kamar"
        '
        'TxtTipeKmr
        '
        Me.TxtTipeKmr.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTipeKmr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipeKmr.Enabled = False
        Me.TxtTipeKmr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtTipeKmr.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtTipeKmr.Location = New System.Drawing.Point(390, 57)
        Me.TxtTipeKmr.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTipeKmr.Name = "TxtTipeKmr"
        Me.TxtTipeKmr.ReadOnly = True
        Me.TxtTipeKmr.Size = New System.Drawing.Size(116, 16)
        Me.TxtTipeKmr.TabIndex = 24
        Me.TxtTipeKmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(2, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Harga Kamar"
        '
        'TxtNama_Kmr
        '
        Me.TxtNama_Kmr.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNama_Kmr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNama_Kmr.Enabled = False
        Me.TxtNama_Kmr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtNama_Kmr.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtNama_Kmr.Location = New System.Drawing.Point(120, 57)
        Me.TxtNama_Kmr.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNama_Kmr.Name = "TxtNama_Kmr"
        Me.TxtNama_Kmr.ReadOnly = True
        Me.TxtNama_Kmr.Size = New System.Drawing.Size(116, 16)
        Me.TxtNama_Kmr.TabIndex = 23
        Me.TxtNama_Kmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(3, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fasilitas"
        '
        'txtFasilitas
        '
        Me.txtFasilitas.BackColor = System.Drawing.SystemColors.Window
        Me.txtFasilitas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFasilitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFasilitas.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtFasilitas.Location = New System.Drawing.Point(27, 135)
        Me.txtFasilitas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFasilitas.Multiline = True
        Me.txtFasilitas.Name = "txtFasilitas"
        Me.txtFasilitas.Size = New System.Drawing.Size(209, 137)
        Me.txtFasilitas.TabIndex = 22
        Me.txtFasilitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(288, 88)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Tersedia"
        '
        'txtHarga_Kmr
        '
        Me.txtHarga_Kmr.BackColor = System.Drawing.SystemColors.Window
        Me.txtHarga_Kmr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga_Kmr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtHarga_Kmr.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtHarga_Kmr.Location = New System.Drawing.Point(120, 88)
        Me.txtHarga_Kmr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga_Kmr.Name = "txtHarga_Kmr"
        Me.txtHarga_Kmr.Size = New System.Drawing.Size(116, 16)
        Me.txtHarga_Kmr.TabIndex = 19
        Me.txtHarga_Kmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbTersedia
        '
        Me.CmbTersedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTersedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CmbTersedia.FormattingEnabled = True
        Me.CmbTersedia.Items.AddRange(New Object() {"Y", "N"})
        Me.CmbTersedia.Location = New System.Drawing.Point(390, 85)
        Me.CmbTersedia.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbTersedia.Name = "CmbTersedia"
        Me.CmbTersedia.Size = New System.Drawing.Size(116, 24)
        Me.CmbTersedia.TabIndex = 15
        '
        'TxtKdKamar
        '
        Me.TxtKdKamar.BackColor = System.Drawing.SystemColors.Window
        Me.TxtKdKamar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKdKamar.Enabled = False
        Me.TxtKdKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtKdKamar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtKdKamar.Location = New System.Drawing.Point(120, 27)
        Me.TxtKdKamar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKdKamar.Name = "TxtKdKamar"
        Me.TxtKdKamar.ReadOnly = True
        Me.TxtKdKamar.Size = New System.Drawing.Size(116, 16)
        Me.TxtKdKamar.TabIndex = 18
        Me.TxtKdKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(218, 444)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 39)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(614, 126)
        Me.Panel2.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(140, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(302, 47)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "UPDATE ROOM"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(21, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "        Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FrmUpdateRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 495)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmUpdateRoom"
        Me.Text = "UpdateRoom"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents CmbTersedia As ComboBox
    Public WithEvents Label9 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Public WithEvents TxtTipeKmr As TextBox
    Public WithEvents TxtNama_Kmr As TextBox
    Public WithEvents txtFasilitas As TextBox
    Public WithEvents txtHarga_Kmr As TextBox
    Public WithEvents TxtKdKamar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtKdTipe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
