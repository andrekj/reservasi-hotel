<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCoba
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
        Me.txtSTOK = New System.Windows.Forms.TextBox()
        Me.updKamar = New System.Windows.Forms.NumericUpDown()
        Me.cbSediaPS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxHASIL = New System.Windows.Forms.TextBox()
        CType(Me.updKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSTOK
        '
        Me.txtSTOK.Location = New System.Drawing.Point(117, 137)
        Me.txtSTOK.Name = "txtSTOK"
        Me.txtSTOK.Size = New System.Drawing.Size(121, 20)
        Me.txtSTOK.TabIndex = 146
        '
        'updKamar
        '
        Me.updKamar.Location = New System.Drawing.Point(118, 91)
        Me.updKamar.Name = "updKamar"
        Me.updKamar.Size = New System.Drawing.Size(120, 20)
        Me.updKamar.TabIndex = 145
        '
        'cbSediaPS
        '
        Me.cbSediaPS.FormattingEnabled = True
        Me.cbSediaPS.Location = New System.Drawing.Point(118, 52)
        Me.cbSediaPS.Name = "cbSediaPS"
        Me.cbSediaPS.Size = New System.Drawing.Size(121, 21)
        Me.cbSediaPS.TabIndex = 144
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Jumlah 'y' di Presidential Double"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "combobox"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "updown"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "textbox"
        '
        'TextBoxHASIL
        '
        Me.TextBoxHASIL.Location = New System.Drawing.Point(371, 93)
        Me.TextBoxHASIL.Name = "TextBoxHASIL"
        Me.TextBoxHASIL.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHASIL.TabIndex = 151
        Me.TextBoxHASIL.Text = "HASIL"
        '
        'FrmCoba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 261)
        Me.Controls.Add(Me.TextBoxHASIL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSTOK)
        Me.Controls.Add(Me.updKamar)
        Me.Controls.Add(Me.cbSediaPS)
        Me.Name = "FrmCoba"
        Me.Text = "FrmCoba"
        CType(Me.updKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSTOK As TextBox
    Friend WithEvents updKamar As NumericUpDown
    Friend WithEvents cbSediaPS As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxHASIL As TextBox
End Class
