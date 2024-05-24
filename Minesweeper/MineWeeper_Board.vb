Public Class MineWeeper_Board
    Private bombTiles(81) As Boolean
    Private cells(8, 8) As Boolean
    Private cellTiles(8, 8) As Tile
    Private Sub MineWeeper_Board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                cells(i, j) = False
            Next
        Next
        For i As Integer = 0 To 8
            Dim rand As New Random
            Dim randomNumX As Integer = rand.Next(0, 8)
            Dim randomNumY As Integer = rand.Next(0, 8)
            If cells(randomNumX, randomNumY) = True Then
                i -= 1
            Else
                cells(randomNumX, randomNumY) = True
            End If
        Next
        Populate_MultiDimensionalArray()
    End Sub
    ''' <summary>
    ''' Populates the 2d array with the tile peices
    ''' </summary>
    Private Sub Populate_MultiDimensionalArray()
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                Dim tilepiece As New Tile((i * j), pnlMineBoard.Width, New Point((pnlMineBoard.Width / 9) * (i - 1), (pnlMineBoard.Height / 9) * (j - 1)), cells(i - 1, j - 1))
                cellTiles(i - 1, j - 1) = tilepiece
            Next
        Next
        DetectBombs()

    End Sub

    Private Sub DetectBombs()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If cellTiles(i, j).IsBomb = False Then
                    Dim totalBombs As Integer = 0
                    Dim adjacentItems As List(Of Tile) = GetAdjacentItems8x8(cellTiles, i, j)
                    For c As Integer = 0 To adjacentItems.Count - 1
                        If adjacentItems(c).IsBomb = True Then
                            totalBombs += 1
                        End If
                    Next
                    cellTiles(i, j).Bombs = totalBombs
                End If
                pnlMineBoard.Controls.Add(cellTiles(i, j))

            Next
        Next
    End Sub
    Function GetAdjacentItems8x8(arr(,) As Tile, row As Integer, col As Integer) As List(Of Tile)
        Dim neighbors As New List(Of Tile)
        Dim numRows As Integer = 8
        Dim numCols As Integer = 8

        For i As Integer = row - 1 To row + 1
            For j As Integer = col - 1 To col + 1
                If i >= 0 AndAlso i < numRows AndAlso j >= 0 AndAlso j < numCols AndAlso Not (i = row AndAlso j = col) Then
                    neighbors.Add(arr(i, j))
                End If
            Next
        Next

        Return neighbors
    End Function


End Class