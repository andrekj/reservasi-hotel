<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReservation
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
        Me.btnHAPUS = New System.Windows.Forms.Button()
        Me.btnUBAH = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGReservasi = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.TxtKdRes = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DGReservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHAPUS
        '
        Me.btnHAPUS.BackgroundImage = Global.Hotel.My.Resources.Resources.delete2
        Me.btnHAPUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHAPUS.FlatAppearance.BorderSize = 0
        Me.btnHAPUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHAPUS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHAPUS.Location = New System.Drawing.Point(156, 509)
        Me.btnHAPUS.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHAPUS.Name = "btnHAPUS"
        Me.btnHAPUS.Size = New System.Drawing.Size(60, 60)
        Me.btnHAPUS.TabIndex = 2
        Me.btnHAPUS.UseVisualStyleBackColor = True
        '
        'btnUBAH
        '
        Me.btnUBAH.BackgroundImage = Global.Hotel.My.Resources.Resources.update
        Me.btnUBAH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUBAH.FlatAppearance.BorderSize = 0
        Me.btnUBAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUBAH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUBAH.Location = New System.Drawing.Point(61, 509)
        Me.btnUBAH.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUBAH.Name = "btnUBAH"
        Me.btnUBAH.Size = New System.Drawing.Size(60, 60)
        Me.btnUBAH.TabIndex = 5
        Me.btnUBAH.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Location = New System.Drawing.Point(-1, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 311)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(94, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RESERVATION"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(15, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 0
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DGReservasi
        '
        Me.DGReservasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReservasi.Location = New System.Drawing.Point(42, 94)
        Me.DGReservasi.Margin = New System.Windows.Forms.Padding(2)
        Me.DGReservasi.Name = "DGReservasi"
        Me.DGReservasi.RowTemplate.Height = 24
        Me.DGReservasi.Size = New System.Drawing.Size(706, 394)
        Me.DGReservasi.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnCetak)
        Me.Panel1.Controls.Add(Me.LblBaris)
        Me.Panel1.Controls.Add(Me.btnUBAH)
        Me.Panel1.Controls.Add(Me.DGReservasi)
        Me.Panel1.Controls.Add(Me.TxtKdRes)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnHAPUS)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 589)
        Me.Panel1.TabIndex = 1
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Transparent
        Me.btnCetak.BackgroundImage = Global.Hotel.My.Resources.Resources.print
        Me.btnCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Location = New System.Drawing.Point(255, 511)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(60, 60)
        Me.btnCetak.TabIndex = 144
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblBaris.Location = New System.Drawing.Point(549, 498)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(72, 18)
        Me.LblBaris.TabIndex = 141
        Me.LblBaris.Text = "Data ke-"
        '
        'TxtKdRes
        '
        Me.TxtKdRes.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TxtKdRes.Location = New System.Drawing.Point(435, 493)
        Me.TxtKdRes.Name = "TxtKdRes"
        Me.TxtKdRes.ReadOnly = True
        Me.TxtKdRes.Size = New System.Drawing.Size(97, 25)
        Me.TxtKdRes.TabIndex = 140
        '
        'FrmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 586)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmReservation"
        Me.Text = "Reservation"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGReservasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHAPUS As Button
    Friend WithEvents btnUBAH As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DGReservasi As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtKdRes As TextBox
    Friend WithEvents LblBaris As Label
    Friend WithEvents btnCetak As Button
End Class
