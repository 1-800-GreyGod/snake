using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 50);
            
            var p = new Point(4,3,'*');
            
            
            //List<Point> pList = new List<Point>();
            

            

            HorizontalLine topline = new HorizontalLine(0,79,0,'+');
            HorizontalLine bottomline = new HorizontalLine(0, 79, 49, '+');
            VerticalLine leftline = new VerticalLine(0, 49, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 49, 79, '+');

            var s = new Snake(p, 4, Direction.RIGHT);
            
            Console.ReadLine();
            s.draw();

        }
        
    }
}
