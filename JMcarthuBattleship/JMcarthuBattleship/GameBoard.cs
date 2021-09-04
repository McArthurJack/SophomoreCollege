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

        public void PlaceChar(int x, int y, char Letter)
        {
            board[x, y] = Letter;
        }

        public char GetChar(int x, int y)
        {
            return board[x, y];
        }

        public bool CheckShip(int bowX, int bowY, int sternX, int sternY)
        {
            bool answer = false;

            for (int i = bowX; i <= sternX; i++)
            {
                if (board[i, bowY] == 'S')
                {
                    answer = true;
                }
            }
            for (int j = bowY; j <= sternY; j++)
            {
                if (board[bowX, j] == 'S')
                {
                    answer = true;
                }
            }

            return answer;
        }

        public void Display()
        {
            Columns();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                HorizontalBar();
                if (i == 9)
                {
                    Console.Write($"{i + 1} |");
                }
                else
                {
                    Console.Write($"{i + 1}  |");
                }
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
            Columns();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                HorizontalBar();
                if (i == 9)
                {
                    Console.Write($"{i + 1} |");
                }
                else
                {
                    Console.Write($"{i + 1}  |");
                }
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
            Console.Write("   -");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("----");
            }
            Console.WriteLine();
        }

        private void Columns()
        {
            Console.Write("   ");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write($"  {(char)(i+97)} ");
            }
            Console.WriteLine();
        }

        public bool ClearBoard()
        {
            bool Clear = true;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'S')
                    {
                        Clear = false;
                    }
                }
            }

            return Clear;
        }
    }
}
