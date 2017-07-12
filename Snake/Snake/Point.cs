using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point() //конструктор
        {
            //Console.WriteLine("создается новая точка");
        }

        public Point(int _x, int _y, char _sym)//конструктор
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)//конструктор задает точки с помощью другой точки
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)//сдвигает точку на расстояние offset по направлению direction
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            if (direction == Direction.UP)
            {
                y = y + offset;
            }
            if (direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
