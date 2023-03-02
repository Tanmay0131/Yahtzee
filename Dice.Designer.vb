<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dice
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.picFace = New System.Windows.Forms.PictureBox()
        CType(Me.picFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFace
        '
        Me.picFace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picFace.Image = Global.CustomControlDemo.My.Resources.Resources.Alea_0
        Me.picFace.Location = New System.Drawing.Point(0, 0)
        Me.picFace.Name = "picFace"
        Me.picFace.Size = New System.Drawing.Size(366, 310)
        Me.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFace.TabIndex = 0
        Me.picFace.TabStop = False
        '
        'Dice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picFace)
        Me.Name = "Dice"
        Me.Size = New System.Drawing.Size(366, 310)
        CType(Me.picFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picFace As PictureBox
End Class
