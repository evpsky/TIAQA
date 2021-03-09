using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task1
{
    // ** Копия класса, сюда смотреть не надо, он есть в файле Program.cs
    // Задание №2 - Класс для расчета влезет ли квадрат в круг или нет)
    class Square
    {
        private double side; //Сторона квадрата
        private double diametr; //Диаметр окружности

        public void GetShape()
        {
            Console.WriteLine("\nДавайте теперь определим поместится ли квадрат в круг и наоборот :) ");
            const double P = 3.14;
            Console.Write("\nВведите площадь круга: ");
            double S1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Введите площадь квадрата: ");
            double S2 = Convert.ToDouble(Console.ReadLine());

            double Diametr = Math.Sqrt(S1 / P) * 2;
            double Side = Math.Sqrt(S2);

            if (Diametr <= Side)
            {
                Console.WriteLine();
                Console.WriteLine("a) Уместится");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("a) Не уместится");
            }

            double Diagonal = Side * Math.Sqrt(2);

            if (Diagonal <= Diametr)
                Console.WriteLine("б) Уместится");

            else
                Console.WriteLine("б) Не уместится");
        }
        double Side
        {
            get { return side; }
            set { side = value; }
        }

        double Diameter
        {
            get { return diametr; }
            set { diametr = value; }
        }

    }
}
