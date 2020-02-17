<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tp = New System.Windows.Forms.CheckBox()
        Me.nrml = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 272)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(394, 43)
        Me.ListBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(412, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Afficher "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(175, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Type salle"
        '
        'tp
        '
        Me.tp.AutoSize = True
        Me.tp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tp.Location = New System.Drawing.Point(271, 177)
        Me.tp.Name = "tp"
        Me.tp.Size = New System.Drawing.Size(217, 24)
        Me.tp.TabIndex = 10
        Me.tp.Text = "Salle Traveaux Pratique"
        Me.tp.UseVisualStyleBackColor = False
        '
        'nrml
        '
        Me.nrml.AutoSize = True
        Me.nrml.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nrml.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nrml.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.nrml.Location = New System.Drawing.Point(12, 177)
        Me.nrml.Name = "nrml"
        Me.nrml.Size = New System.Drawing.Size(129, 24)
        Me.nrml.TabIndex = 11
        Me.nrml.Text = "Salle Normal"
        Me.nrml.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(373, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 41)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(0, 218)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 41)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "<-----"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(136, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Modifier une salle"
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 260)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.nrml)
        Me.Controls.Add(Me.tp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form14"
        Me.Text = "Form14"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tp As System.Windows.Forms.CheckBox
    Friend WithEvents nrml As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
