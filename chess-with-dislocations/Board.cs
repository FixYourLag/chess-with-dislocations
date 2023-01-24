namespace chess_with_dislocations;

public class Board
{
    private Pieces[,] _board = new Pieces[22, 22];

    public Board()
    {
        // add pieces to the board
        for (var i = 0; i < _board.GetLength(1); i++)
        {
            for (var j = 0; j < _board.GetLength(0); j++)
            {
                if (j is < 7 or >= 15 || i is < 7 or >= 15)
                {
                    _board[i, j] = new OutOfBounds(j, i);
                }

                else if (j == 8)
                {
                    _board[i, j] = new Pawn(j, i, true);
                }
                else if (j == 13)
                {
                    _board[i, j] = new Pawn(j, i, false);
                }

                else if (i is 7 or 14 && j == 7)
                {
                    _board[i, j] = new Rook(j, i, true);
                }
                else if (i is 7 or 14 && j == 14)
                {
                    _board[i, j] = new Rook(j, i, false);
                }
                else if (i is 8 or 13 && j == 7)
                {
                    _board[i, j] = new Knight(j, i, true);
                }
                else if (i is 8 or 13 && j == 14)
                {
                    _board[i, j] = new Knight(j, i, false);
                }
                else if (i is 9 or 12 && j == 7)
                {
                    _board[i, j] = new Bishop(j, i, true);
                }
                else if (i is 9 or 12 && j == 14)
                {
                    _board[i, j] = new Bishop(j, i, false);
                }
                else if (i == 11 && j == 7)
                {
                    _board[i, j] = new Queen(j, i, true);
                }
                else if (i == 11 && j == 14)
                {
                    _board[i, j] = new Queen(j, i, false);
                }
                else if (i == 10 && j == 7)
                {
                    _board[i, j] = new King(j, i, true);
                }
                else if (i == 10 && j == 14)
                {
                    _board[i, j] = new King(j, i, false);
                }
                else
                {
                    _board[i, j] = new Empty(j, i);

                }
            }
        }
    }

    public Pieces[,] Content()
    {
        return _board;
    }
}