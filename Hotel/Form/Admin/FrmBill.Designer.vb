<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBill
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGBill = New System.Windows.Forms.DataGridView()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.dataPayment1 = New Hotel.DataPayment()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.txtKDBILL = New System.Windows.Forms.TextBox()
        CType(Me.DGBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Transparent
        Me.BtnBack.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(15, 15)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(50, 50)
        Me.BtnBack.TabIndex = 139
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(91, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(406, 47)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "DATA PEMBAYARAN"
        '
        'DGBill
        '
        Me.DGBill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBill.Location = New System.Drawing.Point(42, 94)
        Me.DGBill.Name = "DGBill"
        Me.DGBill.Size = New System.Drawing.Size(706, 394)
        Me.DGBill.TabIndex = 141
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
        Me.BtnHapus.TabIndex = 146
        Me.BtnHapus.Text = " "
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Transparent
        Me.btnCetak.BackgroundImage = Global.Hotel.My.Resources.Resources.print
        Me.btnCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Location = New System.Drawing.Point(153, 196)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(60, 60)
        Me.btnCetak.TabIndex = 150
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblBaris)
        Me.Panel1.Controls.Add(Me.txtKDBILL)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.btnCetak)
        Me.Panel1.Location = New System.Drawing.Point(0, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 321)
        Me.Panel1.TabIndex = 151
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblBaris.Location = New System.Drawing.Point(531, 181)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(72, 18)
        Me.LblBaris.TabIndex = 153
        Me.LblBaris.Text = "Data ke-"
        '
        'txtKDBILL
        '
        Me.txtKDBILL.BackColor = System.Drawing.SystemColors.Control
        Me.txtKDBILL.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtKDBILL.Location = New System.Drawing.Point(447, 178)
        Me.txtKDBILL.Name = "txtKDBILL"
        Me.txtKDBILL.Size = New System.Drawing.Size(78, 25)
        Me.txtKDBILL.TabIndex = 152
        '
        'FrmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.ClientSize = New System.Drawing.Size(792, 586)
        Me.Controls.Add(Me.DGBill)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "FrmBill"
        Me.Text = "Bill"
        CType(Me.DGBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DGBill As DataGridView
    Friend WithEvents BtnHapus As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents dataPayment1 As DataPayment
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblBaris As Label
    Friend WithEvents txtKDBILL As TextBox
End Class
