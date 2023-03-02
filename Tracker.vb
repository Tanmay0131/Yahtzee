Public Class Tracker
    Private counts(6) As Integer

    Public Sub update(num As Integer)
        If num < 0 OrElse num > 6 Then
            Return
        Else
            counts(num) += 1
            updateLabels()
        End If
    End Sub

    Private Sub updateLabels()
        lbl1.Text = counts(1).ToString
        lbl2.Text = counts(2).ToString
        lbl3.Text = counts(3).ToString
        lbl4.Text = counts(4).ToString
        lbl5.Text = counts(5).ToString
        lbl6.Text = counts(6).ToString
    End Sub
End Class
