Public Class Form1
    Dim currentMoney As Integer = 20
    Dim maxMoney, numOfRounds As Integer
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        If currentMoney > 0 Then
            Dice1.Roll()
            Dice2.Roll()
            Tracker1.update(Dice1.value)
            Tracker1.update(Dice2.value)
            If Dice1.value + Dice2.value = 7 Then
                currentMoney += 4
                If maxMoney < currentMoney Then
                    maxMoney = currentMoney
                End If
            Else
                currentMoney -= 1
            End If
            numOfRounds += 1
            lblCurrentMoney.Text = currentMoney
            lblMaxMoney.Text = maxMoney
            lblNumOfRounds.Text = numOfRounds
        Else
            Form2.Show()
        End If
    End Sub
End Class
