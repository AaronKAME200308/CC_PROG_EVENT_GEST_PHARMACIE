Public Class Medicament
    Public numMedicament As String
    Public nomMedicament As String
    Public prixMedicament As String
    Public quantiteMedicament As String
    Public typeMedicament As String

    Public Function Valider() As Boolean
        Dim state As Boolean = True

        If Not IsNumeric(Me.numMedicament) Then
            state = False
        End If
        If Not IsNumeric(Me.prixMedicament) Then
            state = False
        End If
        If Not IsNumeric(Me.quantiteMedicament) Then
            state = False
        End If

        Return state
    End Function
End Class
