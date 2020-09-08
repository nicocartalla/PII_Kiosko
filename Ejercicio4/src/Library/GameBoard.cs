using System;
using System.Text;

namespace Ejercicio4
{
    public class GameBoard
    {
        private int boardWidth;
        private int boardHeight;
        private bool[,] initialGameBoard;
        private bool[,] actualGameBoard;

    public GameBoard(bool[,] initalboard) 
        {
            if(initalboard.GetLength(0) > 0 & initalboard.GetLength(1) > 0)
            {
                this.initialGameBoard = initalboard;
                this.actualGameBoard = initalboard;
                this.boardWidth = initalboard.GetLength(0);
                this.boardHeight = initalboard.GetLength(1);
            }
            
        }
        public void UpdateBoard() 
        {
            actualGameBoard = Logic.NewGeneration(this.boardWidth, this.boardHeight, this.actualGameBoard);
        }


        public string GetTextToPrint()
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<this.boardHeight;y++)
            {
                for (int x = 0; x<this.boardWidth; x++)
                {
                    if(this.actualGameBoard[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            return s.ToString();
        }

    }   
        
    }
