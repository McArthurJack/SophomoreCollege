using System;
using System.Collections.Generic;
using System.Text;

namespace JMcarthuBattleship
{
    class Ship
    {
        private int length, bowX, bowY, sternX, sternY;
        public Ship(int Length, int BowX, int BowY, int SternX, int SternY)
        {
            length = Length;
            bowX = BowX;
            bowY = BowY;
            sternX = SternX;
            sternY = SternY;
        }

        public int getBowX()
        {
            return bowX;
        }

        public int getBowY()
        {
            return bowY;
        }

        public int getSternX()
        {
            return sternX;
        }

        public int getSternY()
        {
            return sternY;
        }

        public int getLength()
        {
            return length;
        }
    }
}
