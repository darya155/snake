using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инкапсуляция - свойство системы, позв. объединить данные и методы, раб. с ними, в классе.
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.DrawLine();

            VerticalLine vline = new VerticalLine(10, 20, 4, '&');
            vline.DrawLine();


            //создали класс человек и работник
            Emploee e = new Emploee();
            e.age = 42;
            e.pay = 30000;
        }
    }
}
