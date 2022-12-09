namespace chess_with_dislocations;

public class Board
{
    private Pieces[,] _board = new Pieces[23, 23];

    public Board()
    {
        // add pieces to the board
        for (var i = 0; i < _board.GetLength(1); i++)
        {
            for (var j = 0; j < _board.GetLength(0); j++)
            {
                if (j is < 8 or >= 16 || i is < 8 or  >= 16)
                {
                    _board[i, j] = new OutOfBounds(j, i);
                }

                else if (j == 9)
                {
                    _board[i, j] = new Pawn(j, i, false);
                }
                else if (j == 14)
                {
                    _board[i, j] = new Pawn(j, i, true);
                }

                else if (i is 8 or 15 && j == 8)
                {
                    _board[i, j] = new Rook(j, i, true);
                }
                else if (i is 8 or 15 && j == 15)
                {
                    _board[i, j] = new Rook(j, i, false);
                }
                else if (i is 9 or 14 && j == 8)
                {
                    _board[i, j] = new Knight(j, i, true);
                }
                else if (i is 9 or 14 && j == 15)
                {
                    _board[i, j] = new Knight(j, i, false);
                }
                else if (i is 10 or 13 && j == 8)
                {
                    _board[i, j] = new Bishop(j, i, true);
                }
                else if (i is 10 or 13 && j == 15)
                {
                    _board[i, j] = new Bishop(j, i, false);
                }
                else if (i == 11 && j == 8)
                {
                    _board[i, j] = new Queen(j, i, true);
                }
                else if (i == 11 && j == 15)
                {
                    _board[i, j] = new Queen(j, i, false);
                }
                else if (i == 12 && j == 8)
                {
                    _board[i, j] = new King(j, i, true);
                }
                else if (i == 12 && j == 15)
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