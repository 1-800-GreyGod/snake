using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Snake:Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.move(i, direction);
                pList.Add(p);
            }
        }

        internal void move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getNextPoint();
            pList.Add(head);

            tail.clear();
            head.draw();
        }

        private Point getNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.move(1, direction);
            return nextPoint;
        }
        public void controller(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }
        internal bool eat(Point food)
        {
            Point head = getNextPoint();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
