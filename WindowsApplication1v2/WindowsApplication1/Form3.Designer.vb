<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.coff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nommat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.h1 = New System.Windows.Forms.RadioButton()
        Me.h2 = New System.Windows.Forms.RadioButton()
        Me.h3 = New System.Windows.Forms.RadioButton()
        Me.tp = New System.Windows.Forms.CheckBox()
        Me.Labelbl24 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(507, 302)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(201, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom matiere"
        '
        'coff
        '
        Me.coff.BackColor = System.Drawing.SystemColors.MenuText
        Me.coff.ForeColor = System.Drawing.SystemColors.Window
        Me.coff.Location = New System.Drawing.Point(227, 166)
        Me.coff.Name = "coff"
        Me.coff.Size = New System.Drawing.Size(35, 20)
        Me.coff.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(201, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Coeficient"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(176, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "nombre d'heures "
        '
        'nommat
        '
        Me.nommat.BackColor = System.Drawing.SystemColors.MenuText
        Me.nommat.ForeColor = System.Drawing.SystemColors.Window
        Me.nommat.Location = New System.Drawing.Point(173, 72)
        Me.nommat.Name = "nommat"
        Me.nommat.Size = New System.Drawing.Size(151, 20)
        Me.nommat.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(381, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 41)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(1, 224)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 41)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "<-----"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'h1
        '
        Me.h1.AutoSize = True
        Me.h1.BackgroundImage = CType(resources.GetObject("h1.BackgroundImage"), System.Drawing.Image)
        Me.h1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.h1.Location = New System.Drawing.Point(163, 118)
        Me.h1.Name = "h1"
        Me.h1.Size = New System.Drawing.Size(58, 22)
        Me.h1.TabIndex = 20
        Me.h1.TabStop = True
        Me.h1.Text = "10.5"
        Me.h1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.h1.UseVisualStyleBackColor = False
        '
        'h2
        '
        Me.h2.AutoSize = True
        Me.h2.BackgroundImage = CType(resources.GetObject("h2.BackgroundImage"), System.Drawing.Image)
        Me.h2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.h2.Location = New System.Drawing.Point(227, 118)
        Me.h2.Name = "h2"
        Me.h2.Size = New System.Drawing.Size(44, 22)
        Me.h2.TabIndex = 21
        Me.h2.TabStop = True
        Me.h2.Text = "21"
        Me.h2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.h2.UseVisualStyleBackColor = False
        '
        'h3
        '
        Me.h3.AutoSize = True
        Me.h3.BackgroundImage = CType(resources.GetObject("h3.BackgroundImage"), System.Drawing.Image)
        Me.h3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.h3.Location = New System.Drawing.Point(280, 118)
        Me.h3.Name = "h3"
        Me.h3.Size = New System.Drawing.Size(44, 22)
        Me.h3.TabIndex = 22
        Me.h3.TabStop = True
        Me.h3.Text = "42"
        Me.h3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.h3.UseVisualStyleBackColor = False
        '
        'tp
        '
        Me.tp.AutoSize = True
        Me.tp.BackgroundImage = CType(resources.GetObject("tp.BackgroundImage"), System.Drawing.Image)
        Me.tp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tp.Location = New System.Drawing.Point(131, 192)
        Me.tp.Name = "tp"
        Me.tp.Size = New System.Drawing.Size(237, 24)
        Me.tp.TabIndex = 23
        Me.tp.Text = "Matiere Traveaux Pratique"
        Me.tp.UseVisualStyleBackColor = True
        '
        'Labelbl24
        '
        Me.Labelbl24.AutoSize = True
        Me.Labelbl24.Font = New System.Drawing.Font("Adobe Gothic Std B", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbl24.Image = CType(resources.GetObject("Labelbl24.Image"), System.Drawing.Image)
        Me.Labelbl24.Location = New System.Drawing.Point(135, 9)
        Me.Labelbl24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbl24.Name = "Labelbl24"
        Me.Labelbl24.Size = New System.Drawing.Size(233, 30)
        Me.Labelbl24.TabIndex = 25
        Me.Labelbl24.Text = "Ajouter une matiere"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 259)
        Me.Controls.Add(Me.Labelbl24)
        Me.Controls.Add(Me.tp)
        Me.Controls.Add(Me.h3)
        Me.Controls.Add(Me.h2)
        Me.Controls.Add(Me.h1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nommat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.coff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.Text = "Gestion de matiere et salles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents coff As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nommat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents h1 As System.Windows.Forms.RadioButton
    Friend WithEvents h2 As System.Windows.Forms.RadioButton
    Friend WithEvents h3 As System.Windows.Forms.RadioButton
    Friend WithEvents tp As System.Windows.Forms.CheckBox
    Friend WithEvents Labelbl24 As System.Windows.Forms.Label
End Class
