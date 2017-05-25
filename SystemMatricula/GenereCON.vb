Public Class GenereCON
    Dim generes As New List(Of Genere)
    Public Sub New()
        Dim g As New Genere
        g.set_ID("1")
        g.set_name("Masculino")
        generes.Add(g)
        g = New Genere
        g.set_ID("2")
        g.set_name("Femenino")
        generes.Add(g)

    End Sub


    Public Function genere_by_name(ByVal name As String)
        For Each g As Genere In generes
            If g.get_name().Equals(name) Then
                Return g
            End If
        Next

        Return Nothing
    End Function


End Class
