Public Module Calculator

    Public Function Add(x As Double, y As Double) As Double

        Return x + y

    End Function

    Public Function Subtract(x As Double, y As Double) As Double

        Return x - y

    End Function

    Public Function Multiply(x As Double, y As Double) As Double

        Return x * y

    End Function

    Public Function Divide(x As Double, y As Double) As Double

        If y <> 0 Then


            Return x / y
        Else

            ' Custom business logic for Divide by Zero.
            Return 0

        End If


    End Function

End Module
