Public Class Dice
    Private Shared faces() As Image = {
    My.Resources.Alea_0, My.Resources.Alea_1, My.Resources.Alea_2,
    My.Resources.Alea_3, My.Resources.Alea_4, My.Resources.Alea_5,
    My.Resources.Alea_6}

    Private Shared rand As New Random

    Private _value As Integer = 0

    Public Property value As Integer
        Get
            Return _value
        End Get
        Set(value As Integer)
            If value < 0 OrElse value > 6 Then
                Return
            Else
                _value = value
                picFace.Image = faces(_value)
            End If
        End Set
    End Property

    Public Sub Roll()
        value = rand.Next(1, faces.Length)
    End Sub

End Class
