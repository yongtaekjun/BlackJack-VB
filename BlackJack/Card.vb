Public Class Card
    Public id As UInt16 = 0 '0 ~ 51
    Public type As UInt16 = 0 '0 Spade, 1 = Diamond, 2=Hearts, 3 = Clover
    Public IsControlLoaded As Boolean = False 'Because of Dynamic Loading

    Public lbDescription As Label
    Public pbImage As PictureBox '-|- Next version
    Public Function getTitle() As String
        Dim TypeName As String = ""
        Select Case (type)
            Case 0
                TypeName = "Spade   "
            Case 1
                TypeName = "Diamond "
            Case 2
                TypeName = "Hearts  "
            Case 3
                TypeName = "Clover  "
        End Select

        Select Case (id Mod 13)
            Case 0
                Return TypeName & vbTab & "Ace"
            Case 10
                Return TypeName & vbTab & "Jack"
            Case 11
                Return TypeName & vbTab & "Queen"
            Case 12
                Return TypeName & vbTab & "King"
            Case Else
                Return TypeName & vbTab & ((id Mod 13) + 1)
        End Select
    End Function
    Public Sub DisplayFront(ByRef form As Form, ByVal location As Point)
        If Not IsControlLoaded Then
            LoadControl(form, location)
        End If
        lbDescription.Visible = True
        pbImage.Visible = True

    End Sub
    Public Sub DisplayBack(ByRef form As Form, ByVal location As Point)
        Static BackImageFile = "../../../images/cards/purple_back.png"
        If Not IsControlLoaded Then
            LoadControl(form, location)
        End If
        lbDescription.Visible = False

        pbImage.Image = BackImageFile
        pbImage.Visible = True

    End Sub
    Public Sub DisplayOff(ByRef form As Form, ByVal location As Point)
        If Not IsControlLoaded Then
            LoadControl(form, location)
        End If
        lbDescription.Visible = False
        pbImage.Visible = False

    End Sub
    Private Sub LoadControl(ByRef form As Form, ByVal location As Point)
        lbDescription = New Label
        lbDescription.Name = getTitle()
        lbDescription.Size = New Size(70, 20)
        lbDescription.TextAlign = ContentAlignment.MiddleRight
        lbDescription.BackColor = Color.Yellow
        lbDescription.Location = location


        Me.pbImage = New PictureBox
        Dim FileName As String = "../../../images/cards/" & id & ".png"
        pbImage = New PictureBox

        pbImage.Name = "pb" & id
        pbImage.Image = Image.FromFile(FileName)
        pbImage.Size = New Size(70, 100)
        pbImage.Location = location


        form.Controls.Add(Me.lbDescription)
        form.Controls.Add(Me.pbImage)

    End Sub
End Class
