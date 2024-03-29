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
        Console.WriteLine(x1 + "x1 " + y1 + "y1 " + x2 + "x2 " + y2 + "y2 ");
        Pieces[,] piecesArray = board.Content();
        Pieces startPiece = piecesArray[x1, y1];
        Pieces endPiece = piecesArray[x2, y2];
        if (startPiece.GetType() == '#' || endPiece.GetType() == '#')
        {
            Console.WriteLine("out of bounds");
            return false;
        }
        if (startPiece.IsWhite() != isWhiteTurn)
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
                if (y2 == 10 && x1 == x2 && y1 == 8 && startPiece.IsWhite())
                {
                    Console.WriteLine("first move");
                    return true;
                }
                if (y2 == y1 + 1 && x1 == x2)
                {
                    Console.WriteLine("normal move");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("black");
                if (y2 == 11 && x1 == x2 && y1 == 13 && !startPiece.IsWhite())
                {
                    Console.WriteLine("first move");
                    return true;
                }
                if (y2 == y1 - 1 && x1 == x2)
                {
                    Console.WriteLine("normal move");
                    return true;
                }
            }
        }
        if (startPiece.GetType() == 'r')
        {
            Console.WriteLine("rook selected");
            return x1 == x2 || y1 == y2;
        }
        if (startPiece.GetType() == 'k')
        {
            Console.WriteLine("knight selected");
            if (x1 != x2 + 1 && x1 != x2 - 1) return false;
            if (y1 == y2 + 2 || y1 == y2 - 2)
            {
                return true;
            }
        }
        else if (startPiece.GetType() == 'b')
        {
            Console.WriteLine("bishop selected");
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                return true;
            }
        }
        else if (startPiece.GetType() == 'q')
        {
            Console.WriteLine("queen selected");
            if (x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                return true;
            }
        }
        else if (startPiece.GetType() == 'K')
        {
            Console.WriteLine("king selected");
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