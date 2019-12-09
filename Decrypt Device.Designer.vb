<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Decrypt_Device
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
        Me.GhostTextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GhostTextBox5
        '
        Me.GhostTextBox5.BackColor = System.Drawing.Color.Black
        Me.GhostTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GhostTextBox5.ForeColor = System.Drawing.Color.Snow
        Me.GhostTextBox5.Location = New System.Drawing.Point(92, 10)
        Me.GhostTextBox5.Name = "GhostTextBox5"
        Me.GhostTextBox5.Size = New System.Drawing.Size(149, 22)
        Me.GhostTextBox5.TabIndex = 17
        Me.GhostTextBox5.Text = ".blueeagleranrat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(2, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Extention :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Location = New System.Drawing.Point(236, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Decrypt"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Decrypt_Device
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(316, 89)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GhostTextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Decrypt_Device"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decrypt Ransomware files     Computer : "
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GhostTextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
