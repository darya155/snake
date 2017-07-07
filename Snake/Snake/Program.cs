using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        public static void Func1(int x1)
        {            
            x1 = x1 + 1;
            Console.WriteLine("Выводим x1 = "+ x1);
        }
        public static void Move (Point p, int dx, int dy)
        {
            p.x = p.y + dx;
            p.y = p.y + dy;
        }
        public static void Reset (Point p)
        {
            p = new Point();
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
            Console.WriteLine(p.sym);
        }
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Reset(p1);
            Console.WriteLine("Выводим p1 = " + p1);
            Console.WriteLine("x = "+ p1.x + ", y = " + p1.y + ", sym = " + p1.sym);
        }
    }
}
 