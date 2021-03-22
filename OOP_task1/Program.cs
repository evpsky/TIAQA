using System;

namespace OOP_task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Задание №1
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Program calculates areas of a square and a circle");

            {
                CalculateArea areaCalculator = new CalculateArea();
                CalculateArea.AreaOfACircle();
                CalculateArea.AreaOfASquare();
            }
        }
       
    }
}