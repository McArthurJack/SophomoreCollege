using System;
using System.Collections.Generic;
using System.Text;

namespace JMcarthuBattleship
{
    class GameBoard
    {
        char[,] board = new char[10, 10];

        public void FillBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        public void PlaceShip(int x, int y)
        {
            board[x, y] = 'S';
        }

        public void Display()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                HorizontalBar();
                Console.Write("|");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j] == 'S')
                    {
                        Console.Write($"   |");
                    }
                    else
                    {
                        Console.Write($" {board[i, j]} |");
                    }
                }
                Console.WriteLine();
            }
            HorizontalBar();
        }
        public void Display(char Hack)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                HorizontalBar();
                Console.Write("|");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($" {board[i, j]} |");
                }
                Console.WriteLine();
            }
            HorizontalBar();
        }

        private void HorizontalBar()
        {
            Console.Write("-");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("----");
            }
            Console.WriteLine();
        }
    }
}
