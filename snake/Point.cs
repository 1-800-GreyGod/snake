using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point ()
        {            
        }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
            draw();
        }
        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void clear()
        {
            sym = ' ';
            draw();
        }
        public void move(int offset, Direction direction)
        {
            if (direction==Direction.LEFT)
            {
                x = x- offset;
            }
            else if (direction==Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction==Direction.UP)
            {
                y = y - offset;
            }
            else if (direction==Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
