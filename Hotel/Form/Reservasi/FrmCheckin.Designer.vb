<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCheckin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCheckin))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSaveNext = New System.Windows.Forms.Button()
        Me.TglCheckin = New System.Windows.Forms.DateTimePicker()
        Me.txthari = New System.Windows.Forms.TextBox()
        Me.TglCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtTransaksi = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 62)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(101, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 39)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Check-in"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(375, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 39)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Check-out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(641, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 39)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nights"
        '
        'BtnSaveNext
        '
        Me.BtnSaveNext.BackColor = System.Drawing.Color.Transparent
        Me.BtnSaveNext.BackgroundImage = CType(resources.GetObject("BtnSaveNext.BackgroundImage"), System.Drawing.Image)
        Me.BtnSaveNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSaveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveNext.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSaveNext.Location = New System.Drawing.Point(517, 550)
        Me.BtnSaveNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSaveNext.Name = "BtnSaveNext"
        Me.BtnSaveNext.Size = New System.Drawing.Size(67, 62)
        Me.BtnSaveNext.TabIndex = 48
        Me.BtnSaveNext.UseVisualStyleBackColor = False
        '
        'TglCheckin
        '
        Me.TglCheckin.CustomFormat = "dd MMM yyyy"
        Me.TglCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglCheckin.Location = New System.Drawing.Point(109, 156)
        Me.TglCheckin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TglCheckin.Name = "TglCheckin"
        Me.TglCheckin.Size = New System.Drawing.Size(188, 22)
        Me.TglCheckin.TabIndex = 58
        '
        'txthari
        '
        Me.txthari.Location = New System.Drawing.Point(649, 156)
        Me.txthari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txthari.Name = "txthari"
        Me.txthari.ReadOnly = True
        Me.txthari.Size = New System.Drawing.Size(101, 22)
        Me.txthari.TabIndex = 57
        Me.txthari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TglCheckout
        '
        Me.TglCheckout.CustomFormat = "dd MMM yyyy"
        Me.TglCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglCheckout.Location = New System.Drawing.Point(383, 156)
        Me.TglCheckout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TglCheckout.Name = "TglCheckout"
        Me.TglCheckout.Size = New System.Drawing.Size(188, 22)
        Me.TglCheckout.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.TglCheckin)
        Me.Panel1.Controls.Add(Me.TxtTransaksi)
        Me.Panel1.Controls.Add(Me.txthari)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TglCheckout)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(93, 286)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 258)
        Me.Panel1.TabIndex = 49
        '
        'TxtTransaksi
        '
        Me.TxtTransaksi.Enabled = False
        Me.TxtTransaksi.Location = New System.Drawing.Point(191, 18)
        Me.TxtTransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTransaksi.Name = "TxtTransaksi"
        Me.TxtTransaksi.Size = New System.Drawing.Size(132, 22)
        Me.TxtTransaksi.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(31, 18)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 22)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Reservation ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(36, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(480, 76)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Hi, Welcome.. "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(431, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 185)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'FrmCheckin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.ClientSize = New System.Drawing.Size(1054, 625)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSaveNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmCheckin"
        Me.Text = "Checkin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSaveNext As Button
    Friend WithEvents TglCheckin As DateTimePicker
    Friend WithEvents txthari As TextBox
    Friend WithEvents TglCheckout As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtTransaksi As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
