Imports DemoLibrary

Public Class Dashboard

    Private people As List(Of PersonModel)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RebindDropdown()

    End Sub

    Public Sub RebindDropdown()

        people = DataAccess.GetAllPeople()
        usersDropdown.DataSource = New List(Of String)
        usersDropdown.DataSource = people
        usersDropdown.DisplayMember = "FullName"

    End Sub

    Private Sub addPersonButton_Click(sender As Object, e As EventArgs) Handles addPersonButton.Click

        Dim p As New PersonModel()
        With p
            .FirstName = firstNameText.Text
            .LastName = lastNameText.Text
        End With

        DataAccess.AddNewPerson(p)

        firstNameText.Text = ""
        lastNameText.Text = ""

        RebindDropdown()

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        resultsText.Text = Calculator.Add(CDbl(firstNumberValue.Value), (CDbl(secondNumberValue.Value)))

        firstNumberValue.Value = 0
        secondNumberValue.Value = 0

    End Sub

    Private Sub subtractButton_Click(sender As Object, e As EventArgs) Handles subtractButton.Click

        resultsText.Text = Calculator.Subtract(CDbl(firstNumberValue.Value), (CDbl(secondNumberValue.Value)))

        firstNumberValue.Value = 0
        secondNumberValue.Value = 0

    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click

        resultsText.Text = Calculator.Multiply(CDbl(firstNumberValue.Value), (CDbl(secondNumberValue.Value)))

        firstNumberValue.Value = 0
        secondNumberValue.Value = 0

    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click

        resultsText.Text = Calculator.Divide(CDbl(firstNumberValue.Value), (CDbl(secondNumberValue.Value)))

        firstNumberValue.Value = 0
        secondNumberValue.Value = 0

    End Sub
End Class