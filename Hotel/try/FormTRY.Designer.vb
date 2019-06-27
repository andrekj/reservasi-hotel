<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTRY
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtbDisplay = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 235)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(707, 149)
        Me.DataGridView2.TabIndex = 68
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(707, 147)
        Me.DataGridView1.TabIndex = 65
        '
        'BtbDisplay
        '
        '  Me.BtbDisplay.Image = Global.Hotel.My.Resources.Resources.right_arrow__1_
        Me.BtbDisplay.Location = New System.Drawing.Point(570, 404)
        Me.BtbDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.BtbDisplay.Name = "BtbDisplay"
        Me.BtbDisplay.Size = New System.Drawing.Size(62, 28)
        Me.BtbDisplay.TabIndex = 67
        Me.BtbDisplay.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        'Me.btnBack.Image = Global.Hotel.My.Resources.Resources.left_arrow__1_
        Me.btnBack.Location = New System.Drawing.Point(89, 404)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(62, 28)
        Me.btnBack.TabIndex = 66
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FormTRY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 493)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtbDisplay)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormTRY"
        Me.Text = "FormTRY"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BtbDisplay As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
