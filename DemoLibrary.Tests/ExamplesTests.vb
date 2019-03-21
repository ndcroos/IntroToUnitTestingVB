
Imports Xunit

Public Class ExamplesTests

    <Fact>
    Public Sub ExampleLoadTextFile_ValidNameShouldWork()

        'Arrange
        Dim actual As String

        'Act
        actual = Examples.ExampleLoadTextFile("This is a valid file name.")


        'Assert
        Assert.True(actual.Length > 0)

    End Sub

    <Fact>
    Public Sub ExampleLoadTextFile_InvalidNameShoulodFail()

        Assert.Throws(Of ArgumentException)("file", Function() ExampleLoadTextFile(""))

    End Sub

End Class
