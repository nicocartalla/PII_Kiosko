using System;

namespace Ejercicio4
{
    class Program
    {
         static void Main(string[] args)
        {
            ReadFile reader = new ReadFile("../../assets/board.txt");
            GameBoard board = new GameBoard(reader.ReadTextFile());

            PrintBoard.Print(board);
        }
    }
}
