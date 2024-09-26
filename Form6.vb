Public Class Form6
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form5.Close()
        Form4.Show()
    End Sub

    Private Sub btnDefeat_Click(sender As Object, e As EventArgs) Handles btnDefeat.Click
        Form7.Show()
    End Sub
End Class