<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.CBDice1 = New System.Windows.Forms.CheckBox()
        Me.CBDice2 = New System.Windows.Forms.CheckBox()
        Me.CBDice3 = New System.Windows.Forms.CheckBox()
        Me.CBDice4 = New System.Windows.Forms.CheckBox()
        Me.CBDice5 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblAces = New System.Windows.Forms.Label()
        Me.lblTwos = New System.Windows.Forms.Label()
        Me.lblThrees = New System.Windows.Forms.Label()
        Me.lblFours = New System.Windows.Forms.Label()
        Me.lblFives = New System.Windows.Forms.Label()
        Me.lblSixes = New System.Windows.Forms.Label()
        Me.lblUpperTotal = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lbl3OfAKind = New System.Windows.Forms.Label()
        Me.lbl4OfAkind = New System.Windows.Forms.Label()
        Me.lblFullHouse = New System.Windows.Forms.Label()
        Me.lblSmallStraight = New System.Windows.Forms.Label()
        Me.lblLargeStraight = New System.Windows.Forms.Label()
        Me.lblYahtzee = New System.Windows.Forms.Label()
        Me.lblChance = New System.Windows.Forms.Label()
        Me.lblLowerTotal = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.btnAces = New System.Windows.Forms.Button()
        Me.btnTwos = New System.Windows.Forms.Button()
        Me.btnThrees = New System.Windows.Forms.Button()
        Me.btnFours = New System.Windows.Forms.Button()
        Me.btnFives = New System.Windows.Forms.Button()
        Me.btnSixes = New System.Windows.Forms.Button()
        Me.btn3OfAKind = New System.Windows.Forms.Button()
        Me.btn4OfAKind = New System.Windows.Forms.Button()
        Me.btnFullHouse = New System.Windows.Forms.Button()
        Me.btnSmallStraight = New System.Windows.Forms.Button()
        Me.btnLargeStraight = New System.Windows.Forms.Button()
        Me.btnYahtzee = New System.Windows.Forms.Button()
        Me.btnChance = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblCounterVal = New System.Windows.Forms.Label()
        Me.Dice5 = New CustomControlDemo.Dice()
        Me.Dice4 = New CustomControlDemo.Dice()
        Me.Dice3 = New CustomControlDemo.Dice()
        Me.Dice2 = New CustomControlDemo.Dice()
        Me.Dice1 = New CustomControlDemo.Dice()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(1219, 539)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(147, 50)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "roll it BABY"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'CBDice1
        '
        Me.CBDice1.AutoSize = True
        Me.CBDice1.Checked = True
        Me.CBDice1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDice1.Location = New System.Drawing.Point(799, 466)
        Me.CBDice1.Name = "CBDice1"
        Me.CBDice1.Size = New System.Drawing.Size(97, 17)
        Me.CBDice1.TabIndex = 14
        Me.CBDice1.Text = "Roll This Again"
        Me.CBDice1.UseVisualStyleBackColor = True
        '
        'CBDice2
        '
        Me.CBDice2.AutoSize = True
        Me.CBDice2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CBDice2.Checked = True
        Me.CBDice2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDice2.Location = New System.Drawing.Point(1017, 466)
        Me.CBDice2.Name = "CBDice2"
        Me.CBDice2.Size = New System.Drawing.Size(97, 17)
        Me.CBDice2.TabIndex = 15
        Me.CBDice2.Text = "Roll This Again"
        Me.CBDice2.UseVisualStyleBackColor = True
        '
        'CBDice3
        '
        Me.CBDice3.AutoSize = True
        Me.CBDice3.Checked = True
        Me.CBDice3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDice3.Location = New System.Drawing.Point(1241, 466)
        Me.CBDice3.Name = "CBDice3"
        Me.CBDice3.Size = New System.Drawing.Size(97, 17)
        Me.CBDice3.TabIndex = 16
        Me.CBDice3.Text = "Roll This Again"
        Me.CBDice3.UseVisualStyleBackColor = True
        '
        'CBDice4
        '
        Me.CBDice4.AutoSize = True
        Me.CBDice4.Checked = True
        Me.CBDice4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDice4.Location = New System.Drawing.Point(1459, 466)
        Me.CBDice4.Name = "CBDice4"
        Me.CBDice4.Size = New System.Drawing.Size(97, 17)
        Me.CBDice4.TabIndex = 17
        Me.CBDice4.Text = "Roll This Again"
        Me.CBDice4.UseVisualStyleBackColor = True
        '
        'CBDice5
        '
        Me.CBDice5.AutoSize = True
        Me.CBDice5.Checked = True
        Me.CBDice5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDice5.Location = New System.Drawing.Point(1688, 466)
        Me.CBDice5.Name = "CBDice5"
        Me.CBDice5.Size = New System.Drawing.Size(97, 17)
        Me.CBDice5.TabIndex = 18
        Me.CBDice5.Text = "Roll This Again"
        Me.CBDice5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Aces"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 31)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Twos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 31)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Threes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Fours"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 31)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fives"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 31)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Sixes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(380, 31)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Total Score (of Upper Section)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 461)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 31)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "3 Of A Kind"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(288, 31)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Bonus (If total over 63)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 510)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 31)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "4 Of A Kind"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 555)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 31)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Full House"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 597)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(182, 31)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Small Straight"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(72, 640)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 31)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Large Straight"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(72, 683)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 31)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Yahtzee"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 724)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 31)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Chance"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(72, 796)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(380, 31)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Total Score (of Lower Section)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(72, 874)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(208, 31)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "GRAND TOTAL"
        '
        'lblAces
        '
        Me.lblAces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAces.Location = New System.Drawing.Point(174, 65)
        Me.lblAces.Name = "lblAces"
        Me.lblAces.Size = New System.Drawing.Size(115, 31)
        Me.lblAces.TabIndex = 36
        Me.lblAces.Text = "0"
        Me.lblAces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwos
        '
        Me.lblTwos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwos.Location = New System.Drawing.Point(174, 107)
        Me.lblTwos.Name = "lblTwos"
        Me.lblTwos.Size = New System.Drawing.Size(115, 31)
        Me.lblTwos.TabIndex = 37
        Me.lblTwos.Text = "0"
        Me.lblTwos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThrees
        '
        Me.lblThrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThrees.Location = New System.Drawing.Point(174, 151)
        Me.lblThrees.Name = "lblThrees"
        Me.lblThrees.Size = New System.Drawing.Size(115, 31)
        Me.lblThrees.TabIndex = 38
        Me.lblThrees.Text = "0"
        Me.lblThrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFours
        '
        Me.lblFours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFours.Location = New System.Drawing.Point(174, 196)
        Me.lblFours.Name = "lblFours"
        Me.lblFours.Size = New System.Drawing.Size(115, 31)
        Me.lblFours.TabIndex = 39
        Me.lblFours.Text = "0"
        Me.lblFours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFives
        '
        Me.lblFives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFives.Location = New System.Drawing.Point(174, 242)
        Me.lblFives.Name = "lblFives"
        Me.lblFives.Size = New System.Drawing.Size(115, 31)
        Me.lblFives.TabIndex = 40
        Me.lblFives.Text = "0"
        Me.lblFives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSixes
        '
        Me.lblSixes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSixes.Location = New System.Drawing.Point(174, 288)
        Me.lblSixes.Name = "lblSixes"
        Me.lblSixes.Size = New System.Drawing.Size(115, 31)
        Me.lblSixes.TabIndex = 41
        Me.lblSixes.Text = "0"
        Me.lblSixes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUpperTotal
        '
        Me.lblUpperTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpperTotal.Location = New System.Drawing.Point(488, 346)
        Me.lblUpperTotal.Name = "lblUpperTotal"
        Me.lblUpperTotal.Size = New System.Drawing.Size(115, 31)
        Me.lblUpperTotal.TabIndex = 42
        Me.lblUpperTotal.Text = "0"
        Me.lblUpperTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBonus
        '
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonus.Location = New System.Drawing.Point(488, 393)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(115, 31)
        Me.lblBonus.TabIndex = 43
        Me.lblBonus.Text = "0"
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3OfAKind
        '
        Me.lbl3OfAKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3OfAKind.Location = New System.Drawing.Point(281, 461)
        Me.lbl3OfAKind.Name = "lbl3OfAKind"
        Me.lbl3OfAKind.Size = New System.Drawing.Size(115, 31)
        Me.lbl3OfAKind.TabIndex = 44
        Me.lbl3OfAKind.Text = "0"
        Me.lbl3OfAKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4OfAkind
        '
        Me.lbl4OfAkind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4OfAkind.Location = New System.Drawing.Point(281, 510)
        Me.lbl4OfAkind.Name = "lbl4OfAkind"
        Me.lbl4OfAkind.Size = New System.Drawing.Size(115, 31)
        Me.lbl4OfAkind.TabIndex = 45
        Me.lbl4OfAkind.Text = "0"
        Me.lbl4OfAkind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFullHouse
        '
        Me.lblFullHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullHouse.Location = New System.Drawing.Point(281, 555)
        Me.lblFullHouse.Name = "lblFullHouse"
        Me.lblFullHouse.Size = New System.Drawing.Size(115, 31)
        Me.lblFullHouse.TabIndex = 46
        Me.lblFullHouse.Text = "0"
        Me.lblFullHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSmallStraight
        '
        Me.lblSmallStraight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSmallStraight.Location = New System.Drawing.Point(281, 597)
        Me.lblSmallStraight.Name = "lblSmallStraight"
        Me.lblSmallStraight.Size = New System.Drawing.Size(115, 31)
        Me.lblSmallStraight.TabIndex = 47
        Me.lblSmallStraight.Text = "0"
        Me.lblSmallStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLargeStraight
        '
        Me.lblLargeStraight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLargeStraight.Location = New System.Drawing.Point(281, 640)
        Me.lblLargeStraight.Name = "lblLargeStraight"
        Me.lblLargeStraight.Size = New System.Drawing.Size(115, 31)
        Me.lblLargeStraight.TabIndex = 48
        Me.lblLargeStraight.Text = "0"
        Me.lblLargeStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYahtzee
        '
        Me.lblYahtzee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYahtzee.Location = New System.Drawing.Point(281, 683)
        Me.lblYahtzee.Name = "lblYahtzee"
        Me.lblYahtzee.Size = New System.Drawing.Size(115, 31)
        Me.lblYahtzee.TabIndex = 49
        Me.lblYahtzee.Text = "0"
        Me.lblYahtzee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChance
        '
        Me.lblChance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChance.Location = New System.Drawing.Point(281, 724)
        Me.lblChance.Name = "lblChance"
        Me.lblChance.Size = New System.Drawing.Size(115, 31)
        Me.lblChance.TabIndex = 50
        Me.lblChance.Text = "0"
        Me.lblChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowerTotal
        '
        Me.lblLowerTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLowerTotal.Location = New System.Drawing.Point(488, 796)
        Me.lblLowerTotal.Name = "lblLowerTotal"
        Me.lblLowerTotal.Size = New System.Drawing.Size(115, 31)
        Me.lblLowerTotal.TabIndex = 51
        Me.lblLowerTotal.Text = "0"
        Me.lblLowerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrandTotal.Location = New System.Drawing.Point(488, 874)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(115, 31)
        Me.lblGrandTotal.TabIndex = 52
        Me.lblGrandTotal.Text = "0"
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAces
        '
        Me.btnAces.Location = New System.Drawing.Point(321, 65)
        Me.btnAces.Name = "btnAces"
        Me.btnAces.Size = New System.Drawing.Size(126, 31)
        Me.btnAces.TabIndex = 53
        Me.btnAces.Text = "Pick This"
        Me.btnAces.UseVisualStyleBackColor = True
        '
        'btnTwos
        '
        Me.btnTwos.Location = New System.Drawing.Point(321, 107)
        Me.btnTwos.Name = "btnTwos"
        Me.btnTwos.Size = New System.Drawing.Size(126, 31)
        Me.btnTwos.TabIndex = 54
        Me.btnTwos.Text = "Pick This"
        Me.btnTwos.UseVisualStyleBackColor = True
        '
        'btnThrees
        '
        Me.btnThrees.Location = New System.Drawing.Point(321, 151)
        Me.btnThrees.Name = "btnThrees"
        Me.btnThrees.Size = New System.Drawing.Size(126, 31)
        Me.btnThrees.TabIndex = 55
        Me.btnThrees.Text = "Pick This"
        Me.btnThrees.UseVisualStyleBackColor = True
        '
        'btnFours
        '
        Me.btnFours.Location = New System.Drawing.Point(321, 196)
        Me.btnFours.Name = "btnFours"
        Me.btnFours.Size = New System.Drawing.Size(126, 31)
        Me.btnFours.TabIndex = 56
        Me.btnFours.Text = "Pick This"
        Me.btnFours.UseVisualStyleBackColor = True
        '
        'btnFives
        '
        Me.btnFives.Location = New System.Drawing.Point(321, 242)
        Me.btnFives.Name = "btnFives"
        Me.btnFives.Size = New System.Drawing.Size(126, 31)
        Me.btnFives.TabIndex = 57
        Me.btnFives.Text = "Pick This"
        Me.btnFives.UseVisualStyleBackColor = True
        '
        'btnSixes
        '
        Me.btnSixes.Location = New System.Drawing.Point(321, 288)
        Me.btnSixes.Name = "btnSixes"
        Me.btnSixes.Size = New System.Drawing.Size(126, 31)
        Me.btnSixes.TabIndex = 58
        Me.btnSixes.Text = "Pick This"
        Me.btnSixes.UseVisualStyleBackColor = True
        '
        'btn3OfAKind
        '
        Me.btn3OfAKind.Location = New System.Drawing.Point(425, 461)
        Me.btn3OfAKind.Name = "btn3OfAKind"
        Me.btn3OfAKind.Size = New System.Drawing.Size(126, 31)
        Me.btn3OfAKind.TabIndex = 61
        Me.btn3OfAKind.Text = "Pick This"
        Me.btn3OfAKind.UseVisualStyleBackColor = True
        '
        'btn4OfAKind
        '
        Me.btn4OfAKind.Location = New System.Drawing.Point(425, 510)
        Me.btn4OfAKind.Name = "btn4OfAKind"
        Me.btn4OfAKind.Size = New System.Drawing.Size(126, 31)
        Me.btn4OfAKind.TabIndex = 62
        Me.btn4OfAKind.Text = "Pick This"
        Me.btn4OfAKind.UseVisualStyleBackColor = True
        '
        'btnFullHouse
        '
        Me.btnFullHouse.Location = New System.Drawing.Point(425, 555)
        Me.btnFullHouse.Name = "btnFullHouse"
        Me.btnFullHouse.Size = New System.Drawing.Size(126, 31)
        Me.btnFullHouse.TabIndex = 63
        Me.btnFullHouse.Text = "Pick This"
        Me.btnFullHouse.UseVisualStyleBackColor = True
        '
        'btnSmallStraight
        '
        Me.btnSmallStraight.Location = New System.Drawing.Point(425, 597)
        Me.btnSmallStraight.Name = "btnSmallStraight"
        Me.btnSmallStraight.Size = New System.Drawing.Size(126, 31)
        Me.btnSmallStraight.TabIndex = 64
        Me.btnSmallStraight.Text = "Pick This"
        Me.btnSmallStraight.UseVisualStyleBackColor = True
        '
        'btnLargeStraight
        '
        Me.btnLargeStraight.Location = New System.Drawing.Point(425, 640)
        Me.btnLargeStraight.Name = "btnLargeStraight"
        Me.btnLargeStraight.Size = New System.Drawing.Size(126, 31)
        Me.btnLargeStraight.TabIndex = 65
        Me.btnLargeStraight.Text = "Pick This"
        Me.btnLargeStraight.UseVisualStyleBackColor = True
        '
        'btnYahtzee
        '
        Me.btnYahtzee.Location = New System.Drawing.Point(425, 683)
        Me.btnYahtzee.Name = "btnYahtzee"
        Me.btnYahtzee.Size = New System.Drawing.Size(126, 31)
        Me.btnYahtzee.TabIndex = 66
        Me.btnYahtzee.Text = "Pick This"
        Me.btnYahtzee.UseVisualStyleBackColor = True
        '
        'btnChance
        '
        Me.btnChance.Location = New System.Drawing.Point(425, 730)
        Me.btnChance.Name = "btnChance"
        Me.btnChance.Size = New System.Drawing.Size(126, 31)
        Me.btnChance.TabIndex = 67
        Me.btnChance.Text = "Pick This"
        Me.btnChance.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(1063, 829)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(430, 31)
        Me.lblCounter.TabIndex = 68
        Me.lblCounter.Text = "Counter Before You Have To Pick:"
        '
        'lblCounterVal
        '
        Me.lblCounterVal.AutoSize = True
        Me.lblCounterVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounterVal.Location = New System.Drawing.Point(1499, 829)
        Me.lblCounterVal.Name = "lblCounterVal"
        Me.lblCounterVal.Size = New System.Drawing.Size(29, 31)
        Me.lblCounterVal.TabIndex = 69
        Me.lblCounterVal.Text = "0"
        '
        'Dice5
        '
        Me.Dice5.Location = New System.Drawing.Point(1667, 288)
        Me.Dice5.Name = "Dice5"
        Me.Dice5.Size = New System.Drawing.Size(147, 137)
        Me.Dice5.TabIndex = 13
        Me.Dice5.value = 0
        '
        'Dice4
        '
        Me.Dice4.Location = New System.Drawing.Point(1435, 288)
        Me.Dice4.Name = "Dice4"
        Me.Dice4.Size = New System.Drawing.Size(147, 137)
        Me.Dice4.TabIndex = 12
        Me.Dice4.value = 0
        '
        'Dice3
        '
        Me.Dice3.Location = New System.Drawing.Point(1219, 288)
        Me.Dice3.Name = "Dice3"
        Me.Dice3.Size = New System.Drawing.Size(147, 137)
        Me.Dice3.TabIndex = 11
        Me.Dice3.value = 0
        '
        'Dice2
        '
        Me.Dice2.Location = New System.Drawing.Point(1006, 288)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(139, 137)
        Me.Dice2.TabIndex = 4
        Me.Dice2.value = 0
        '
        'Dice1
        '
        Me.Dice1.Location = New System.Drawing.Point(778, 288)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(147, 137)
        Me.Dice1.TabIndex = 1
        Me.Dice1.value = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1919, 960)
        Me.Controls.Add(Me.lblCounterVal)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.btnChance)
        Me.Controls.Add(Me.btnYahtzee)
        Me.Controls.Add(Me.btnLargeStraight)
        Me.Controls.Add(Me.btnSmallStraight)
        Me.Controls.Add(Me.btnFullHouse)
        Me.Controls.Add(Me.btn4OfAKind)
        Me.Controls.Add(Me.btn3OfAKind)
        Me.Controls.Add(Me.btnSixes)
        Me.Controls.Add(Me.btnFives)
        Me.Controls.Add(Me.btnFours)
        Me.Controls.Add(Me.btnThrees)
        Me.Controls.Add(Me.btnTwos)
        Me.Controls.Add(Me.btnAces)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblLowerTotal)
        Me.Controls.Add(Me.lblChance)
        Me.Controls.Add(Me.lblYahtzee)
        Me.Controls.Add(Me.lblLargeStraight)
        Me.Controls.Add(Me.lblSmallStraight)
        Me.Controls.Add(Me.lblFullHouse)
        Me.Controls.Add(Me.lbl4OfAkind)
        Me.Controls.Add(Me.lbl3OfAKind)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblUpperTotal)
        Me.Controls.Add(Me.lblSixes)
        Me.Controls.Add(Me.lblFives)
        Me.Controls.Add(Me.lblFours)
        Me.Controls.Add(Me.lblThrees)
        Me.Controls.Add(Me.lblTwos)
        Me.Controls.Add(Me.lblAces)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBDice5)
        Me.Controls.Add(Me.CBDice4)
        Me.Controls.Add(Me.CBDice3)
        Me.Controls.Add(Me.CBDice2)
        Me.Controls.Add(Me.CBDice1)
        Me.Controls.Add(Me.Dice5)
        Me.Controls.Add(Me.Dice4)
        Me.Controls.Add(Me.Dice3)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Dice1)
        Me.Name = "Form1"
        Me.Text = "Yahtzee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dice1 As Dice
    Friend WithEvents btnRoll As Button
    Friend WithEvents Dice2 As Dice
    Friend WithEvents Dice3 As Dice
    Friend WithEvents Dice4 As Dice
    Friend WithEvents Dice5 As Dice
    Friend WithEvents CBDice1 As CheckBox
    Friend WithEvents CBDice2 As CheckBox
    Friend WithEvents CBDice3 As CheckBox
    Friend WithEvents CBDice4 As CheckBox
    Friend WithEvents CBDice5 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblAces As Label
    Friend WithEvents lblTwos As Label
    Friend WithEvents lblThrees As Label
    Friend WithEvents lblFours As Label
    Friend WithEvents lblFives As Label
    Friend WithEvents lblSixes As Label
    Friend WithEvents lblUpperTotal As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lbl3OfAKind As Label
    Friend WithEvents lbl4OfAkind As Label
    Friend WithEvents lblFullHouse As Label
    Friend WithEvents lblSmallStraight As Label
    Friend WithEvents lblLargeStraight As Label
    Friend WithEvents lblYahtzee As Label
    Friend WithEvents lblChance As Label
    Friend WithEvents lblLowerTotal As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents btnAces As Button
    Friend WithEvents btnTwos As Button
    Friend WithEvents btnThrees As Button
    Friend WithEvents btnFours As Button
    Friend WithEvents btnFives As Button
    Friend WithEvents btnSixes As Button
    Friend WithEvents btn3OfAKind As Button
    Friend WithEvents btn4OfAKind As Button
    Friend WithEvents btnFullHouse As Button
    Friend WithEvents btnSmallStraight As Button
    Friend WithEvents btnLargeStraight As Button
    Friend WithEvents btnYahtzee As Button
    Friend WithEvents btnChance As Button
    Friend WithEvents lblCounter As Label
    Friend WithEvents lblCounterVal As Label
End Class
