namespace chess_with_dislocations;

public class Board
{
    private Pieces[,] board = new Pieces[23, 23];

    public Board()
    {
        for (var i = 0; i < board.GetLength(1); i++)
        {
            for (var j = 0; j < board.GetLength(0); j++)
            {
                if (j is < 8 or >= 16 || i is < 8 or  >= 16)
                {
                    board[i, j] = new OutOfBounds(j, i);
                }

                if (i is >= 8 and < 16 && j == 9)
                {
                    board[i, j] = new Pawn(j, i, false);
                }
                if (i is >= 8 and < 16 && j == 14)
                {
                    board[i, j] = new Pawn(j, i, true);
                }

                if (i is 8 or 15 && j == 8)
                {
                    board[i, j] = new Rook(j, i, true);
                }
                if (i is 8 or 15 && j == 15)
                {
                    board[i, j] = new Rook(j, i, false);
                }
                if (i is 9 or 14 && j == 8)
                {
                    board[i, j] = new Knight(j, i, true);
                }
                if (i is 9 or 14 && j == 15)
                {
                    board[i, j] = new Knight(j, i, false);
                }
                if (i is 10 or 13 && j == 8)
                {
                    board[i, j] = new Bishop(j, i, true);
                }
                if (i is 10 or 13 && j == 15)
                {
                    board[i, j] = new Bishop(j, i, false);
                }
                if (i == 11 && j == 8)
                {
                    board[i, j] = new Queen(j, i, true);
                }
                if (i == 11 && j == 15)
                {
                    board[i, j] = new Queen(j, i, false);
                }
                if (i == 12 && j == 8)
                {
                    board[i, j] = new King(j, i, true);
                }
                if (i == 12 && j == 15)
                {
                    board[i, j] = new King(j, i, false);
                }
            }
        }
    }
}