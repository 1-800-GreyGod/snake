using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1,3,'*');
            p1.draw();
            var p2 = new Point(4,5,'#');
            p2.draw();
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            

            HorizontalLine hline = new HorizontalLine(5,10,8,'+');
            hline.draw();
            Console.ReadLine();
            VerticalLine vline = new VerticalLine(8, 13, 10, '+');
            vline.draw();
        }
        
    }
}
