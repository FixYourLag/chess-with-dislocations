namespace chess_with_dislocations;

public class Game
{
    public Game()
    {
        
    }
    bool isWhiteTurn = true;
    Board board = new Board();
    
    public Pieces[,] getBoard()
    {
        return board.Content();
    }
    public bool isMoveLegal(int x1, int y1, int x2, int y2)
    {
        Console.WriteLine("checking move");
        Pieces[,] piecesArray = board.Content();
        Pieces startPiece = piecesArray[x1, y1];
        Pieces endPiece = piecesArray[x2, y2];
        if (startPiece.GetType() == '#' || endPiece.GetType() == '#')
        {
            Console.WriteLine("out of bounds");
            return false;
        }
        if (startPiece.IsWhite() == isWhiteTurn)
        {
            Console.WriteLine("wrong turn");
            return false;
        }
        if (y1 == y2 && x1 == x2)
        {
            Console.WriteLine("no move");
            return false;
        }
        if (startPiece.GetType() == 'p')
        {
            Console.WriteLine("Pawn selected");
            if (startPiece.IsWhite())
            {
                Console.WriteLine("white");
                if (y1 == 8)
                {
                    if (y2 == 10 && x1 == x2)
                    {
                        return true;
                    }
                }
                if (y2 == y1 + 1 && x1 == x2)
                {
                    Console.WriteLine("normal move");
                    return true;
                }

                if (y2 != y1 + 1 || (x2 != x1 + 1 && x2 != x1 - 1)) return false;
                return endPiece.IsWhite() == false;
            }
            if (y1 == 6)
            {
                if (y2 == 4 && x1 == x2)
                {
                    return true;
                }
            }
            if (y2 == y1 + 1 && x1 == x2)
            {
                return true;
            }

            if (y2 != y1 - 1 || (x2 != x1 + 1 && x2 != x1 - 1)) return false;
            return endPiece.IsWhite() == true;
        }
        if (startPiece.GetType() == 'r')
        {
            return x1 == x2 || y1 == y2;
        }
        if (startPiece.GetType() == 'k')
        {
            if (x1 != x2 + 1 && x1 != x2 - 1) return false;
            if (y1 == y2 + 2 || y1 == y2 - 2)
            {
                return true;
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
            return (Math.Abs(y1 - y2) == 1 && Math.Abs(x1 - x2) <= 1) ||
                   (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) <= 1);
        }

        return false;
    }
    public void MakeMove(int x1, int y1, int x2, int y2)
    {
        Pieces[,] piecesArray = board.Content();
        Pieces startPiece = piecesArray[x1, y1];
        Pieces endPiece = piecesArray[x2, y2];
        if (isMoveLegal(x1, y1, x2, y2))
        {
            piecesArray[x2, y2] = startPiece;
            piecesArray[x1, y1] = new Empty(y1,x1);
            isWhiteTurn = !isWhiteTurn;
        }
        else
        {
            Console.WriteLine("Illegal move");
        }
    }
}