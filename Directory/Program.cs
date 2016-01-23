using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    // клас точка
    class Point
    {
        // описание класса
        public int x;
        public int y;
        public Point()
        {
            x = 10;
            y = 10;
        }  
        public Point(int x)
        {
            this.x = 100;
            y = x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // экземпляр класса точка
            Point p = new Point(25);
            Console.WriteLine(p.x + " " + p.y);
        }
    }
}
