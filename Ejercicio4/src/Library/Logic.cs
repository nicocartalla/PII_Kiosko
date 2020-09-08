using System;

namespace Ejercicio4
{
    class Logic
    {
    public static bool[,] NewGeneration(int width, int height, bool[,] actualGameBoard)
        {   
            bool[,] result = new bool[width, height];
            bool[,] cloneboard = new bool[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<width && j>=0 && j < height && actualGameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(actualGameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (actualGameBoard[x,y] && aliveNeighbors < 2) 
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false; 
                    }
                    else if (actualGameBoard[x,y] && aliveNeighbors > 3) 
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false; 
                    }
                    else if (!actualGameBoard[x,y] && aliveNeighbors == 3) 
                    {
                        //Celula nace por reproducción 
                        cloneboard[x,y] = true; 
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = actualGameBoard[x,y];
                    }
                }
            }
            actualGameBoard = cloneboard;
            cloneboard = new bool[width, height];
            return actualGameBoard;
        }
    }
}