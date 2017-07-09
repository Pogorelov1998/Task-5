using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS18
{
    class dot
    {
        private int x, y;
        private double dist_to_zero;

        public dot(int xi, int yi)
        {
            x = xi;
            y = yi;
            dist_to_zero = Math.Sqrt(x * x + y * y);
            Console.Write("Расстояние до центра координат: {0}\n", Math.Round(dist_to_zero, 2));
        }

        public void on_axes()
        {
            if(x == 0)
                Console.Write("Точка лежит на оси X\n");
            if(y == 0)
                Console.Write("Точка лежит на оси Y\n");
            if(x != 0 || y != 0)
                Console.Write("Точка не лежит на осях\n");
        }

        public void move(int dx, int dy)
        {
            x += dx;
            y += dy;
            Console.Write("Текущие координаты точк: X - {0}, Y - {1}\n", x, y);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты X и Y точки:\n");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            dot d = new dot(x, y);
            d.on_axes();
            Console.Write("Введите на сколько должна сместиться точка:\n");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            d.move(x, y);
            Console.ReadKey();
        }
    }
}
