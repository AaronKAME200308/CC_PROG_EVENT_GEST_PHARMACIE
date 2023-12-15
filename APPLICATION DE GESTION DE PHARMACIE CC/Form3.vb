Public Class Form3
    Private Sub AJOUTER_Click(sender As Object, e As EventArgs) Handles AJOUTER.Click
        Form2.Show()
        Me.Hide()
        Form2.MODIFIER.Visible = False
        Form2.ENREGISTRER.Visible = True
    End Sub

    Private Sub MODIFIER_Click(sender As Object, e As EventArgs) Handles MODIFIER.Click
        Dim NumMedicament As String = LISTE.CurrentRow.Cells(0).Value
        Form2.TextBoxNumber.Text = NumMedicament

        Dim NomMedicament As String = LISTE.CurrentRow.Cells(1).Value
        Form2.TextBoxName.Text = NomMedicament

        Dim PrixMedicament As String = LISTE.CurrentRow.Cells(2).Value
        Form2.TextBoxPrice.Text = PrixMedicament

        Dim QuantiteMedicament As String = LISTE.CurrentRow.Cells(3).Value
        Form2.TextBoxQte.Text = QuantiteMedicament

        Form2.Show()

        Form2.MODIFIER.Visible = True
        Form2.ENREGISTRER.Visible = False

        Me.Hide()
    End Sub

    Private Sub SUPPRIMER_Click(sender As Object, e As EventArgs) Handles SUPPRIMER.Click
        Dim position = LISTE.CurrentRow.Index
        LISTE.Rows.RemoveAt(position)
    End Sub
End Class