namespace chess_with_dislocations;

public class Game
{
    public Game()
    {
        //
    }
    bool isWhiteTurn = true;
    Board board = new Board();
    
    public Pieces[,] getBoard()
    {
        return board.Content();
    }
    public bool isMoveLegal(int x1, int y1, int x2, int y2)
    {
        Pieces[,] piecesArray = board.Content();
        Pieces startPiece = piecesArray[x1, y1];
        Pieces endPiece = piecesArray[x2, y2];
        if (startPiece.GetType() == '#' || endPiece.GetType() == '#')
        {
            return false;
        }
        if (startPiece.IsWhite() != isWhiteTurn || endPiece.IsWhite() == isWhiteTurn)
        {
            return false;
        }
        if (y1 == y2 && x1 == x2)
        {
            return false;
        }
        if (startPiece.GetType() == 'p')
        {
            if (startPiece.IsWhite())
            {
                if (y1 == 1)
                {
                    if (y2 == 3 && x1 == x2)
                    {
                        return true;
                    }
                }
                if (y2 == y1 + 1 && x1 == x2)
                {
                    return true;
                }
                if (y2 == y1 + 1 && (x2 == x1 + 1 || x2 == x1 - 1))
                {
                    if (endPiece.IsWhite() == false)
                    {
                        return true;
                    }
                    return false;
                }
            }
            else
            {
                if (y1 == 6)
                {
                    if (y2 == 4 && x1 == x2)
                    {
                        return true;
                    }
                }
                if (y2 == y1 - 1 && x1 == x2)
                {
                    return true;
                }
                if (y2 == y1 - 1 && (x2 == x1 + 1 || x2 == x1 - 1))
                {
                    if (endPiece.IsWhite() == true)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
        else if (startPiece.GetType() == 'r')
        {
            if (x1 == x2 || y1 == y2)
            {
                return true;
            }
            return false;
        }
        else if (startPiece.GetType() == 'k')
        {
            if (x1 == x2 + 1 || x1 == x2 - 1)
            {
                if (y1 == y2 + 2 || y1 == y2 - 2)
                {
                    return true;
                }
            }
        }
        else if (startPiece.GetType() == 'b')
        {
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                return true;
            }
        }
        else if (startPiece.GetType() == 'q')
        {
            if (x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                return true;
            }
        }
        else if (startPiece.GetType() == 'K')
        {
            if ((Math.Abs(y1 - y2) == 1 && Math.Abs(x1 - x2) <= 1) ||
                (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) <= 1))
            {
                return true;
            }

            return false;
        }

        return false;
    }
}