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
        Me.Dice1 = New CustomControlDemo.Dice()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.Tracker1 = New CustomControlDemo.Tracker()
        Me.Dice2 = New CustomControlDemo.Dice()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrentMoney = New System.Windows.Forms.Label()
        Me.lblMaxMoney = New System.Windows.Forms.Label()
        Me.lblNumOfRounds = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Dice1
        '
        Me.Dice1.Location = New System.Drawing.Point(329, 64)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(147, 137)
        Me.Dice1.TabIndex = 1
        Me.Dice1.value = 0
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(211, 235)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(147, 50)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "roll it BABY"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'Tracker1
        '
        Me.Tracker1.Location = New System.Drawing.Point(46, 325)
        Me.Tracker1.Name = "Tracker1"
        Me.Tracker1.Size = New System.Drawing.Size(202, 386)
        Me.Tracker1.TabIndex = 3
        '
        'Dice2
        '
        Me.Dice2.Location = New System.Drawing.Point(109, 64)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(139, 137)
        Me.Dice2.TabIndex = 4
        Me.Dice2.value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Money:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Max Money:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number Of Rounds:"
        '
        'lblCurrentMoney
        '
        Me.lblCurrentMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentMoney.Location = New System.Drawing.Point(439, 369)
        Me.lblCurrentMoney.Name = "lblCurrentMoney"
        Me.lblCurrentMoney.Size = New System.Drawing.Size(100, 23)
        Me.lblCurrentMoney.TabIndex = 8
        Me.lblCurrentMoney.Text = "0"
        Me.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaxMoney
        '
        Me.lblMaxMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxMoney.Location = New System.Drawing.Point(439, 408)
        Me.lblMaxMoney.Name = "lblMaxMoney"
        Me.lblMaxMoney.Size = New System.Drawing.Size(100, 23)
        Me.lblMaxMoney.TabIndex = 9
        Me.lblMaxMoney.Text = "0"
        Me.lblMaxMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumOfRounds
        '
        Me.lblNumOfRounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumOfRounds.Location = New System.Drawing.Point(439, 449)
        Me.lblNumOfRounds.Name = "lblNumOfRounds"
        Me.lblNumOfRounds.Size = New System.Drawing.Size(100, 23)
        Me.lblNumOfRounds.TabIndex = 10
        Me.lblNumOfRounds.Text = "0"
        Me.lblNumOfRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 652)
        Me.Controls.Add(Me.lblNumOfRounds)
        Me.Controls.Add(Me.lblMaxMoney)
        Me.Controls.Add(Me.lblCurrentMoney)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.Tracker1)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Dice1)
        Me.Name = "Form1"
        Me.Text = "Lucky Sevens"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dice1 As Dice
    Friend WithEvents btnRoll As Button
    Friend WithEvents Tracker1 As Tracker
    Friend WithEvents Dice2 As Dice
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCurrentMoney As Label
    Friend WithEvents lblMaxMoney As Label
    Friend WithEvents lblNumOfRounds As Label
End Class
