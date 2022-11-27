namespace chess_with_dislocations;

public class ClIinterface
{
    public static void DisplayBoard(Pieces[,] board)
    {
        for (var i = 0; i < board.GetLength(1); i++)
        {
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            for (var j = 0; j < board.GetLength(0); j++)
            {
                Console.Write('|');
                if (!board[i,j].IsEmpty())
                {
                    Console.Write(board[i, j].GetType());
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write('|');
            Console.WriteLine();
        }
    }
}