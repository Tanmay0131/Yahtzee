Public Class Form2
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Dim form3 As New Form1
        form3.Show()
        Me.Hide()
        Form1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

End Class