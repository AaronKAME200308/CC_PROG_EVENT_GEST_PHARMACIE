Imports System.Runtime.Intrinsics.X86
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form2
    Private Sub ENREGISTRER_Click(sender As Object, e As EventArgs) Handles ENREGISTRER.Click
        Dim Medicament As New Medicament()

        Medicament.numMedicament = TextBoxNumber.Text
        Medicament.nomMedicament = TextBoxName.Text
        Medicament.prixMedicament = TextBoxPrice.Text
        Medicament.quantiteMedicament = TextBoxQte.Text

        If COMPRIME.Checked Then
            Medicament.typeMedicament = COMPRIME.Text
        End If
        If GELLULE.Checked Then
            Medicament.typeMedicament = GELLULE.Text
        End If
        If SIROP.Checked Then
            Medicament.typeMedicament = SIROP.Text
        End If
        If VACCIN.Checked Then
            Medicament.typeMedicament = VACCIN.Text
        End If
        If SERUM.Checked Then
            Medicament.typeMedicament = SERUM.Text
        End If
        If OBJET.Checked Then
            Medicament.typeMedicament = OBJET.Text
        End If

        If Medicament.Valider = True Then
            Form3.LISTE.Rows.Add(Medicament.numMedicament, Medicament.nomMedicament, Medicament.prixMedicament, Medicament.quantiteMedicament, Medicament.typeMedicament)
            MsgBox("Inscription Validé")
            Form3.Show()

            TextBoxName.Clear()
            TextBoxNumber.Clear()
            TextBoxPrice.Clear()
            TextBoxQte.Clear()
        Else
            MsgBox("Les valeurs saisie sont incorrectes ")
        End If
    End Sub

    Private Sub SUPPRIMER_Click(sender As Object, e As EventArgs) Handles SUPPRIMER.Click
        TextBoxName.Clear()
        TextBoxNumber.Clear()
        TextBoxPrice.Clear()
        TextBoxQte.Clear()
    End Sub

    Private Sub MODIFIER_Click(sender As Object, e As EventArgs) Handles MODIFIER.Click
        Dim Medicament As New Medicament()

        Medicament.numMedicament = TextBoxNumber.Text
        Medicament.nomMedicament = TextBoxName.Text
        Medicament.prixMedicament = TextBoxPrice.Text
        Medicament.quantiteMedicament = TextBoxQte.Text

        If COMPRIME.Checked Then
            Medicament.typeMedicament = COMPRIME.Text
        End If
        If GELLULE.Checked Then
            Medicament.typeMedicament = GELLULE.Text
        End If
        If SIROP.Checked Then
            Medicament.typeMedicament = SIROP.Text
        End If
        If VACCIN.Checked Then
            Medicament.typeMedicament = VACCIN.Text
        End If
        If SERUM.Checked Then
            Medicament.typeMedicament = SERUM.Text
        End If
        If OBJET.Checked Then
            Medicament.typeMedicament = OBJET.Text
        End If

        Form3.LISTE.CurrentRow.Cells(0).Value = Medicament.numMedicament
        Form3.LISTE.CurrentRow.Cells(1).Value = Medicament.nomMedicament
        Form3.LISTE.CurrentRow.Cells(2).Value = Medicament.prixMedicament
        Form3.LISTE.CurrentRow.Cells(3).Value = Medicament.quantiteMedicament
        Form3.LISTE.CurrentRow.Cells(4).Value = Medicament.typeMedicament

        MsgBox("Modification Validé")
        Form3.Show()
    End Sub
End Class