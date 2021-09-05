using System;
using System.Collections.Generic;
using System.Text;

namespace JMcarthuBattleship
{
    class Game
    {
        //Random variable used throughout the program
        private Random rnd = new Random();
        
        //Constructor that creates a gameboard then fills the board with ships
        //Then asks for the users input for hack mode or not
        //Finally will run the game of battleship then ask the user if they want to play again
        public Game()
        {
            char Replay = 'Y';
            GameBoard gameBoard = new GameBoard();

            do
            {
                gameBoard.FillBoard();

                List<Ship> Ships = new List<Ship>();
                Ships.Add(CreateShip(gameBoard, 2));
                Ships.Add(CreateShip(gameBoard, 2));
                Ships.Add(CreateShip(gameBoard, 3));
                Ships.Add(CreateShip(gameBoard, 3));
                Ships.Add(CreateShip(gameBoard, 4));
                Ships.Add(CreateShip(gameBoard, 5));

                userInput(gameBoard, Ships);

                Console.WriteLine("Do you want to play again? (Y or N)");
                Replay = Console.ReadKey().KeyChar;
                Console.Clear();
            } while (Replay != 'N');
        }

        //Creates a battleship that is placed on the board
        //Runs methods to make sure that the ship is placed within the board and does not overlap with other ships
        private Ship CreateShip(GameBoard gameBoard, int Length)
        {
            int direction = rnd.Next(0, 2);
            int bowX = 0, bowY = 0, sternX = 0, sternY = 0;

            do
            {
                switch (direction)
                {
                    case 0:
                        bowX = rnd.Next(0, 10 - Length + 1);
                        bowY = rnd.Next(0, 10);
                        sternX = bowX + Length - 1;
                        sternY = bowY;
                        break;
                    case 1:
                        bowX = rnd.Next(0, 10);
                        bowY = rnd.Next(0, 10 - Length + 1);
                        sternX = bowX;
                        sternY = bowY + Length - 1;
                        break;
                };
            } while (gameBoard.CheckShip(bowX, bowY, sternX, sternY) == true);

            Ship ship = new Ship(Length, bowX, bowY, sternX, sternY);
            PlaceShip(gameBoard, ship, direction);

            return ship;
        }

        //Places the ship onto the board using S characters
        private void PlaceShip(GameBoard gameBoard, Ship ship, int direction)
        {
            if (direction % 2 == 0)
            {
                for (int i = ship.getBowX(); i <= ship.getSternX(); i++)
                {
                    gameBoard.PlaceChar(i, ship.getBowY(), 'S');
                }
            }
            else
            {
                for (int i = ship.getBowY(); i <= ship.getSternY(); i++)
                {
                    gameBoard.PlaceChar(ship.getBowX(), i, 'S');
                }
            }
        }

        //Firstly will ask the user if they want to enter hack mode and then displays the correct board
        //Proceeds to display the board and ask the user for their column letter and row number then will refresh the console and display the new board
        //After each attack with check if any ship has been sunk and will display the correct message if so
        //Finally tells the user they have won the game once all the battleships have been sunked
        private void userInput(GameBoard gameBoard, List<Ship> ships)
        {
            int x, y;

            Console.Write("Do you want to enter Hack mode? (Enter Y or N): ");
            char Hack = Console.ReadKey().KeyChar;
            Console.Clear();

            do
            {
                if (Hack == 'Y')
                {
                    gameBoard.Display('S');
                }
                else
                {
                    gameBoard.Display();
                }
                Console.Write("\nEnter the Column: ");
                y = Console.ReadLine()[0] - 97;
                Console.Write("\nEnter the Row: ");
                x = int.Parse(Console.ReadLine()) - 1;

                Attack(gameBoard, x, y);

                SunkShip(gameBoard, ships, Hack);

                Console.Clear();
            } while (ships.Count != 0);
            gameBoard.Display();
            Console.WriteLine("\nYou have sunk all the Battle ships!");
        }

        //Will place the correct character for if the attack missed or hit a ship
        private void Attack(GameBoard gameBoard, int x, int y)
        {
            if (gameBoard.GetChar(x, y) == 'S')
            {
                gameBoard.PlaceChar(x, y, 'O');
            }
            else
            {
                gameBoard.PlaceChar(x, y, 'X');
            }
        }

        //Runs a for loop of each ship on the board
        //Checks to see if the ship has all O's over its location on the board and if so will display the correct message depending on the lenght of the ship
        //Removes the ship from the list because it has been sunk and no longer needs to exist within the game
        private void SunkShip(GameBoard gameBoard, List<Ship> ships, char Hack)
        {
            foreach (Ship ship in ships)
            {
                if (gameBoard.CheckShip(ship.getBowX(), ship.getBowY(), ship.getSternX(), ship.getSternY()) == false)
                {
                    Console.Clear();
                    if (Hack == 'Y')
                    {
                        gameBoard.Display('S');
                    }
                    else
                    {
                        gameBoard.Display();
                    }
                    switch (ship.getLength())
                    {
                        case 2:
                            Console.WriteLine("\nYou have sunk a Destroyer!");
                            break;
                        case 3:
                            Console.WriteLine("\nYou have sunk a Submarine!");
                            break;
                        case 4:
                            Console.WriteLine("\nYou have sunk the Battleship!");
                            break;
                        case 5:
                            Console.WriteLine("\nYou have sunk the Carrier!");
                            break;
                    }
                    Console.WriteLine("Press any key to continue");
                    ships.Remove(ship);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
