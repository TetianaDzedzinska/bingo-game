// See https://aka.ms/new-console-template for more information

ConsoleKey key;
do
{
    Console.WriteLine("Please enter Y to start game");
    key = Console.ReadKey(false).Key;
    Console.WriteLine();
} while (key != ConsoleKey.Y);

var bingoBoard = GenerateBingoBoard();


Console.WriteLine("bingo board is : ");

object GenerateBingoBoard()
{
    throw new NotImplementedException();
}


