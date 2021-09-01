using System;
using System.Collections.Generic;
using System.Text;

namespace JMcarthuBattleship
{
    class Game
    {
        //Random Variable
        private Random rnd = new Random();
        
        //Creates the board and places down the pieces
        //NEED TO MAKE IT SO PIECES ARE NOT PLACED ON TOP OF EACH OTHER
        public Game()
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.FillBoard();

            Ship[] Ships = new Ship[6];
            Ships[0] = CreateShip(gameBoard, 2);
            Ships[1] = CreateShip(gameBoard, 2);
            Ships[2] = CreateShip(gameBoard, 3);
            Ships[3] = CreateShip(gameBoard, 3);
            Ships[4] = CreateShip(gameBoard, 4);
            Ships[5] = CreateShip(gameBoard, 5);

            gameBoard.Display('S');
        }

        private Ship CreateShip(GameBoard gameBoard, int Length)
        {
            int direction = rnd.Next(0, 4);
            int bowX = 0, bowY = 0, sternX = 0, sternY = 0;
            
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
                    sternY = bowY - Length + 1;
                    break;
                case 2:
                    bowX = rnd.Next(0 + Length - 1, 10);
                    bowY = rnd.Next(0, 10);
                    sternX = bowX - Length + 1;
                    sternY = bowY;
                    break;
                case 3:
                    bowX = rnd.Next(0, 10);
                    bowY = rnd.Next(0, 10 - Length + 1);
                    sternX = bowX;
                    sternY = bowY + Length - 1;
                    break;
            };

            Ship ship = new Ship(2, bowX, bowY, sternX, sternY);
            PlaceShip(gameBoard, ship, direction);

            return ship;
        }

        private void PlaceShip(GameBoard gameBoard, Ship ship, int direction)
        {
            switch (direction)
            {
                case 0:
                    for (int i = ship.getBowX(); i <= ship.getSternX(); i++)
                    {
                        gameBoard.PlaceShip(i,ship.getBowY());
                    }
                    break;
                case 1:
                    for (int i = ship.getSternY(); i <= ship.getBowY(); i++)
                    {
                        gameBoard.PlaceShip(ship.getBowX(), i);
                    }
                    break;
                case 2:
                    for (int i = ship.getSternX(); i <= ship.getBowX(); i++)
                    {
                        gameBoard.PlaceShip(i, ship.getBowY());
                    }
                    break;
                case 3:
                    for (int i = ship.getBowY(); i <= ship.getSternY(); i++)
                    {
                        gameBoard.PlaceShip(ship.getBowX(), i);
                    }
                    break;
            };
        }
    }
}
