using OOP_task1.Task2;
using System;

namespace OOP_task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Homework #1
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Program calculates areas of a square and a circle");

            {
                CalculateArea areaCalculator = new CalculateArea();
                Console.ForegroundColor = ConsoleColor.Blue;
                CalculateArea.AreaOfACircle();
                Console.ForegroundColor = ConsoleColor.Yellow;
                CalculateArea.AreaOfASquare();
                CheckFigureShapes.GetShape();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadLine();
        }
    }
}