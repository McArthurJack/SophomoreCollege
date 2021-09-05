using System;
using System.Collections.Generic;
using System.Text;

namespace JMcarthuBattleship
{
    class GameBoard
    {
        //Board used for battleship
        char[,] board = new char[10, 10];

        //Puts a space character as the char for each spot on the board
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

        //Places a parameter character into a place on the board
        public void PlaceChar(int x, int y, char Letter)
        {
            board[x, y] = Letter;
        }

        //Returns the character at a specific spot on the board
        public char GetChar(int x, int y)
        {
            return board[x, y];
        }

        //Displays the board without hacks
        //Writes the letters in the top row and then for each row will write a column number and evenly space every spot
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

        //A overload method of the Display method that when called displays the ships instead of hiding them
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

        //Creates a horizontal bar to seperate each column for the display method
        private void HorizontalBar()
        {
            Console.Write("   -");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("----");
            }
            Console.WriteLine();
        }

        //Writes the columns in alphabetical order above the rest of the display method
        private void Columns()
        {
            Console.Write("   ");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write($"  {(char)(i+97)} ");
            }
            Console.WriteLine();
        }

        //Checks if the ship has any parts left standing
        //Is used to check if a ship is sunk and if I can place another ship in the spaces upon creation of a ship
        public bool CheckShip(int bowX, int bowY, int sternX, int sternY)
        {
            bool answer = false;

            if (bowY == sternY)
            {
                for (int i = bowX; i <= sternX; i++)
                {
                    if (board[i, bowY] == 'S')
                    {
                        answer = true;
                    }
                }
            }
            else
            {
                for (int j = bowY; j <= sternY; j++)
                {
                    if (board[bowX, j] == 'S')
                    {
                        answer = true;
                    }
                }
            }

            return answer;
        }
    }
}
