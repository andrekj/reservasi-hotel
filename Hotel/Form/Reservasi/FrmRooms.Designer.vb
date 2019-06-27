<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRooms))
        Me.LVCariMenu = New System.Windows.Forms.ListView()
        Me.TxtIDMenu = New System.Windows.Forms.TextBox()
        Me.TxtNamaMenu = New System.Windows.Forms.TextBox()
        Me.TxtHargaMenu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.TxtTipe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTambahMenu = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtStokPS = New System.Windows.Forms.Label()
        Me.txtStokPD = New System.Windows.Forms.Label()
        Me.txtStokDS = New System.Windows.Forms.Label()
        Me.txtStokDD = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPRESI = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVCariMenu
        '
        Me.LVCariMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LVCariMenu.Location = New System.Drawing.Point(30, 235)
        Me.LVCariMenu.Name = "LVCariMenu"
        Me.LVCariMenu.Size = New System.Drawing.Size(603, 131)
        Me.LVCariMenu.TabIndex = 62
        Me.LVCariMenu.UseCompatibleStateImageBehavior = False
        '
        'TxtIDMenu
        '
        Me.TxtIDMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIDMenu.Location = New System.Drawing.Point(60, 382)
        Me.TxtIDMenu.Name = "TxtIDMenu"
        Me.TxtIDMenu.ReadOnly = True
        Me.TxtIDMenu.Size = New System.Drawing.Size(86, 13)
        Me.TxtIDMenu.TabIndex = 64
        '
        'TxtNamaMenu
        '
        Me.TxtNamaMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNamaMenu.Location = New System.Drawing.Point(200, 382)
        Me.TxtNamaMenu.Name = "TxtNamaMenu"
        Me.TxtNamaMenu.ReadOnly = True
        Me.TxtNamaMenu.Size = New System.Drawing.Size(94, 13)
        Me.TxtNamaMenu.TabIndex = 65
        '
        'TxtHargaMenu
        '
        Me.TxtHargaMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtHargaMenu.Location = New System.Drawing.Point(487, 382)
        Me.TxtHargaMenu.Name = "TxtHargaMenu"
        Me.TxtHargaMenu.ReadOnly = True
        Me.TxtHargaMenu.Size = New System.Drawing.Size(100, 13)
        Me.TxtHargaMenu.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Keep Calm", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Keep Calm", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Keep Calm", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Price"
        '
        'txtCari
        '
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCari.Location = New System.Drawing.Point(30, 208)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(346, 20)
        Me.txtCari.TabIndex = 71
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCari.Location = New System.Drawing.Point(382, 206)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 72
        Me.btnCari.Text = "Search"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'TxtTipe
        '
        Me.TxtTipe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipe.Location = New System.Drawing.Point(349, 382)
        Me.TxtTipe.Name = "TxtTipe"
        Me.TxtTipe.ReadOnly = True
        Me.TxtTipe.Size = New System.Drawing.Size(94, 13)
        Me.TxtTipe.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Keep Calm", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Type"
        '
        'BtnTambahMenu
        '
        Me.BtnTambahMenu.BackColor = System.Drawing.Color.Transparent
        Me.BtnTambahMenu.BackgroundImage = Global.Hotel.My.Resources.Resources.add2
        Me.BtnTambahMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTambahMenu.FlatAppearance.BorderSize = 0
        Me.BtnTambahMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahMenu.Location = New System.Drawing.Point(596, 375)
        Me.BtnTambahMenu.Name = "BtnTambahMenu"
        Me.BtnTambahMenu.Size = New System.Drawing.Size(27, 27)
        Me.BtnTambahMenu.TabIndex = 67
        Me.BtnTambahMenu.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.Hotel.My.Resources.Resources.back
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(250, 458)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 50)
        Me.btnBack.TabIndex = 60
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtStokPS)
        Me.Panel1.Controls.Add(Me.txtStokPD)
        Me.Panel1.Controls.Add(Me.txtStokDS)
        Me.Panel1.Controls.Add(Me.txtStokDD)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtPRESI)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Controls.Add(Me.TxtTipe)
        Me.Panel1.Controls.Add(Me.LVCariMenu)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtIDMenu)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtNamaMenu)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtHargaMenu)
        Me.Panel1.Controls.Add(Me.BtnTambahMenu)
        Me.Panel1.Location = New System.Drawing.Point(70, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 423)
        Me.Panel1.TabIndex = 76
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(180, 70)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(129, 91)
        Me.Panel5.TabIndex = 78
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(31, 70)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(129, 91)
        Me.Panel4.TabIndex = 78
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(507, 70)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 91)
        Me.Panel2.TabIndex = 78
        '
        'txtStokPS
        '
        Me.txtStokPS.AutoSize = True
        Me.txtStokPS.BackColor = System.Drawing.Color.Transparent
        Me.txtStokPS.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.txtStokPS.Location = New System.Drawing.Point(222, 180)
        Me.txtStokPS.Name = "txtStokPS"
        Me.txtStokPS.Size = New System.Drawing.Size(49, 14)
        Me.txtStokPS.TabIndex = 98
        Me.txtStokPS.Text = "Label13"
        '
        'txtStokPD
        '
        Me.txtStokPD.AutoSize = True
        Me.txtStokPD.BackColor = System.Drawing.Color.Transparent
        Me.txtStokPD.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.txtStokPD.Location = New System.Drawing.Point(73, 180)
        Me.txtStokPD.Name = "txtStokPD"
        Me.txtStokPD.Size = New System.Drawing.Size(49, 14)
        Me.txtStokPD.TabIndex = 97
        Me.txtStokPD.Text = "Label13"
        '
        'txtStokDS
        '
        Me.txtStokDS.AutoSize = True
        Me.txtStokDS.BackColor = System.Drawing.Color.Transparent
        Me.txtStokDS.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.txtStokDS.Location = New System.Drawing.Point(546, 182)
        Me.txtStokDS.Name = "txtStokDS"
        Me.txtStokDS.Size = New System.Drawing.Size(49, 14)
        Me.txtStokDS.TabIndex = 96
        Me.txtStokDS.Text = "Label13"
        '
        'txtStokDD
        '
        Me.txtStokDD.AutoSize = True
        Me.txtStokDD.BackColor = System.Drawing.Color.Transparent
        Me.txtStokDD.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.txtStokDD.Location = New System.Drawing.Point(400, 180)
        Me.txtStokDD.Name = "txtStokDD"
        Me.txtStokDD.Size = New System.Drawing.Size(49, 14)
        Me.txtStokDD.TabIndex = 95
        Me.txtStokDD.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Keep Calm", 17.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(192, 4)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(302, 33)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Choose Available Room"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(503, 182)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 14)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Stock :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(354, 182)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 14)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Stock :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(176, 180)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 14)
        Me.Label17.TabIndex = 87
        Me.Label17.Text = "Stock :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(27, 180)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Stock :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Keep Calm", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(354, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Double"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Keep Calm", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(501, 163)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Single"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Keep Calm", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(175, 161)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 19)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Single"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Keep Calm", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(27, 163)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Double"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Keep Calm", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(470, 45)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Deluxe"
        '
        'txtPRESI
        '
        Me.txtPRESI.AutoSize = True
        Me.txtPRESI.BackColor = System.Drawing.Color.Transparent
        Me.txtPRESI.Font = New System.Drawing.Font("Keep Calm", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRESI.ForeColor = System.Drawing.Color.White
        Me.txtPRESI.Location = New System.Drawing.Point(110, 45)
        Me.txtPRESI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtPRESI.Name = "txtPRESI"
        Me.txtPRESI.Size = New System.Drawing.Size(92, 19)
        Me.txtPRESI.TabIndex = 78
        Me.txtPRESI.Text = "Presidential"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(358, 70)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 91)
        Me.Panel3.TabIndex = 77
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.Hotel.My.Resources.Resources.nextT
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.Color.Transparent
        Me.btnNext.Location = New System.Drawing.Point(508, 458)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 50)
        Me.btnNext.TabIndex = 99
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'FrmRooms
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.ClientSize = New System.Drawing.Size(808, 513)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents LVCariMenu As ListView
    Friend WithEvents TxtIDMenu As TextBox
    Friend WithEvents TxtNamaMenu As TextBox
    Friend WithEvents TxtHargaMenu As TextBox
    Friend WithEvents BtnTambahMenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents TxtTipe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPRESI As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStokPS As Label
    Friend WithEvents txtStokPD As Label
    Friend WithEvents txtStokDS As Label
    Friend WithEvents txtStokDD As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
End Class
