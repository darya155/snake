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

            //Рассмотрим класс List стандартной библиотеки С#
            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(7);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            //вывести в консоль все элементы
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);//удалить 0-ой элемент

            //список точек
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            //список символов
            List<char> charList = new List<char>();
            charList.Add('.');
            charList.Add('@');
            charList.Add('%');
            charList.Add('#');
            charList.Add('!');


            Point p3 = new Point(9, 4, '%');
            Point p4 = new Point(6, 6, '&');
            Point p5 = new Point(1, 7, '@');
            List<Point> NewPointsList = new List<Point>();
            NewPointsList.Add(p3);
            NewPointsList.Add(p4);
            NewPointsList.Add(p5);

            Console.WriteLine();
        }
    }
}
