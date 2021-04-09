


'Dim intPlayerCard1 As UInt16 ' Global Member Variable

Public Class BlackJack
    Const MaxPlayers As UInt16 = 6
    Const NumberOfCards As UInt16 = 52

    Public IndexOfNextCard As UInt16 = 0 'Which card will be delivered to player

    Public Cards(NumberOfCards - 1) As Card ' 0 ~ 4 : Dealer Cards, 5 ~ 9 : Players Cards
    Public CardList(NumberOfCards - 1) As Card ' 0 ~ 4 : Dealer Cards, 5 ~ 9 : Players Cards
    Public card(NumberOfCards - 1) As Card ' 0 ~ 4 : Dealer Cards, 5 ~ 9 : Players Cards

    Public IsCardsShuffled As Boolean = False ' 31,24,10,5,19,... Random Number List
    Public ShuffledNumbers As ArrayList = New ArrayList() ' 31,24,10,5,19,... Random Number List
    Public Players As ArrayList = New ArrayList() ' Player1 has 34,23,1,45,..

    Public intJoinedPlayers As UInt16 = 1

    Private Sub InitializeCards()
        ' Define card property
        For i As UInt16 = 0 To NumberOfCards - 1 Step 1
            Cards(i) = New Card
            Cards(i).id = i
            Cards(i).type = i \ 13
        Next
        'Dim player As Player = New Player(0, "", "")
        'player.Name = "Player " & Players.Count + 1
        'player.Title = "Client"
        'player.Status = PlayerStatus.Joined
        'Players.Add(player)

    End Sub
    Private Sub MakeDealerToJoin()
        Dim dealer As Player = New Player(Me, 0, "David Miller", "Dealer")
        dealer.Status = PlayerStatus.Joined
        Players.Add(dealer)

    End Sub

    Private Sub DistributeCardsAll()

        Dim TurnCount As UInt16 = 5
        Dim IndexOfShuffledCards As UInt16 = 0
        ' We will give only 5 cards per player from shuffled card list
        For i As UInt16 = 0 To 4 Step 1

            For j As UInt16 = 0 To intJoinedPlayers - 1 Step 1
                'If Players(j).Sta Then
                '    Players(j).Cards.Add(Cards(ShuffledNumbers(IndexOfNextCard)))
                IndexOfShuffledCards += 1
            Next

        Next
    End Sub
    'Private Function get
    'Private Sub DisplayCards()
    '    For Each element In Players
    '        Dim player As Player = DirectCast(element, Player)
    '        'Dim card As Player = DirectCast(iterator, Player)
    '        For Each jj In player.Cards
    '            Dim card As Card = DirectCast(jj, Card)
    '            card.Display(Me, New Point(10, 10))
    '        Next

    '    Next
    'End Sub
    Private Sub btnShowCards_Click(sender As Object, e As EventArgs) Handles btnShowCards.Click

        'DistributeCards()
        'DisplayCards()

    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub btnTakeOneCard_Click(sender As Object, e As EventArgs) Handles btnTakeOneCard.Click

        ' Each player will get the only 1 card per turn from shuffled card list
        If Not IsCardsShuffled Then
            tbMessage.Text += "Shuffle First!" & vbCr
            Return
        End If
        For Each iterator In Players
            Dim player As Player = DirectCast(iterator, Player)
            If player.Status = PlayerStatus.Joined Then
                player.Cards.Add(Cards(ShuffledNumbers(IndexOfNextCard)))
                player.DisplayCardsFront(Me)
                IndexOfNextCard += 1
            End If

        Next
    End Sub

    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click

        'Initialize sequence of cards
        'make 0,1,2,3,4,.....51
        Dim SortedNumbers As ArrayList = New ArrayList() ' 0,1,2,3,4,.... 51 : It is sorted number list
        'SortedNumbers.Clear()
        For i As UInt16 = 0 To NumberOfCards - 1 Step 1
            SortedNumbers.Add(i)
        Next

        'Reset Shuffel cards and sequence to delivery
        ShuffledNumbers.Clear()
        IndexOfNextCard = 0    'Deliver a card from the top for delivering

        'Shuffel cards
        Dim RandomNumber As UInt16
        While SortedNumbers.Count > 0
            RandomNumber = GetRandom(0, SortedNumbers.Count - 1)
            ShuffledNumbers.Add(SortedNumbers(RandomNumber))
            SortedNumbers.RemoveAt(RandomNumber)
        End While

        ' to Verify the Shuffled Cards, will be comment out on release
        ' Display the shuffled Cards on MessageBox
        For Each i In ShuffledNumbers
            tbMessage.Text += Cards(i).getTitle() & vbCrLf
        Next

        IsCardsShuffled = True
    End Sub

    Private Sub btnJoinPlayer_Click(sender As Object, e As EventArgs) Handles btnJoinPlayer.Click
        ' Private Sub btn_join_player_click(sender As Object, e As EventArgs) Handles btnJoinPlayer.Click
        ' Private Sub btn_Join_Player_Click(sender As Object, e As EventArgs) Handles btnJoinPlayer.Click
        ' We need another for to collect plyer information - name, money,..
        If Players.Count < MaxPlayers Then
            Dim player As Player = New Player(Me, Players.Count, "Player " & Players.Count + 1, "Client")
            player.Status = PlayerStatus.Joined
            Players.Add(player)

            'tbMessage.Text += player.GetTitle() & vbCrLf
            'player.Display(Me)
            Return
        End If
        'Make the Join button invalid 
        btnJoinPlayer.Visible = False
    End Sub

    Private Sub BlackJack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeCards() 'initialize card information
        MakeDealerToJoin() 'Make the dealer to join the game
    End Sub

    Private Sub btnDisplayBack_Click(sender As Object, e As EventArgs) Handles btnDisplayBack.Click

        For Each iterator In Players
            Dim player As Player = DirectCast(iterator, Player)
            If player.Status = PlayerStatus.Joined Then
                player.DisplayCardsBack(Me)
            End If

        Next

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim a As UInt16 = 32
        Dim b As UInt16 = 41
        Dim temp As UInt16
        'tbMessage.Text = "A : " & a & " B : " & b & vbCrLf
        temp = a
        a = b '41
        b = temp '32
        tbMessage.Text = "A : " & a & " B : " & b & vbCrLf

    End Sub
End Class
