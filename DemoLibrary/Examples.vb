Public Module Examples

    Public Function ExampleLoadTextFile(file As String) As String

        If file.Length < 10 Then
            Throw New ArgumentException("The filename was too short", "file")
            ' Throw New System.IO.FileNotFoundException()

        End If

        Return "The file loaded correctly"

    End Function

End Module
