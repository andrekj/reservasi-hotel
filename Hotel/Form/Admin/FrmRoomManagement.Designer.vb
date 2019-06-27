<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRoomManagement
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.TxtKdKamar = New System.Windows.Forms.TextBox()
        Me.btnTmbhTp = New System.Windows.Forms.Button()
        Me.DGKamar = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnHps = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.DGKamar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 588)
        Me.Panel1.TabIndex = 0
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Transparent
        Me.btnCetak.BackgroundImage = Global.Hotel.My.Resources.Resources.print
        Me.btnCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Location = New System.Drawing.Point(384, 196)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(60, 60)
        Me.btnCetak.TabIndex = 143
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblBaris.Location = New System.Drawing.Point(574, 183)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(72, 18)
        Me.LblBaris.TabIndex = 140
        Me.LblBaris.Text = "Data ke-"
        '
        'TxtKdKamar
        '
        Me.TxtKdKamar.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtKdKamar.Location = New System.Drawing.Point(506, 180)
        Me.TxtKdKamar.Name = "TxtKdKamar"
        Me.TxtKdKamar.ReadOnly = True
        Me.TxtKdKamar.Size = New System.Drawing.Size(62, 25)
        Me.TxtKdKamar.TabIndex = 139
        '
        'btnTmbhTp
        '
        Me.btnTmbhTp.BackColor = System.Drawing.Color.Transparent
        Me.btnTmbhTp.BackgroundImage = Global.Hotel.My.Resources.Resources.add2
        Me.btnTmbhTp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTmbhTp.FlatAppearance.BorderSize = 0
        Me.btnTmbhTp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTmbhTp.Font = New System.Drawing.Font("Keep Calm", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTmbhTp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTmbhTp.Location = New System.Drawing.Point(307, 196)
        Me.btnTmbhTp.Name = "btnTmbhTp"
        Me.btnTmbhTp.Size = New System.Drawing.Size(60, 60)
        Me.btnTmbhTp.TabIndex = 138
        Me.btnTmbhTp.Text = "Type"
        Me.btnTmbhTp.UseVisualStyleBackColor = False
        '
        'DGKamar
        '
        Me.DGKamar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGKamar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKamar.Location = New System.Drawing.Point(42, 94)
        Me.DGKamar.MultiSelect = False
        Me.DGKamar.Name = "DGKamar"
        Me.DGKamar.Size = New System.Drawing.Size(706, 394)
        Me.DGKamar.TabIndex = 137
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Hotel.My.Resources.Resources.update
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(58, 196)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 60)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnCetak)
        Me.Panel2.Controls.Add(Me.btnHps)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.LblBaris)
        Me.Panel2.Controls.Add(Me.btnTmbhTp)
        Me.Panel2.Controls.Add(Me.TxtKdKamar)
        Me.Panel2.Location = New System.Drawing.Point(-7, 314)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(810, 273)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(79, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ROOM MANAGEMENT"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(15, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "        Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Hotel.My.Resources.Resources.add2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(225, 196)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 60)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnHps
        '
        Me.btnHps.BackColor = System.Drawing.Color.Transparent
        Me.btnHps.BackgroundImage = Global.Hotel.My.Resources.Resources.delete2
        Me.btnHps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHps.FlatAppearance.BorderSize = 0
        Me.btnHps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHps.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHps.Location = New System.Drawing.Point(141, 196)
        Me.btnHps.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHps.Name = "btnHps"
        Me.btnHps.Size = New System.Drawing.Size(60, 60)
        Me.btnHps.TabIndex = 6
        Me.btnHps.UseVisualStyleBackColor = False
        '
        'FrmRoomManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 586)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRoomManagement"
        Me.Text = "RoomManagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnHps As Button
    Friend WithEvents DGKamar As DataGridView
    Friend WithEvents btnTmbhTp As Button
    Friend WithEvents TxtKdKamar As TextBox
    Friend WithEvents LblBaris As Label
    Friend WithEvents btnCetak As Button
End Class
