<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BlackJack
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnShowCards = New System.Windows.Forms.Button()
        Me.btnTakeOneCard = New System.Windows.Forms.Button()
        Me.btnShuffle = New System.Windows.Forms.Button()
        Me.btnJoinPlayer = New System.Windows.Forms.Button()
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.btnDisplayBack = New System.Windows.Forms.Button()
        Me.toglDisplay = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowCards
        '
        Me.btnShowCards.Location = New System.Drawing.Point(225, 365)
        Me.btnShowCards.Name = "btnShowCards"
        Me.btnShowCards.Size = New System.Drawing.Size(94, 29)
        Me.btnShowCards.TabIndex = 21
        Me.btnShowCards.Text = "Show Cards"
        Me.btnShowCards.UseVisualStyleBackColor = True
        '
        'btnTakeOneCard
        '
        Me.btnTakeOneCard.Location = New System.Drawing.Point(587, 365)
        Me.btnTakeOneCard.Name = "btnTakeOneCard"
        Me.btnTakeOneCard.Size = New System.Drawing.Size(94, 29)
        Me.btnTakeOneCard.TabIndex = 22
        Me.btnTakeOneCard.Text = "Take a Card"
        Me.btnTakeOneCard.UseVisualStyleBackColor = True
        '
        'btnShuffle
        '
        Me.btnShuffle.Location = New System.Drawing.Point(750, 365)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(94, 29)
        Me.btnShuffle.TabIndex = 23
        Me.btnShuffle.Text = "Shuffle"
        Me.btnShuffle.UseVisualStyleBackColor = True
        '
        'btnJoinPlayer
        '
        Me.btnJoinPlayer.Location = New System.Drawing.Point(411, 365)
        Me.btnJoinPlayer.Name = "btnJoinPlayer"
        Me.btnJoinPlayer.Size = New System.Drawing.Size(94, 29)
        Me.btnJoinPlayer.TabIndex = 24
        Me.btnJoinPlayer.Text = "JoinPlayer"
        Me.btnJoinPlayer.UseVisualStyleBackColor = True
        '
        'tbMessage
        '
        Me.tbMessage.Location = New System.Drawing.Point(225, 412)
        Me.tbMessage.Multiline = True
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.ReadOnly = True
        Me.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbMessage.Size = New System.Drawing.Size(646, 196)
        Me.tbMessage.TabIndex = 25
        Me.tbMessage.TabStop = False
        '
        'btnDisplayBack
        '
        Me.btnDisplayBack.Location = New System.Drawing.Point(847, 254)
        Me.btnDisplayBack.Name = "btnDisplayBack"
        Me.btnDisplayBack.Size = New System.Drawing.Size(137, 29)
        Me.btnDisplayBack.TabIndex = 26
        Me.btnDisplayBack.Text = "Display Back"
        Me.btnDisplayBack.UseVisualStyleBackColor = True
        '
        'toglDisplay
        '
        Me.toglDisplay.Location = New System.Drawing.Point(847, 298)
        Me.toglDisplay.Name = "toglDisplay"
        Me.toglDisplay.Size = New System.Drawing.Size(137, 29)
        Me.toglDisplay.TabIndex = 27
        Me.toglDisplay.Text = "Display"
        Me.toglDisplay.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(911, 151)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(94, 29)
        Me.btnTest.TabIndex = 28
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'BlackJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 637)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.toglDisplay)
        Me.Controls.Add(Me.btnDisplayBack)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.btnJoinPlayer)
        Me.Controls.Add(Me.btnShuffle)
        Me.Controls.Add(Me.btnTakeOneCard)
        Me.Controls.Add(Me.btnShowCards)
        Me.Name = "BlackJack"
        Me.Text = "Black Jack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowCards As Button
    Friend WithEvents btnTakeOneCard As Button
    Friend WithEvents btnShuffle As Button
    Friend WithEvents btnJoinPlayer As Button
    Friend WithEvents tbMessage As TextBox
    Friend WithEvents btnDisplayBack As Button
    Friend WithEvents toglDisplay As Button
    Friend WithEvents btnTest As Button
End Class
