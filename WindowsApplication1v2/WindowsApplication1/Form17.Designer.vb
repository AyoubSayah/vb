<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form17))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelbl24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.user1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mdp = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 257)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Labelbl24
        '
        Me.Labelbl24.AutoSize = True
        Me.Labelbl24.Font = New System.Drawing.Font("Adobe Gothic Std B", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbl24.Image = CType(resources.GetObject("Labelbl24.Image"), System.Drawing.Image)
        Me.Labelbl24.Location = New System.Drawing.Point(154, 21)
        Me.Labelbl24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Labelbl24.Name = "Labelbl24"
        Me.Labelbl24.Size = New System.Drawing.Size(131, 30)
        Me.Labelbl24.TabIndex = 11
        Me.Labelbl24.Text = "Bienvenue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(130, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nom Administrateur"
        '
        'user1
        '
        Me.user1.AccessibleName = "user"
        Me.user1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.user1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user1.ForeColor = System.Drawing.SystemColors.Window
        Me.user1.Location = New System.Drawing.Point(134, 101)
        Me.user1.Name = "user1"
        Me.user1.Size = New System.Drawing.Size(151, 20)
        Me.user1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(155, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mot de passe"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(145, 210)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 41)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Connecter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mdp
        '
        Me.mdp.AccessibleName = ""
        Me.mdp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mdp.ForeColor = System.Drawing.SystemColors.Window
        Me.mdp.Location = New System.Drawing.Point(134, 176)
        Me.mdp.Name = "mdp"
        Me.mdp.Size = New System.Drawing.Size(151, 20)
        Me.mdp.TabIndex = 17
        Me.mdp.UseSystemPasswordChar = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(1, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 41)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "<-----"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Indigo
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(310, 216)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 41)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Ajouter admin"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.mdp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.user1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Labelbl24)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form17"
        Me.Text = "Form17"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Labelbl24 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents user1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mdp As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
