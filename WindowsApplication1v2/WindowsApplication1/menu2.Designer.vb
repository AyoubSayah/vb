<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Labelbl24 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(467, 258)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Maroon
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(2, 69)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(228, 49)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Afficher Liste matieres"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(233, 69)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(236, 49)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Afficher Liste salles"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Maroon
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(114, 148)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(237, 44)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "Emploi du Temps"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Labelbl24
        '
        Me.Labelbl24.AutoSize = True
        Me.Labelbl24.Font = New System.Drawing.Font("Adobe Gothic Std B", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbl24.Image = CType(resources.GetObject("Labelbl24.Image"), System.Drawing.Image)
        Me.Labelbl24.Location = New System.Drawing.Point(198, 9)
        Me.Labelbl24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbl24.Name = "Labelbl24"
        Me.Labelbl24.Size = New System.Drawing.Size(76, 30)
        Me.Labelbl24.TabIndex = 25
        Me.Labelbl24.Text = "Menu"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(2, 219)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 41)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'menu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 261)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Labelbl24)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "menu2"
        Me.Text = "menu2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Labelbl24 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
