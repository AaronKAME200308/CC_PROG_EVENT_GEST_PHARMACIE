<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SUPPRIMER = New System.Windows.Forms.Button()
        Me.ENREGISTRER = New System.Windows.Forms.Button()
        Me.MODIFIER = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OBJET = New System.Windows.Forms.RadioButton()
        Me.SERUM = New System.Windows.Forms.RadioButton()
        Me.VACCIN = New System.Windows.Forms.RadioButton()
        Me.SIROP = New System.Windows.Forms.RadioButton()
        Me.GELLULE = New System.Windows.Forms.RadioButton()
        Me.COMPRIME = New System.Windows.Forms.RadioButton()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxQte = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(469, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PHARMACIE D'ISTAG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(429, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "+ "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SUPPRIMER)
        Me.GroupBox1.Controls.Add(Me.ENREGISTRER)
        Me.GroupBox1.Controls.Add(Me.MODIFIER)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.TextBoxQte)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrice)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 390)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrez informations du médicament"
        '
        'SUPPRIMER
        '
        Me.SUPPRIMER.Location = New System.Drawing.Point(625, 313)
        Me.SUPPRIMER.Name = "SUPPRIMER"
        Me.SUPPRIMER.Size = New System.Drawing.Size(127, 54)
        Me.SUPPRIMER.TabIndex = 11
        Me.SUPPRIMER.Text = "SUPPRIMER"
        Me.SUPPRIMER.UseVisualStyleBackColor = True
        '
        'ENREGISTRER
        '
        Me.ENREGISTRER.Location = New System.Drawing.Point(450, 313)
        Me.ENREGISTRER.Name = "ENREGISTRER"
        Me.ENREGISTRER.Size = New System.Drawing.Size(138, 54)
        Me.ENREGISTRER.TabIndex = 10
        Me.ENREGISTRER.Text = "ENREGISTRER"
        Me.ENREGISTRER.UseVisualStyleBackColor = True
        '
        'MODIFIER
        '
        Me.MODIFIER.Location = New System.Drawing.Point(467, 313)
        Me.MODIFIER.Name = "MODIFIER"
        Me.MODIFIER.Size = New System.Drawing.Size(110, 54)
        Me.MODIFIER.TabIndex = 9
        Me.MODIFIER.Text = "MODIFIER"
        Me.MODIFIER.UseVisualStyleBackColor = True
        Me.MODIFIER.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PRIX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "QUANTITE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NOM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NUMERO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OBJET)
        Me.GroupBox2.Controls.Add(Me.SERUM)
        Me.GroupBox2.Controls.Add(Me.VACCIN)
        Me.GroupBox2.Controls.Add(Me.SIROP)
        Me.GroupBox2.Controls.Add(Me.GELLULE)
        Me.GroupBox2.Controls.Add(Me.COMPRIME)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(478, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 222)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TYPE"
        '
        'OBJET
        '
        Me.OBJET.AutoSize = True
        Me.OBJET.Location = New System.Drawing.Point(44, 181)
        Me.OBJET.Name = "OBJET"
        Me.OBJET.Size = New System.Drawing.Size(81, 24)
        Me.OBJET.TabIndex = 5
        Me.OBJET.TabStop = True
        Me.OBJET.Text = "objet"
        Me.OBJET.UseVisualStyleBackColor = True
        '
        'SERUM
        '
        Me.SERUM.AutoSize = True
        Me.SERUM.Location = New System.Drawing.Point(44, 151)
        Me.SERUM.Name = "SERUM"
        Me.SERUM.Size = New System.Drawing.Size(87, 24)
        Me.SERUM.TabIndex = 4
        Me.SERUM.TabStop = True
        Me.SERUM.Text = "serum"
        Me.SERUM.UseVisualStyleBackColor = True
        '
        'VACCIN
        '
        Me.VACCIN.AutoSize = True
        Me.VACCIN.Location = New System.Drawing.Point(44, 121)
        Me.VACCIN.Name = "VACCIN"
        Me.VACCIN.Size = New System.Drawing.Size(91, 24)
        Me.VACCIN.TabIndex = 3
        Me.VACCIN.TabStop = True
        Me.VACCIN.Text = "vaccin"
        Me.VACCIN.UseVisualStyleBackColor = True
        '
        'SIROP
        '
        Me.SIROP.AutoSize = True
        Me.SIROP.Location = New System.Drawing.Point(44, 94)
        Me.SIROP.Name = "SIROP"
        Me.SIROP.Size = New System.Drawing.Size(81, 24)
        Me.SIROP.TabIndex = 2
        Me.SIROP.TabStop = True
        Me.SIROP.Text = "sirop"
        Me.SIROP.UseVisualStyleBackColor = True
        '
        'GELLULE
        '
        Me.GELLULE.AutoSize = True
        Me.GELLULE.Location = New System.Drawing.Point(44, 64)
        Me.GELLULE.Name = "GELLULE"
        Me.GELLULE.Size = New System.Drawing.Size(98, 24)
        Me.GELLULE.TabIndex = 1
        Me.GELLULE.TabStop = True
        Me.GELLULE.Text = "gellule"
        Me.GELLULE.UseVisualStyleBackColor = True
        '
        'COMPRIME
        '
        Me.COMPRIME.AutoSize = True
        Me.COMPRIME.Location = New System.Drawing.Point(44, 35)
        Me.COMPRIME.Name = "COMPRIME"
        Me.COMPRIME.Size = New System.Drawing.Size(124, 24)
        Me.COMPRIME.TabIndex = 0
        Me.COMPRIME.TabStop = True
        Me.COMPRIME.Text = "comprimé"
        Me.COMPRIME.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(108, 103)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 27)
        Me.TextBoxName.TabIndex = 3
        '
        'TextBoxQte
        '
        Me.TextBoxQte.Location = New System.Drawing.Point(108, 164)
        Me.TextBoxQte.Name = "TextBoxQte"
        Me.TextBoxQte.Size = New System.Drawing.Size(100, 27)
        Me.TextBoxQte.TabIndex = 2
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(108, 212)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 27)
        Me.TextBoxPrice.TabIndex = 1
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(108, 53)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(100, 27)
        Me.TextBoxNumber.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxQte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SERUM As RadioButton
    Friend WithEvents VACCIN As RadioButton
    Friend WithEvents SIROP As RadioButton
    Friend WithEvents GELLULE As RadioButton
    Friend WithEvents COMPRIME As RadioButton
    Friend WithEvents SUPPRIMER As Button
    Friend WithEvents ENREGISTRER As Button
    Friend WithEvents MODIFIER As Button
    Friend WithEvents OBJET As RadioButton
End Class
