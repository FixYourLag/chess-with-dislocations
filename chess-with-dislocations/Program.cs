﻿namespace chess_with_dislocations;

internal static class Program
{
    private static void Main()
    {
        Game game = new Game();
        ClIinterface.DisplayBoard(game.getBoard());
        bool gameIsOver = false;
        while (!gameIsOver)
        {
            Console.WriteLine("Enter your move:");
            int row1 = int.Parse(Console.ReadLine());
            int col1 = int.Parse(Console.ReadLine());
            int row2 = int.Parse(Console.ReadLine());
            int col2 = int.Parse(Console.ReadLine());
            Console.Write("moving ");
            if (game.getBoard()[row1, col1].IsWhite())
            {
                Console.Write("white ");
            }
            else
            {
                Console.Write("black ");
            }
            Console.WriteLine(game.getBoard()[row1,col1].GetType() + " from " + row1 + ", " + col1 + " to " + row2 + ", " + col2);
            game.MakeMove(col1, row1, col2, row2);
            ClIinterface.DisplayBoard(game.getBoard());
        }
    }
}