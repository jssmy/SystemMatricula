Public Class Person
    Dim ID As Integer
    Dim DNI As String
    Dim Name As String
    Dim LastName As String
    Dim BirthDay As Date

    Dim major As New Major
    Dim genere As New Genere

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

    Public Sub set_lastname(ByVal ln As String)
        Me.LastName = ln
    End Sub

    Public Function get_lastname()
        Return Me.LastName
    End Function

    Public Sub set_birthday(ByVal b As Date)
        Me.BirthDay = b
    End Sub
    Public Function get_birthday()
        Return Me.BirthDay
    End Function

    Public Sub set_major(ByVal m As Major)
        Me.major = m
    End Sub
    Public Function get_major()
        Return Me.major
    End Function

    Public Sub set_genere(ByVal g As Genere)
        Me.genere = g
    End Sub

    Public Function get_genere()
        Return Me.genere
    End Function

    Public Sub set_dni(ByVal dni As String)
        Me.DNI = dni
    End Sub

    Public Function get_dni()
        Return Me.DNI
    End Function
End Class
