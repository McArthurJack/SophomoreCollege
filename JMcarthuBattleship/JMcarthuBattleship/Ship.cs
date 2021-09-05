using System;
using System.Collections.Generic;
using System.Text;

namespace JMcarthuBattleship
{
    class Ship
    {
        //Initialized variables defining the ship
        private int length, bowX, bowY, sternX, sternY;

        //Constructor that fills in the parameters of the ship upon creation
        public Ship(int Length, int BowX, int BowY, int SternX, int SternY)
        {
            length = Length;
            bowX = BowX;
            bowY = BowY;
            sternX = SternX;
            sternY = SternY;
        }

        //Returns the bowX location of the ship
        public int getBowX()
        {
            return bowX;
        }

        //Returns the bowY location of the ship
        public int getBowY()
        {
            return bowY;
        }

        //Returns the sternX location of the ship
        public int getSternX()
        {
            return sternX;
        }

        //Returns the sternY location of the ship
        public int getSternY()
        {
            return sternY;
        }

        //Returns the length of the ship
        public int getLength()
        {
            return length;
        }
    }
}
