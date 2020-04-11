using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Food
    {
        int consoleWidth;
        int consoleHeight;
        char sym;
        Random rnd = new Random();
        public Food (int consoleWidth, int consoleHeight, char sym)
        {
            this.consoleWidth = consoleWidth;
            this.consoleHeight = consoleHeight;
            this.sym = sym;
        }

        public Point foodcreate()
        {
            int x = rnd.Next(3, consoleWidth - 10);
            int y = rnd.Next(3, consoleHeight - 10);
            return new Point(x, y, sym);
        }
    }
}
