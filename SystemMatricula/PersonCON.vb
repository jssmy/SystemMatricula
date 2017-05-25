Public Class PersonCON
    Dim personas As New List(Of Person)

    Public Function save(ByVal p As Person)
        If person_by_dni(p.get_dni()) Is Nothing Then
            personas.Add(p)
            Return "Se ha registrado con exito"
        End If
        Return "No se ha podido registrar"
    End Function



    Public Function person_by_dni(ByVal dni As String)
        For Each p As Person In personas
            If p.get_dni().Equals(dni) Then
                Return p
            End If
        Next

        Return Nothing
    End Function
    Public Function person_by_index(ByVal i As Integer)
        Return personas.Item(i)
    End Function


    Public Function Size()
        Return Me.personas.Count
    End Function

End Class
