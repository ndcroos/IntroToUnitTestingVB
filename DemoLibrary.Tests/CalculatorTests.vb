Imports Xunit

Public Class CalculatorTests

    <Theory>
    <InlineData(4, 3, 7)>
    <InlineData(21, 5.25, 26.25)>
    <InlineData(Double.MaxValue, 5, Double.MaxValue)>
    Public Sub Add_SimpleValuseShouldCalculate(x As Double, y As Double, expected As Double)

        'Arrange

        'Act
        Dim actual As Double = Calculator.Add(x, y)

        'Assert
        Assert.Equal(expected, actual)

    End Sub

    <Theory>
    <InlineData(8, 4, 2)>
    Public Sub Divide_SimpleValuesShouldCalculate(x As Double, y As Double, expected As Double)

        'Arrange

        'Act
        Dim actual As Double = Calculator.Divide(x, y)

        'Assert
        Assert.Equal(expected, actual)

    End Sub

    <Fact>
    Public Sub Divide_DivideByZero()

        'Arrange
        Dim expected As Double = 0D

        'Act
        Dim actual As Double = Calculator.Divide(15, 0)

        'Assert
        Assert.Equal(expected, actual)

    End Sub

End Class
