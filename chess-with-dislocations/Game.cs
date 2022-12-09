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
        Pieces[,] piecesArray = new Pieces[23,23];
        Pieces startPiece = piecesArray[x1, y1];
        Pieces endPiece = piecesArray[x2, y2];
        if (startPiece.GetType() == '#')
        {
            return false;
        }
        if (startPiece.IsWhite() != isWhiteTurn)
        {
            return false;
        }

        return true;
    }
}