<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
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
        Me.btnTAMU = New System.Windows.Forms.Button()
        Me.btnKAR = New System.Windows.Forms.Button()
        Me.btnBILL = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnTAMU)
        Me.Panel1.Controls.Add(Me.btnKAR)
        Me.Panel1.Controls.Add(Me.btnBILL)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(83, 117)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 423)
        Me.Panel1.TabIndex = 0
        '
        'btnTAMU
        '
        Me.btnTAMU.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnTAMU.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnTAMU.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTAMU.Location = New System.Drawing.Point(349, 143)
        Me.btnTAMU.Name = "btnTAMU"
        Me.btnTAMU.Size = New System.Drawing.Size(226, 59)
        Me.btnTAMU.TabIndex = 10
        Me.btnTAMU.Text = "Manage Guest"
        Me.btnTAMU.UseVisualStyleBackColor = False
        '
        'btnKAR
        '
        Me.btnKAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnKAR.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnKAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKAR.Location = New System.Drawing.Point(349, 224)
        Me.btnKAR.Name = "btnKAR"
        Me.btnKAR.Size = New System.Drawing.Size(226, 59)
        Me.btnKAR.TabIndex = 8
        Me.btnKAR.Text = "Manage Employee"
        Me.btnKAR.UseVisualStyleBackColor = False
        '
        'btnBILL
        '
        Me.btnBILL.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnBILL.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnBILL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBILL.Location = New System.Drawing.Point(90, 224)
        Me.btnBILL.Name = "btnBILL"
        Me.btnBILL.Size = New System.Drawing.Size(233, 59)
        Me.btnBILL.TabIndex = 9
        Me.btnBILL.Text = "Manage Payment"
        Me.btnBILL.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(280, 342)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 37)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Log Out"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(90, 56)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(485, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Manage Reservation"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BackgroundImage = Global.Hotel.My.Resources.Resources.BG
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(1, -58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 625)
        Me.Panel2.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(90, 143)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(233, 59)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Manage Room"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 513)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmHome"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnKAR As Button
    Friend WithEvents btnBILL As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTAMU As Button
    Friend WithEvents Button4 As Button
End Class
