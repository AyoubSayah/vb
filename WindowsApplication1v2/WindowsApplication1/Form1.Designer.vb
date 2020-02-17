<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.user1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Labelbl24 = New System.Windows.Forms.Label()
        Me.mdp = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 299)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(156, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom d'utilisateur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(169, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mot de passe"
        '
        'user1
        '
        Me.user1.AccessibleName = "user"
        Me.user1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.user1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user1.ForeColor = System.Drawing.SystemColors.Window
        Me.user1.Location = New System.Drawing.Point(152, 115)
        Me.user1.Name = "user1"
        Me.user1.Size = New System.Drawing.Size(151, 26)
        Me.user1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(356, 218)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Connecter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(2, 218)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 41)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Inscription"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-8, 256)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(491, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'Timer2
        '
        '
        'Labelbl24
        '
        Me.Labelbl24.AutoSize = True
        Me.Labelbl24.Font = New System.Drawing.Font("Adobe Gothic Std B", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbl24.Image = CType(resources.GetObject("Labelbl24.Image"), System.Drawing.Image)
        Me.Labelbl24.Location = New System.Drawing.Point(168, 9)
        Me.Labelbl24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbl24.Name = "Labelbl24"
        Me.Labelbl24.Size = New System.Drawing.Size(131, 30)
        Me.Labelbl24.TabIndex = 10
        Me.Labelbl24.Text = "Bienvenue"
        '
        'mdp
        '
        Me.mdp.AccessibleName = ""
        Me.mdp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mdp.ForeColor = System.Drawing.SystemColors.Window
        Me.mdp.Location = New System.Drawing.Point(152, 196)
        Me.mdp.Name = "mdp"
        Me.mdp.Size = New System.Drawing.Size(151, 26)
        Me.mdp.TabIndex = 11
        Me.mdp.UseSystemPasswordChar = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(-8, -2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 41)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "<-----"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(481, 282)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.mdp)
        Me.Controls.Add(Me.Labelbl24)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.user1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents user1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Labelbl24 As System.Windows.Forms.Label
    Friend WithEvents mdp As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
