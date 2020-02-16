

Public Class DataRepo


    Private _people As List(Of Person)

    Public Sub New()
        CreateRepo()
    End Sub

    Private Sub CreateRepo()
        _people = New List(Of Person)
        _people.Add(New Person With {.PersonFirstName = "Brad", .PersonLastName = "Six", .DOB = New DateTime(1981, 7, 1), .IsEmployee = True})
        _people.Add(New Person With {.PersonFirstName = "Brad", .PersonLastName = "Poo", .DOB = New DateTime(1991, 8, 1), .IsEmployee = False})
        _people.Add(New Person With {.PersonFirstName = "Bradley", .PersonLastName = "PooPoo", .DOB = New DateTime(1981, 7, 1), .IsEmployee = True})
        _people.Add(New Person With {.PersonFirstName = "Something", .PersonLastName = "Someone", .DOB = New DateTime(1988, 9, 1), .IsEmployee = False})
        _people.Add(New Person With {.PersonFirstName = "Mr", .PersonLastName = "CEO", .DOB = New DateTime(1981, 7, 1), .IsEmployee = True})
        _people.Add(New Person With {.PersonFirstName = "Someone's", .PersonLastName = "Wife", .DOB = New DateTime(1981, 7, 1), .IsEmployee = False})


    End Sub


    Public Function GetRepo() As List(Of Person)
        Return _people
    End Function






End Class
