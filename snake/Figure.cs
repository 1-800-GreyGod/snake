using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Figure
    {
        protected List<Point> pList;

        public void draw()
        {
            foreach (Point p in pList)
            {
                p.draw();
            }
        }
    }
}
