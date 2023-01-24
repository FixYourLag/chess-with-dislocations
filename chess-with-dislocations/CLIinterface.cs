namespace chess_with_dislocations;

public class ClIinterface
{
    public static void DisplayBoard(Pieces[,] board)
    {
        Console.ForegroundColor = ConsoleColor.White;
        for (var i = 0; i < board.GetLength(1); i++)
        {
            Console.WriteLine("+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+");
            int num = 21 - i;
            if (num < 10){Console.Write("| "+ num +" ");}
            else {Console.Write("| "+ num);}
            for (var j = 0; j < board.GetLength(0); j++)
            {
                Console.Write('|');
                if (!board[j,num].IsEmpty())
                {
                    if (board[j,num].IsWhite() && board[j,num].GetType() != '#')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (board[j,num].GetType() != '#')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(" " + board[j,num].GetType() + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write("   ");
                }
            }
            Console.Write('|');
            Console.WriteLine();
        }
        Console.WriteLine("+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+");
        Console.WriteLine("| ~ | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10| 11| 12| 13| 14| 15| 16| 17| 18| 19| 20| 21|");
        Console.WriteLine("+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+");
    }
}