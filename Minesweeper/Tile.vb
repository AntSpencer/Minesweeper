Public Class Tile
    Inherits Button
    Private _isBomb As Boolean = False
    Private _hidden As Boolean = True
    Private _flagged As Boolean = False
    Private _bombs As Integer
    Private _id As Integer

    Public Sub New(identificationNumber As Integer, pnlSize As Integer, point As Point, bomb As Boolean)
        Bombs = 0
        Id = identificationNumber
        IsBomb = bomb
        If IsBomb = True Then
            Me.BackColor = Color.Black
        End If
        Me.Width = pnlSize / 9
        Me.Height = pnlSize / 9
        Me.Location = point


    End Sub

    Public Property IsBomb As Boolean
        Get
            Return _isBomb
        End Get
        Set(value As Boolean)
            _isBomb = value
        End Set
    End Property

    Public Property Hidden As Boolean
        Get
            Return _hidden
        End Get
        Set(value As Boolean)
            _hidden = value
        End Set
    End Property

    Public Property Flagged As Boolean
        Get
            Return _flagged
        End Get
        Set(value As Boolean)
            _flagged = value
        End Set
    End Property

    Public Property Bombs As Integer
        Get
            Return _bombs
        End Get
        Set(value As Integer)
            _bombs = value
            If IsBomb = True Then
                Me.Text = "BOMB"
                Me.BackColor = Color.Tomato

            End If
            Select Case value
                Case 0
                    Me.BackColor = Color.White
                Case 1
                    Me.BackColor = Color.Aqua
                Case 2
                    Me.BackColor = Color.Green
                Case 3
                    Me.BackColor = Color.Yellow
                Case Else
                    Me.BackColor = Color.DarkRed
            End Select
            Me.Text = $"{value.ToString()}"
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private Sub OnTileClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If Me.IsBomb Then
            MsgBox("Read this and weep, for thou has steppethed on an anti-personal mine and shant make it back alive!")
            MineWeeper_Board.Close()
        ElseIf Me.Flagged = False AndAlso e.Button = MouseButtons.Right Then
            Me.Flagged = True
            Me.Text = "!"
            Me.BackColor = Color.Yellow
        ElseIf Me.Flagged = True AndAlso e.Button = MouseButtons.Right Then
            Bombs = Bombs
            Me.Flagged = False
        End If

    End Sub
End Class
