namespace chess_with_dislocations;

 // See https://aka.ms/new-console-template for more information
class program
{
 static void Main()
 {
  ClIinterface CLI = new ClIinterface();
  Board board = new Board();
  ClIinterface.DisplayBoard(board.Content());
 }
}