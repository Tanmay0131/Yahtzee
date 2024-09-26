Public Class Form1
    Private diceArr() As Dice
    Private numArray(6)
    Dim canRoll As Boolean = True
    Dim counter As Integer = 0

    Private Sub EndGame()
        Form2.Show()
    End Sub

    Private Sub GameOver()
        If btnAces.Enabled = False AndAlso btnTwos.Enabled = False AndAlso btnThrees.Enabled = False AndAlso btnFours.Enabled = False AndAlso btnFives.Enabled = False AndAlso btnSixes.Enabled = False Then
            If btn3OfAKind.Enabled = False AndAlso btn4OfAKind.Enabled = False AndAlso btnFullHouse.Enabled = False AndAlso btnSmallStraight.Enabled = False AndAlso btnLargeStraight.Enabled = False AndAlso btnYahtzee.Enabled = False AndAlso btnChance.Enabled = False Then
                Dim upper, lower As Integer
                Integer.TryParse(lblUpperTotal.Text, upper)
                Integer.TryParse(lblLowerTotal.Text, lower)
                Dim grandTotal As Integer = upper + lower
                lblGrandTotal.Text = grandTotal.ToString()
                btnRoll.Enabled = False
                EndGame()
            End If
        End If
    End Sub

    Private Sub ResetDice()
        For Each d As Dice In diceArr
            d.value = 0
        Next
        counter = 0
        lblCounterVal.Text = counter.ToString()
        canRoll = True
        btnRoll.Enabled = True
        LowerTotal()
        manageCheckState()
        GameOver()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        diceArr = {Dice1, Dice2, Dice3, Dice4, Dice5}
        ResetDice()
        CBDice1.Enabled = False
        CBDice2.Enabled = False
        CBDice3.Enabled = False
        CBDice4.Enabled = False
        CBDice5.Enabled = False
    End Sub

    Private Sub UpdateNumArray()
        'reset all values in num array
        For i As Integer = 0 To numArray.Length - 1
            numArray(i) = 0
        Next
        'set the values to  the num array
        For Each d As Dice In diceArr
            numArray(d.value) += 1
        Next
    End Sub

    Private Sub kimJungUnSpam()
        Form4.Show()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim rand As New Random
        Dim counter3 As Integer = rand.Next(1, 21)
        If counter3 = 20 Then
            kimJungUnSpam()
        End If
        Dim counter2 As Integer
        If canRoll = True Then
            If CBDice1.Checked Then
                Dice1.Roll()
                counter2 += 1
            End If
            If CBDice2.Checked Then
                Dice2.Roll()
                counter2 += 1
            End If
            If CBDice3.Checked Then
                Dice3.Roll()
                counter2 += 1
            End If
            If CBDice4.Checked Then
                Dice4.Roll()
                counter2 += 1
            End If
            If CBDice5.Checked Then
                Dice5.Roll()
                counter2 += 1
            End If
            If counter2 > 0 Then
                Integer.TryParse(lblCounterVal.Text, counter)
                counter += 1
                If counter = 3 Then
                    canRoll = False
                    btnRoll.Enabled = False
                End If
                lblCounterVal.Text = counter.ToString()
                UpdateNumArray()
                CBDice1.Enabled = True
                CBDice2.Enabled = True
                CBDice3.Enabled = True
                CBDice4.Enabled = True
                CBDice5.Enabled = True
            End If
        End If
    End Sub

    Private Sub ConfirmUpdate(ByVal place As String, ByVal score As Integer, ByRef txtBox As Label, ByRef btn As Button)
        Dim result As DialogResult = MessageBox.Show("Use the " & place & " place for a score of " & score & "?",
"Are you sure?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            txtBox.Text = score.ToString()
            btn.Enabled = False
            ResetDice()

        End If

    End Sub

    Function GetDiceTotal() As Integer
        Dim sum As Integer = 0
        For Each d As Dice In diceArr
            sum += d.value
        Next
        Return sum
    End Function

    Function getCertainDiceTotal(certainDice As Integer) As Integer
        Dim sum As Integer = 0
        sum = numArray(certainDice) * certainDice
        Return sum
    End Function

    Private Sub UpperTotal()
        Dim sum, val1, val2, val3, val4, val5, val6 As Integer
        Integer.TryParse(lblAces.Text, val1)
        Integer.TryParse(lblTwos.Text, val2)
        Integer.TryParse(lblThrees.Text, val3)
        Integer.TryParse(lblFours.Text, val4)
        Integer.TryParse(lblFives.Text, val5)
        Integer.TryParse(lblSixes.Text, val6)
        sum = val1 + val2 + val3 + val4 + val5 + val6
        lblUpperTotal.Text = sum.ToString()
        If sum > 63 Then
            lblBonus.Text = 35
        End If
    End Sub

    Private Sub LowerTotal()
        Dim sum, val1, val2, val3, val4, val5, val6, val7 As Integer
        Integer.TryParse(lbl3OfAKind.Text, val1)
        Integer.TryParse(lbl4OfAkind.Text, val2)
        Integer.TryParse(lblFullHouse.Text, val3)
        Integer.TryParse(lblSmallStraight.Text, val4)
        Integer.TryParse(lblLargeStraight.Text, val5)
        Integer.TryParse(lblYahtzee.Text, val6)
        Integer.TryParse(lblChance.Text, val7)
        sum = val1 + val2 + val3 + val4 + val5 + val6 + val7
        lblLowerTotal.Text = sum.ToString()
    End Sub

    Private Sub btnAces_Click(sender As Object, e As EventArgs) Handles btnAces.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblAces.Text, int)
            If int = 0 Then
                Dim sum As Integer = 0
                sum = getCertainDiceTotal(1)
                Dim place, score As String
                place = "Aces"
                score = sum.ToString
                Dim result As DialogResult = MessageBox.Show("Use the " & place & " place for a score of " & score & "?", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    lblAces.Text = sum.ToString
                    btnAces.Enabled = False
                    counter = 0
                    lblCounterVal.Text = counter.ToString()
                    canRoll = True
                    btnRoll.Enabled = True
                    UpperTotal()
                    CBDice1.Checked = True
                    CBDice1.Enabled = False
                    CBDice2.Checked = True
                    CBDice2.Enabled = False
                    CBDice3.Checked = True
                    CBDice3.Enabled = False
                    CBDice4.Checked = True
                    CBDice4.Enabled = False
                    CBDice5.Checked = True
                    CBDice5.Enabled = False
                    ResetDice()
                    GameOver()
                End If
            End If
        End If
    End Sub

    Private Sub btnTwos_Click(sender As Object, e As EventArgs) Handles btnTwos.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblTwos.Text, int)
            If int = 0 Then
                Dim sum As Integer = 0
                sum = getCertainDiceTotal(2)
                Dim place, score As String
                place = "Twos"
                score = sum.ToString
                Dim result As DialogResult = MessageBox.Show("Use the " & place & " place for a score of " & score & "?", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    lblTwos.Text = sum.ToString
                    btnTwos.Enabled = False
                    counter = 0
                    lblCounterVal.Text = counter.ToString()
                    canRoll = True
                    btnRoll.Enabled = True
                    UpperTotal()
                    CBDice1.Checked = True
                    CBDice1.Enabled = False
                    CBDice2.Checked = True
                    CBDice2.Enabled = False
                    CBDice3.Checked = True
                    CBDice3.Enabled = False
                    CBDice4.Checked = True
                    CBDice4.Enabled = False
                    CBDice5.Checked = True
                    CBDice5.Enabled = False
                    ResetDice()
                    GameOver()
                End If
            End If
        End If
    End Sub

    Private Sub btnThrees_Click(sender As Object, e As EventArgs) Handles btnThrees.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblThrees.Text, int)
            If int = 0 Then
                Dim sum As Integer = 0
                sum = getCertainDiceTotal(3)
                Dim place, score As String
                place = "Threes"
                score = sum.ToString
                Dim result As DialogResult = MessageBox.Show("Use the " & place & " place for a score of " & score & "?", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    lblThrees.Text = sum.ToString
                    btnThrees.Enabled = False
                    counter = 0
                    lblCounterVal.Text = counter.ToString()
                    canRoll = True
                    btnRoll.Enabled = True
                    UpperTotal()
                    CBDice1.Checked = True
                    CBDice1.Enabled = False
                    CBDice2.Checked = True
                    CBDice2.Enabled = False
                    CBDice3.Checked = True
                    CBDice3.Enabled = False
                    CBDice4.Checked = True
                    CBDice4.Enabled = False
                    CBDice5.Checked = True
                    CBDice5.Enabled = False
                    ResetDice()
                    GameOver()
                End If
            End If
        End If
    End Sub

    Private Sub btnFours_Click(sender As Object, e As EventArgs) Handles btnFours.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblFours.Text, int)
            If int = 0 Then
                Dim sum As Integer = 0
                sum = getCertainDiceTotal(4)
                Dim place, score As String
                place = "Fours"
                score = sum.ToString
                Dim result As DialogResult = MessageBox.Show("Use the " & place & " place for a score of " & score & "?", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    lblFours.Text = sum.ToString
                    btnFours.Enabled = False
                    counter = 0
                    lblCounterVal.Text = counter.ToString()
                    canRoll = True
                    btnRoll.Enabled = True
                    UpperTotal()
                    CBDice1.Checked = True
                    CBDice1.Enabled = False
                    CBDice2.Checked = True
                    CBDice2.Enabled = False
                    CBDice3.Checked = True
                    CBDice3.Enabled = False
                    CBDice4.Checked = True
                    CBDice4.Enabled = False
                    CBDice5.Checked = True
                    CBDice5.Enabled = False
                    ResetDice()
                    GameOver()
                End If
            End If
        End If
    End Sub

    Private Sub btnFives_Click(sender As Object, e As EventArgs) Handles btnFives.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblFives.Text, int)
            If int = 0 Then
                Dim sum As Integer = 0
                sum = getCertainDiceTotal(5)
                Dim place, score As String
                place = "Fives"
                score = sum.ToString
                Dim result As DialogResult = MessageBox.Show("Use the " & place & " place for a score of " & score & "?", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    lblFives.Text = sum.ToString
                    btnFives.Enabled = False
                    counter = 0
                    lblCounterVal.Text = counter.ToString()
                    canRoll = True
                    btnRoll.Enabled = True
                    UpperTotal()
                    CBDice1.Checked = True
                    CBDice1.Enabled = False
                    CBDice2.Checked = True
                    CBDice2.Enabled = False
                    CBDice3.Checked = True
                    CBDice3.Enabled = False
                    CBDice4.Checked = True
                    CBDice4.Enabled = False
                    CBDice5.Checked = True
                    CBDice5.Enabled = False
                    ResetDice()
                    GameOver()
                End If
            End If
        End If
    End Sub

    Private Sub btnSixes_Click(sender As Object, e As EventArgs) Handles btnSixes.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblSixes.Text, int)
            If int = 0 Then
                Dim sum As Integer = 0
                sum = getCertainDiceTotal(6)
                Dim place, score As String
                place = "Sixes"
                score = sum.ToString
                Dim result As DialogResult = MessageBox.Show("Use the " & place & " place for a score of " & score & "?", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    lblSixes.Text = sum.ToString
                    btnSixes.Enabled = False
                    counter = 0
                    lblCounterVal.Text = counter.ToString()
                    canRoll = True
                    btnRoll.Enabled = True
                    UpperTotal()
                    ResetDice()
                    manageCheckState()
                    GameOver()
                End If
            End If
        End If
    End Sub

    Public Sub manageCheckState()

        CBDice1.Checked = True
        CBDice1.Enabled = False
        CBDice2.Checked = True
        CBDice2.Enabled = False
        CBDice3.Checked = True
        CBDice3.Enabled = False
        CBDice4.Checked = True
        CBDice4.Enabled = False
        CBDice5.Checked = True
        CBDice5.Enabled = False
    End Sub

    Private Sub btn3OfAKind_Click(sender As Object, e As EventArgs) Handles btn3OfAKind.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lbl3OfAKind.Text, int)
            If int = 0 Then
                Dim ThreeOfAKind As Boolean = False
                For Each d In numArray
                    If d >= 3 Then
                        ThreeOfAKind = True
                        Exit For
                    End If
                Next
                Dim score As String
                score = IIf(ThreeOfAKind, GetDiceTotal(), 0)
                ConfirmUpdate("3 of a kind", score, lbl3OfAKind, btn3OfAKind)
            End If
        End If
    End Sub

    Private Sub btn4OfAKind_Click(sender As Object, e As EventArgs) Handles btn4OfAKind.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lbl4OfAkind.Text, int)
            If int = 0 Then
                Dim FourOfAKind As Boolean = False
                For Each d In numArray
                    If d >= 4 Then
                        FourOfAKind = True
                        Exit For
                    End If
                Next

                Dim score As String
                score = IIf(FourOfAKind, GetDiceTotal(), 0)
                ConfirmUpdate("4 of a kind", score, lbl4OfAkind, btn4OfAKind)

            End If
        End If
    End Sub

    Private Sub btnFullHouse_Click(sender As Object, e As EventArgs) Handles btnFullHouse.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblFullHouse.Text, int)
            If int = 0 Then
                Dim FullHouse As Boolean = False
                Dim ThreeOfAKind As Boolean = False
                Dim TwoOfAKind As Boolean = False
                Dim counter2 As Integer
                For Each d In numArray
                    counter2 += 1
                    If d = 2 Then
                        TwoOfAKind = True
                        Exit For
                    End If
                Next
                For Each d In numArray
                    If d <> counter2 Then
                        If d = 3 Then
                            ThreeOfAKind = True
                            Exit For
                        End If
                    End If
                Next
                If TwoOfAKind = True AndAlso ThreeOfAKind = True Then
                    FullHouse = True
                End If
                Dim score As String
                score = IIf(FullHouse, 25, 0)
                ConfirmUpdate("Full House", score, lblFullHouse, btnFullHouse)
            End If
        End If
    End Sub

    Private Sub btnSmallStraight_Click(sender As Object, e As EventArgs) Handles btnSmallStraight.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblSmallStraight.Text, int)
            If int = 0 Then
                Dim SmallStraight As Boolean = False
                Dim counter2 As Integer
                For Each d In numArray
                    If d = 1 Then
                        counter2 += 1
                    ElseIf d = 0 Then
                        counter2 = 0
                    End If
                Next
                If counter2 >= 3 Then
                    SmallStraight = True
                End If
                Dim score As String
                score = IIf(SmallStraight, 30, 0)
                ConfirmUpdate("Small Straight", score, lblSmallStraight, btnSmallStraight)
            End If
        End If
    End Sub

    Private Sub btnLargeStraight_Click(sender As Object, e As EventArgs) Handles btnLargeStraight.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblLargeStraight.Text, int)
            If int = 0 Then
                Dim LargeStraight As Boolean = False
                Dim counter2 As Integer
                For Each d In numArray
                    If d = 1 Then
                        counter2 += 1
                    ElseIf d = 0 Then
                        counter2 = 0
                    End If
                Next
                If counter2 >= 4 Then
                    LargeStraight = True
                End If
                Dim score As String
                score = IIf(LargeStraight, 40, 0)
                ConfirmUpdate("Large Straight", score, lblLargeStraight, btnLargeStraight)
            End If
        End If
    End Sub

    Private Sub btnYahtzee_Click(sender As Object, e As EventArgs) Handles btnYahtzee.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblYahtzee.Text, int)
            If int = 0 Then
                Dim Yahtzee As Boolean = False
                For Each d In numArray
                    If d = 5 Then
                        Yahtzee = True
                        Exit For
                    End If
                Next
                Dim score As String
                score = IIf(Yahtzee, 50, 0)
                ConfirmUpdate("Yahtzee", score, lblYahtzee, btnYahtzee)
            End If
        End If
    End Sub

    Private Sub btnChance_Click(sender As Object, e As EventArgs) Handles btnChance.Click
        If counter <> 0 Then
            Dim int As Integer = 0
            Integer.TryParse(lblChance.Text, int)
            If int = 0 Then
                Dim score As String
                score = GetDiceTotal()
                ConfirmUpdate("Chance", score, lblChance, btnChance)
            End If
        End If
    End Sub


End Class
