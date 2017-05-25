Public Class MajorCON
    Dim majoring As New List(Of Major)
    Public Sub New()
        Dim m As New Major
        m.set_ID(1)
        m.set_name("Ing. de Sistemas de Informacion")
        majoring.Add(m)
        m = New Major
        m.set_ID(2)
        m.set_name("Docente")
        majoring.Add(m)
        m = New Major
        m.set_ID(3)
        m.set_name("Director")

    End Sub

    Public Sub Save(ByVal m As Major)
        If Not major_by_name(m.get_name()) Is Nothing Then
            majoring.Add(m)
        End If
    End Sub

    Public Function major_by_name(ByVal name As String)
        For Each m As Major In majoring
            If m.get_name().Equals(name) Then
                Return m
            End If
        Next
        Return Nothing
    End Function

    Public Function Size()
        Return majoring.Count
    End Function

    Public Function major_by_index(ByVal index As Integer)
        Return majoring.Item(index)
    End Function
End Class
