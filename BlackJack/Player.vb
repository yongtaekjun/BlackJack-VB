Public Enum PlayerStatus As UInt16
    NotJoined = 0
    Joined = 1
    GiveUp = 2
    Win = 3
End Enum

Public Class Player
    Public id As UInt16
    Public Title As String = ""
    Public Name As String = ""
    Public Status As PlayerStatus = PlayerStatus.NotJoined
    Public Cards As List(Of Card) = New List(Of Card)()

    Public lbDescription As Label
    Public pbImage As PictureBox '-|- Next version
    Public Function GetTitle() As String
        Return Title & vbTab & Name
    End Function
    Public Sub New(ByRef sender As Object, ByVal _id As UInt16, ByVal _title As String, ByVal _name As String)
        id = _id
        Title = _title
        Name = _name
        lbDescription = New Label
        lbDescription.Name = "Player" & id
        lbDescription.Text = GetTitle()
        lbDescription.Size = New Size(70, 20)
        lbDescription.TextAlign = ContentAlignment.MiddleRight
        lbDescription.BackColor = Color.Yellow
        lbDescription.Location = New Point(40, 10 + id * 40)

        sender.Controls.Add(Me.lbDescription)
        'sender.Controls.Add(Me.pbImage)

    End Sub
    Public Sub Display(ByRef form As Form)

        'Dim FileName As String = "../../images/cards/" & id & ".png"
        'pbImage = New PictureBox

        'pbImage.Name = "pb" & id
        'pbImage.Image = Image.FromFile(FileName)
        'pbImage.Size = New Size(70, 100)
        'pbImage.Location = location

    End Sub
    Public Sub DisplayCardsFront(ByRef form As Form)

        DisplayCards(form, 0)

    End Sub
    Public Sub DisplayCardsBack(ByRef form As Form)

        DisplayCards(form, 1)
    End Sub
    Public Sub DisplayCards(ByRef form As Form, ByVal what As UInt16)

        'Dim FileName As String = "../../images/cards/" & id & ".png"
        'pbImage = New PictureBox
        Dim card As Card = New Card
        Dim location As Point = New Point()
        Dim CardIndex As UInt16 = 0
        For Each iterator In Cards

            card = DirectCast(iterator, Card)
            location.X = id + 10 * CardIndex
            location.Y = id * 40
            CardIndex += 1
            If what = 0 Then
                card.DisplayFront(form, location)
            Else
                card.DisplayBack(form, location)
            End If
        Next
        'pbImage.Name = "pb" & id
        'pbImage.Image = Image.FromFile(FileName)
        'pbImage.Size = New Size(70, 100)
        'pbImage.Location = location

    End Sub
End Class