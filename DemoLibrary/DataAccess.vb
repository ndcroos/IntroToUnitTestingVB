
Imports System.IO

Public Module DataAccess

    Private personTextFile As String = "PersonText.txt"

    Public Sub AddNewPerson(person As PersonModel)

        Dim people As List(Of PersonModel) = GetAllPeople()

        AddPersonToPeopleList(people, person)

        Dim lines As List(Of String) = ConvertModelsToCSV(people)

        File.WriteAllLines(personTextFile, lines)

    End Sub

    Public Sub AddPersonToPeopleList(people As List(Of PersonModel), person As PersonModel)

        If String.IsNullOrWhiteSpace(person.FirstName) Then

            Throw New ArgumentException("You passed in an invalid parameter", "FirstName")

        End If

        If String.IsNullOrWhiteSpace(person.LastName) Then

            Throw New ArgumentException("You passed in an invalid parameter", "LastName")

        End If

        people.Add(person)

    End Sub

    Public Function ConvertModelsToCSV(people As List(Of PersonModel)) As List(Of String)

        Dim output As List(Of String) = New List(Of String)

        For Each user As PersonModel In people
            output.Add($"{user.FirstName},{user.LastName}")
        Next

        Return output

    End Function

    Public Function GetAllPeople() As List(Of PersonModel)

        Dim output As List(Of PersonModel) = New List(Of PersonModel)
        Dim content() As String = File.ReadAllLines(personTextFile)

        For Each line As String In content
            Dim data() As String
            data = Split(line, ","c)

            Dim tempPerson As PersonModel = New PersonModel()
            tempPerson.FirstName = data(0)
            tempPerson.LastName = data(1)

            output.Add(tempPerson)
        Next

        Return output

    End Function

End Module
