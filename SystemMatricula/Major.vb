Public Class Major
    Dim ID As Integer
    Dim Name As String
    Public Sub set_ID(ByVal id As Integer)
        Me.ID = id
    End Sub

    Public Function get_ID()
        Return Me.ID
    End Function

    Public Sub set_name(ByVal n As String)
        Me.Name = n
    End Sub

    Public Function get_name()
        Return Me.Name
    End Function

End Class
