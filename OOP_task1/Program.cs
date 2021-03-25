using OOP_task1.Task2;
using System;

namespace OOP_task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Homework #1
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Program calculates areas of a square and a circle");
            

            Console.ForegroundColor = ConsoleColor.Blue;
            Circle circle = FigureHelper.GetCircle();
            FigureHelper.PrintCircleArea(circle);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Square square = FigureHelper.GetSquare();
            FigureHelper.PrintSquareArea(square);

            ShapesChecker.GetShape(circle, square);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadLine();
        }
    }
}