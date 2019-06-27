<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateRes
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
        Me.txtSpesial_request = New System.Windows.Forms.TextBox()
        Me.txtKd_tamu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPCheckin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKd_kamar = New System.Windows.Forms.TextBox()
        Me.txtTotal_price = New System.Windows.Forms.TextBox()
        Me.txtHarga_kamar = New System.Windows.Forms.TextBox()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtKd_reservasi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 507)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.txtSpesial_request)
        Me.GroupBox2.Controls.Add(Me.txtKd_tamu)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DTPCheckin)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DTPCheckout)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtKd_kamar)
        Me.GroupBox2.Controls.Add(Me.txtTotal_price)
        Me.GroupBox2.Controls.Add(Me.txtHarga_kamar)
        Me.GroupBox2.Controls.Add(Me.CmbStatus)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtKd_reservasi)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 291)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'txtSpesial_request
        '
        Me.txtSpesial_request.BackColor = System.Drawing.Color.White
        Me.txtSpesial_request.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSpesial_request.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSpesial_request.Location = New System.Drawing.Point(16, 152)
        Me.txtSpesial_request.Multiline = True
        Me.txtSpesial_request.Name = "txtSpesial_request"
        Me.txtSpesial_request.ReadOnly = True
        Me.txtSpesial_request.Size = New System.Drawing.Size(227, 104)
        Me.txtSpesial_request.TabIndex = 39
        '
        'txtKd_tamu
        '
        Me.txtKd_tamu.BackColor = System.Drawing.SystemColors.Window
        Me.txtKd_tamu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKd_tamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtKd_tamu.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtKd_tamu.Location = New System.Drawing.Point(382, 28)
        Me.txtKd_tamu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKd_tamu.Name = "txtKd_tamu"
        Me.txtKd_tamu.ReadOnly = True
        Me.txtKd_tamu.Size = New System.Drawing.Size(115, 16)
        Me.txtKd_tamu.TabIndex = 36
        Me.txtKd_tamu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(284, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Guest ID"
        '
        'DTPCheckin
        '
        Me.DTPCheckin.CustomFormat = "dd MMM yyyy"
        Me.DTPCheckin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DTPCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPCheckin.Location = New System.Drawing.Point(382, 49)
        Me.DTPCheckin.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPCheckin.Name = "DTPCheckin"
        Me.DTPCheckin.Size = New System.Drawing.Size(115, 23)
        Me.DTPCheckin.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(284, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Check-in"
        '
        'DTPCheckout
        '
        Me.DTPCheckout.CustomFormat = "dd MMM yyyy"
        Me.DTPCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DTPCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPCheckout.Location = New System.Drawing.Point(382, 76)
        Me.DTPCheckout.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPCheckout.Name = "DTPCheckout"
        Me.DTPCheckout.Size = New System.Drawing.Size(115, 23)
        Me.DTPCheckout.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(284, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Check-out"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(3, 131)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Special Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Res ID"
        '
        'txtKd_kamar
        '
        Me.txtKd_kamar.BackColor = System.Drawing.SystemColors.Window
        Me.txtKd_kamar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKd_kamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_kamar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtKd_kamar.Location = New System.Drawing.Point(102, 53)
        Me.txtKd_kamar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKd_kamar.Name = "txtKd_kamar"
        Me.txtKd_kamar.ReadOnly = True
        Me.txtKd_kamar.Size = New System.Drawing.Size(117, 16)
        Me.txtKd_kamar.TabIndex = 31
        Me.txtKd_kamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal_price
        '
        Me.txtTotal_price.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_price.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTotal_price.Location = New System.Drawing.Point(103, 102)
        Me.txtTotal_price.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal_price.Name = "txtTotal_price"
        Me.txtTotal_price.ReadOnly = True
        Me.txtTotal_price.Size = New System.Drawing.Size(116, 16)
        Me.txtTotal_price.TabIndex = 21
        Me.txtTotal_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHarga_kamar
        '
        Me.txtHarga_kamar.BackColor = System.Drawing.SystemColors.Window
        Me.txtHarga_kamar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga_kamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga_kamar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtHarga_kamar.Location = New System.Drawing.Point(103, 78)
        Me.txtHarga_kamar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga_kamar.Name = "txtHarga_kamar"
        Me.txtHarga_kamar.ReadOnly = True
        Me.txtHarga_kamar.Size = New System.Drawing.Size(116, 16)
        Me.txtHarga_kamar.TabIndex = 22
        Me.txtHarga_kamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbStatus
        '
        Me.CmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"Unconfirmed", "Confirmed"})
        Me.CmbStatus.Location = New System.Drawing.Point(381, 103)
        Me.CmbStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(116, 24)
        Me.CmbStatus.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(284, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Status"
        '
        'txtKd_reservasi
        '
        Me.txtKd_reservasi.BackColor = System.Drawing.SystemColors.Window
        Me.txtKd_reservasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKd_reservasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_reservasi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtKd_reservasi.Location = New System.Drawing.Point(102, 28)
        Me.txtKd_reservasi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKd_reservasi.Name = "txtKd_reservasi"
        Me.txtKd_reservasi.ReadOnly = True
        Me.txtKd_reservasi.Size = New System.Drawing.Size(117, 16)
        Me.txtKd_reservasi.TabIndex = 18
        Me.txtKd_reservasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(9, 100)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(10, 50)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Kd Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(10, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Price"
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
        Me.Panel2.Size = New System.Drawing.Size(599, 126)
        Me.Panel2.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(91, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(434, 47)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "UPDATE RESERVATION"
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
        Me.Button5.Location = New System.Drawing.Point(15, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "        Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FrmUpdateRes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 495)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmUpdateRes"
        Me.Text = "UpdateRes"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents txtHarga_kamar As TextBox
    Public WithEvents txtTotal_price As TextBox
    Public WithEvents txtKd_reservasi As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button
    Public WithEvents CmbStatus As ComboBox
    Public WithEvents Label9 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents txtKd_kamar As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents txtKd_tamu As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents DTPCheckin As DateTimePicker
    Public WithEvents Label2 As Label
    Public WithEvents DTPCheckout As DateTimePicker
    Public WithEvents Label3 As Label
    Public WithEvents Label7 As Label
    Friend WithEvents txtSpesial_request As TextBox
End Class
