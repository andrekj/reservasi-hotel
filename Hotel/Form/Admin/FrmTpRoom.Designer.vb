<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTpRoom
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
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamaTipe = New System.Windows.Forms.TextBox()
        Me.txtKdTipe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGTipe = New System.Windows.Forms.DataGridView()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.btnTmbh = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.Panel1.Controls.Add(Me.BtnBatal)
        Me.Panel1.Controls.Add(Me.BtnSimpan)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DGTipe)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.btnTmbh)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 495)
        Me.Panel1.TabIndex = 0
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Transparent
        Me.BtnBatal.BackgroundImage = Global.Hotel.My.Resources.Resources.cancel
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBatal.FlatAppearance.BorderSize = 0
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Location = New System.Drawing.Point(215, 295)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(60, 60)
        Me.BtnBatal.TabIndex = 20
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.BtnSimpan.BackgroundImage = Global.Hotel.My.Resources.Resources.save
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSimpan.FlatAppearance.BorderSize = 0
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Location = New System.Drawing.Point(95, 295)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(60, 60)
        Me.BtnSimpan.TabIndex = 19
        Me.BtnSimpan.Text = " "
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.txtNamaTipe)
        Me.GroupBox1.Controls.Add(Me.txtKdTipe)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(19, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'txtNamaTipe
        '
        Me.txtNamaTipe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNamaTipe.Location = New System.Drawing.Point(90, 58)
        Me.txtNamaTipe.Name = "txtNamaTipe"
        Me.txtNamaTipe.Size = New System.Drawing.Size(153, 16)
        Me.txtNamaTipe.TabIndex = 19
        '
        'txtKdTipe
        '
        Me.txtKdTipe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKdTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtKdTipe.Location = New System.Drawing.Point(90, 22)
        Me.txtKdTipe.Name = "txtKdTipe"
        Me.txtKdTipe.Size = New System.Drawing.Size(153, 16)
        Me.txtKdTipe.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama Tipe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kd Tipe"
        '
        'DGTipe
        '
        Me.DGTipe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGTipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTipe.Location = New System.Drawing.Point(304, 104)
        Me.DGTipe.Name = "DGTipe"
        Me.DGTipe.Size = New System.Drawing.Size(264, 251)
        Me.DGTipe.TabIndex = 17
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Transparent
        Me.BtnHapus.BackgroundImage = Global.Hotel.My.Resources.Resources.delete2
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnHapus.Location = New System.Drawing.Point(145, 222)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(60, 60)
        Me.BtnHapus.TabIndex = 16
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'btnTmbh
        '
        Me.btnTmbh.BackColor = System.Drawing.Color.Transparent
        Me.btnTmbh.BackgroundImage = Global.Hotel.My.Resources.Resources.add2
        Me.btnTmbh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTmbh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTmbh.FlatAppearance.BorderSize = 0
        Me.btnTmbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTmbh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTmbh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTmbh.Location = New System.Drawing.Point(24, 222)
        Me.btnTmbh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTmbh.Name = "btnTmbh"
        Me.btnTmbh.Size = New System.Drawing.Size(60, 60)
        Me.btnTmbh.TabIndex = 10
        Me.btnTmbh.Text = " "
        Me.btnTmbh.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(599, 120)
        Me.Panel2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(114, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 47)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ADD TYPE ROOM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(15, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmTpRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 495)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmTpRoom"
        Me.Text = "AddRoom"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTmbh As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DGTipe As DataGridView
    Friend WithEvents BtnHapus As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNamaTipe As TextBox
    Friend WithEvents txtKdTipe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBatal As Button
End Class
