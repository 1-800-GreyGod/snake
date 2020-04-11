using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            var p = new Point(4, 3, '*');      

            HorizontalLine topline = new HorizontalLine(0, 79, 0, '+');
            HorizontalLine bottomline = new HorizontalLine(0, 79, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 79, '+');

            var s = new Snake(p, 4, Direction.RIGHT);
            s.draw();

            Food foodcreator = new Food(80, 25, '$');
            Point food = foodcreator.foodcreate();
            food.draw();
            while (true)
            {
                if (s.eat(food))
                {
                    food = foodcreator.foodcreate();
                    food.draw();
                    s.draw();
                }
                else
                    s.move();

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    s.controller(key.Key);
                }
                Thread.Sleep(100);
                s.move();
            }

            
        }
        
    }
}
