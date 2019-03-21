Imports Xunit

Public Class DataAccessTests

    <Fact>
    Public Sub AddPersonToPeopleList_ShouldWork()

        'Arrange
        Dim newPerson As PersonModel = New PersonModel()
        With newPerson
            .FirstName = "Brandon"
            .LastName = "Stark"
        End With

        Dim people As List(Of PersonModel) = New List(Of PersonModel)

        'Act
        DataAccess.AddPersonToPeopleList(people, newPerson)

        'Assert
        Assert.True(people.Count = 1)
        Assert.Contains(Of PersonModel)(newPerson, people)

    End Sub



End Class
