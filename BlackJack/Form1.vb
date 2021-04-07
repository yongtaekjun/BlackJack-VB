


'Dim intPlayerCard1 As UInt16 ' Global Member Variable

Public Class Form1
    Dim intPlayerCard1 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard2 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard3 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard4 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard5 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard6 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard7 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard8 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard9 As UInt16 = 0 ' Class Member Variable
    Dim intPlayerCard10 As UInt16 = 0 ' Class Member Variable

    Public intCardsOnHand(9) As Int16 ' 0 ~ 4 : Dealer Cards, 5 ~ 9 : Players Cards
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub DistributeCards()
        For i As UInt16 = 0 To 9 Step 1
            intCardsOnHand(i) = -1
        Next
        Dim IndexOfCard As UInt16 = 0
        While IndexOfCard < 10

            Dim NewRandomNumner As UInt16 = GetRandom(0, 51)
            Dim IsDuplicated As Boolean = False
            For Each SelectedNumber In intCardsOnHand
                If SelectedNumber = NewRandomNumner Then
                    IsDuplicated = True
                    Exit For
                End If
            Next

            If IsDuplicated = False Then
                intCardsOnHand(IndexOfCard) = NewRandomNumner
                IndexOfCard += 1
            End If
        End While
    End Sub
    Private Sub DisplayCards()
        lbDealerCard1.Text = intCardsOnHand(0)
        lbDealerCard2.Text = intCardsOnHand(1)
        lbDealerCard3.Text = intCardsOnHand(2)
        lbDealerCard4.Text = intCardsOnHand(3)
        lbDealerCard5.Text = intCardsOnHand(4)

        lbPlayerCard1.Text = intCardsOnHand(5)
        lbPlayerCard2.Text = intCardsOnHand(6)
        lbPlayerCard3.Text = intCardsOnHand(7)
        lbPlayerCard4.Text = intCardsOnHand(8)
        lbPlayerCard5.Text = intCardsOnHand(9)

    End Sub
    Private Sub btnShowCards_Click(sender As Object, e As EventArgs) Handles btnShowCards.Click

        DistributeCards()
        DisplayCards()

    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
End Class
