using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Snake:Figure
    {   

        public Snake(Point tail, int length, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.move(i, direction);
                pList.Add(p);
            }
        }
    }
}
