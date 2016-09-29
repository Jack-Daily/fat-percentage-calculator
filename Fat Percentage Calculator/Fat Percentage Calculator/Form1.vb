Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCalories.Clear()
        txtFat.Clear()
        lblPercentageOfCaloriesInFat.Text = String.Empty

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim userInputCalories As Double
        Dim userInputFat As Double
        Dim fatCaloriesCalculated As Double
        Dim percentFat As Double

        userInputCalories = CDbl(txtCalories.Text)
        userInputFat = CInt(txtFat.Text)

        fatCaloriesCalculated = userInputFat * 9
        percentFat = fatCaloriesCalculated / userInputCalories

        lblPercentageOfCaloriesInFat.Text = percentFat.ToString("p")







    End Sub
End Class
