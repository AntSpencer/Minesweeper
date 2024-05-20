Public Class Tile
    Private _bomb As Boolean = False
    Private _hidden As Boolean = True
    Private _flagged As Boolean = False
    Private _bombs As Integer
    Shared currentCount As 
    Public Sub New(totalBombs As Integer)
        Bomb = totalBombs
        If Bomb = 0 Then
            Hidden = False
        End If
    End Sub

    Public Property Bomb As Boolean
        Get
            Return _bomb
        End Get
        Set(value As Boolean)
            _bomb = value
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

    Public Property Bombs As Integer
        Get
            Return _bombs
        End Get
        Set(value As Integer)
            _bombs = value
        End Set
    End Property
End Class
