<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInformasi
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
        Me.TxtKdTamu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtLastNm = New System.Windows.Forms.TextBox()
        Me.TxtSpecialReq = New System.Windows.Forms.TextBox()
        Me.TxtNoTelp = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtIdTamu = New System.Windows.Forms.TextBox()
        Me.TxtFristNm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnBackBatal = New System.Windows.Forms.Button()
        Me.BtnSaveNext = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.TxtKdTamu)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtLastNm)
        Me.Panel1.Controls.Add(Me.TxtSpecialReq)
        Me.Panel1.Controls.Add(Me.TxtNoTelp)
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Controls.Add(Me.TxtIdTamu)
        Me.Panel1.Controls.Add(Me.TxtFristNm)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(70, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 423)
        Me.Panel1.TabIndex = 8
        '
        'TxtKdTamu
        '
        Me.TxtKdTamu.Enabled = False
        Me.TxtKdTamu.Location = New System.Drawing.Point(520, 82)
        Me.TxtKdTamu.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKdTamu.Name = "TxtKdTamu"
        Me.TxtKdTamu.Size = New System.Drawing.Size(104, 20)
        Me.TxtKdTamu.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(455, 85)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Guest ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Keep Calm", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(233, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 33)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Your Information"
        '
        'TxtLastNm
        '
        Me.TxtLastNm.Location = New System.Drawing.Point(133, 104)
        Me.TxtLastNm.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLastNm.Name = "TxtLastNm"
        Me.TxtLastNm.Size = New System.Drawing.Size(193, 20)
        Me.TxtLastNm.TabIndex = 17
        '
        'TxtSpecialReq
        '
        Me.TxtSpecialReq.Location = New System.Drawing.Point(133, 211)
        Me.TxtSpecialReq.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSpecialReq.Multiline = True
        Me.TxtSpecialReq.Name = "TxtSpecialReq"
        Me.TxtSpecialReq.Size = New System.Drawing.Size(193, 142)
        Me.TxtSpecialReq.TabIndex = 16
        '
        'TxtNoTelp
        '
        Me.TxtNoTelp.Location = New System.Drawing.Point(133, 176)
        Me.TxtNoTelp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNoTelp.Name = "TxtNoTelp"
        Me.TxtNoTelp.Size = New System.Drawing.Size(193, 20)
        Me.TxtNoTelp.TabIndex = 15
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(133, 152)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(193, 20)
        Me.TxtEmail.TabIndex = 14
        '
        'TxtIdTamu
        '
        Me.TxtIdTamu.Location = New System.Drawing.Point(133, 128)
        Me.TxtIdTamu.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdTamu.Name = "TxtIdTamu"
        Me.TxtIdTamu.Size = New System.Drawing.Size(193, 20)
        Me.TxtIdTamu.TabIndex = 13
        '
        'TxtFristNm
        '
        Me.TxtFristNm.Location = New System.Drawing.Point(133, 81)
        Me.TxtFristNm.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFristNm.Name = "TxtFristNm"
        Me.TxtFristNm.Size = New System.Drawing.Size(193, 20)
        Me.TxtFristNm.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(62, 225)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "(optional)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 211)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Special Request"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.Silver
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Keep Calm", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Location = New System.Drawing.Point(353, 467)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(109, 34)
        Me.BtnRefresh.TabIndex = 9
        Me.BtnRefresh.Text = "refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'BtnBackBatal
        '
        Me.BtnBackBatal.BackColor = System.Drawing.Color.Transparent
        Me.BtnBackBatal.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.BtnBackBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBackBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackBatal.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBackBatal.Location = New System.Drawing.Point(250, 458)
        Me.BtnBackBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBackBatal.Name = "BtnBackBatal"
        Me.BtnBackBatal.Size = New System.Drawing.Size(50, 50)
        Me.BtnBackBatal.TabIndex = 100
        Me.BtnBackBatal.UseVisualStyleBackColor = False
        '
        'BtnSaveNext
        '
        Me.BtnSaveNext.BackColor = System.Drawing.Color.Transparent
        Me.BtnSaveNext.BackgroundImage = Global.Hotel.My.Resources.Resources.nextT
        Me.BtnSaveNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSaveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveNext.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSaveNext.Location = New System.Drawing.Point(508, 458)
        Me.BtnSaveNext.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaveNext.Name = "BtnSaveNext"
        Me.BtnSaveNext.Size = New System.Drawing.Size(50, 50)
        Me.BtnSaveNext.TabIndex = 101
        Me.BtnSaveNext.UseVisualStyleBackColor = False
        '
        'FrmInformasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.ClientSize = New System.Drawing.Size(808, 513)
        Me.Controls.Add(Me.BtnBackBatal)
        Me.Controls.Add(Me.BtnSaveNext)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmInformasi"
        Me.Text = "Informasi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtLastNm As TextBox
    Friend WithEvents TxtSpecialReq As TextBox
    Friend WithEvents TxtNoTelp As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtIdTamu As TextBox
    Friend WithEvents TxtFristNm As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtKdTamu As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBackBatal As Button
    Friend WithEvents BtnSaveNext As Button
End Class
