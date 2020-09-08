using System;
using System.IO;
using System.Threading;

namespace Ejercicio4
{
    public class PrintBoard
    {
        public static void Print(GameBoard board)
        {
            while (true)
            { 
                Console.WriteLine(board.GetTextToPrint());
                board.UpdateBoard();
                Thread.Sleep(300);
            }  
        }    
        
    }
}