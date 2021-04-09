


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

        Dim Generator As System.Random = New System.Random()
        Dim nCards As UInt16 = 51

        Dim r0 As UInt16 = 99
        Dim r1 As UInt16 = 99
        Dim r2 As UInt16 = 99
        Dim r3 As UInt16 = 99
        Dim r4 As UInt16 = 99
        Dim r5 As UInt16 = 99
        Dim r6 As UInt16 = 99
        Dim r7 As UInt16 = 99
        Dim r8 As UInt16 = 99
        Dim r9 As UInt16 = 99

        Dim RandomNumber As UInt16 = 0
        Dim IsDuplicatedNumber As Boolean = False
        Dim CountOfCard As UInt16 = 0

        Do While CountOfCard < 10
            RandomNumber = Generator.Next(0, 51)
            Select Case RandomNumber
                Case r0, r1, r2, r3, r4, r5, r6, r7, r8, r9
                    'IsDuplicatedNumber = True
                Case Else
                    Select Case CountOfCard
                        Case 0
                            r0 = RandomNumber
                        Case 1
                            r1 = RandomNumber
                        Case 2
                            r2 = RandomNumber
                        Case 3
                            r3 = RandomNumber
                        Case 4
                            r4 = RandomNumber
                        Case 5
                            r5 = RandomNumber
                        Case 6
                            r6 = RandomNumber
                        Case 7
                            r7 = RandomNumber
                        Case 8
                            r8 = RandomNumber
                        Case 9
                            r9 = RandomNumber
                    End Select
                    CountOfCard += 1
            End Select

        Loop


        tbMessage.Text += r0 & vbCrLf _
            & r1 & vbCrLf _
            & r2 & vbCrLf _
            & r3 & vbCrLf _
            & r4 & vbCrLf _
            & r5 & vbCrLf _
            & r6 & vbCrLf _
            & r7 & vbCrLf _
            & r8 & vbCrLf _
            & r9 & vbCrLf

    End Sub
End Class
