using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task1.Task2
{
    public class CheckFigureShapes
    {
        private double squareArea; //Сторона квадрата
        private double circleRadius; //Диаметр окружности

        public double Area { get; set; }
        public double Radius { get; set; }

        public CheckFigureShapes(double radius, double area)
        {
            Radius = radius;
            Area = area;
        }


        public static void GetShape()
        {
            const double PI = 3.14;
            Console.Write("\nEnter circle Area is: {0}", Radius);
            double S1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Enter square Area: ");
            double S2 = Convert.ToDouble(Console.ReadLine());

            double Diametr = Math.Sqrt(S1 / PI) * 2;
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
    }
}

