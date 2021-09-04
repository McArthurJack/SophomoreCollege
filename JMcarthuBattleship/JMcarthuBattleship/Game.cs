using System;
using System.Collections.Generic;
using System.Text;

namespace JMcarthuBattleship
{
    class Game
    {
        private Random rnd = new Random();
        
        public Game()
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.FillBoard();

            List<Ship> Ships = new List<Ship>();
            Ships.Add(CreateShip(gameBoard, 2));
            Ships.Add(CreateShip(gameBoard, 2));
            Ships.Add(CreateShip(gameBoard, 3));
            Ships.Add(CreateShip(gameBoard, 3));
            Ships.Add(CreateShip(gameBoard, 4));
            Ships.Add(CreateShip(gameBoard, 5));

            userInput(gameBoard, Ships);
        }

        private Ship CreateShip(GameBoard gameBoard, int Length)
        {
            int direction = rnd.Next(0, 4);
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
                        bowY = rnd.Next(0 + Length - 1, 10);
                        sternX = bowX;
                        sternY = bowY;
                        bowY = bowY - Length + 1;
                        break;
                    case 2:
                        bowX = rnd.Next(0 + Length - 1, 10);
                        bowY = rnd.Next(0, 10);
                        sternX = bowX;
                        bowX = bowX - Length + 1;
                        sternY = bowY;
                        break;
                    case 3:
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

        private void Attack(GameBoard gameBoard, int x, int y)
        {
            if (gameBoard.GetChar(x,y) == 'S')
            {
                gameBoard.PlaceChar(x, y, 'O');
            }
            else
            {
                gameBoard.PlaceChar(x, y, 'X');
            }
        }

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
                Console.Write("\nEnter the Row Value: ");
                x = int.Parse(Console.ReadLine()) - 1;
                Console.Write("\nEnter the Column Value: ");
                y = int.Parse(Console.ReadLine()) - 1;

                Attack(gameBoard, x, y);

                SunkShip(gameBoard, ships, Hack);

                Console.Clear();
            } while (ships.Count != 0);
            gameBoard.Display();
            Console.WriteLine("\nYou have sunk all the Battle ships!");
        }

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
