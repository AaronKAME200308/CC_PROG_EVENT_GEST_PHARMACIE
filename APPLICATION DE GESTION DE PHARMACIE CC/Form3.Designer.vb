<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.LISTE = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AJOUTER = New System.Windows.Forms.Button()
        Me.SUPPRIMER = New System.Windows.Forms.Button()
        Me.MODIFIER = New System.Windows.Forms.Button()
        CType(Me.LISTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(234, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PHARMACIE D'ISTAG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(185, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 60)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "+ "
        '
        'LISTE
        '
        Me.LISTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LISTE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Nom, Me.Prix, Me.quantite, Me.type})
        Me.LISTE.Location = New System.Drawing.Point(90, 62)
        Me.LISTE.Name = "LISTE"
        Me.LISTE.RowTemplate.Height = 25
        Me.LISTE.Size = New System.Drawing.Size(534, 363)
        Me.LISTE.TabIndex = 6
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        '
        'Prix
        '
        Me.Prix.HeaderText = "PRIX"
        Me.Prix.Name = "Prix"
        '
        'quantite
        '
        Me.quantite.HeaderText = "QUANTITE"
        Me.quantite.Name = "quantite"
        '
        'type
        '
        Me.type.HeaderText = "TYPE"
        Me.type.Name = "type"
        '
        'AJOUTER
        '
        Me.AJOUTER.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AJOUTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AJOUTER.Location = New System.Drawing.Point(105, 448)
        Me.AJOUTER.Name = "AJOUTER"
        Me.AJOUTER.Size = New System.Drawing.Size(105, 48)
        Me.AJOUTER.TabIndex = 7
        Me.AJOUTER.Text = "AJOUTER"
        Me.AJOUTER.UseVisualStyleBackColor = True
        '
        'SUPPRIMER
        '
        Me.SUPPRIMER.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SUPPRIMER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SUPPRIMER.Location = New System.Drawing.Point(482, 448)
        Me.SUPPRIMER.Name = "SUPPRIMER"
        Me.SUPPRIMER.Size = New System.Drawing.Size(126, 48)
        Me.SUPPRIMER.TabIndex = 8
        Me.SUPPRIMER.Text = "SUPPRIMER"
        Me.SUPPRIMER.UseVisualStyleBackColor = True
        '
        'MODIFIER
        '
        Me.MODIFIER.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MODIFIER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MODIFIER.Location = New System.Drawing.Point(289, 448)
        Me.MODIFIER.Name = "MODIFIER"
        Me.MODIFIER.Size = New System.Drawing.Size(122, 48)
        Me.MODIFIER.TabIndex = 9
        Me.MODIFIER.Text = "MODIFIER"
        Me.MODIFIER.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 539)
        Me.Controls.Add(Me.MODIFIER)
        Me.Controls.Add(Me.SUPPRIMER)
        Me.Controls.Add(Me.AJOUTER)
        Me.Controls.Add(Me.LISTE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.LISTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LISTE As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents quantite As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents AJOUTER As Button
    Friend WithEvents SUPPRIMER As Button
    Friend WithEvents MODIFIER As Button
End Class
