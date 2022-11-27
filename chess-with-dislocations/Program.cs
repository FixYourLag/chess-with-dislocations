namespace chess_with_dislocations;

internal static class Program
{
 private static void Main()
 {
  var board = new Board();
  ClIinterface.DisplayBoard(board.Content());
 }
}