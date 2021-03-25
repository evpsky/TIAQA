using System;
using OOP_task1.Helpers;


namespace OOP_task1
{
    public static class FigureHelper
    {
        public static Circle GetCircle()
        {
            TriesCheckHelper helperStepsTriesCheck = new TriesCheckHelper();
            Console.WriteLine("\nPlease, enter radius of a circle and press Enter: ");
            double radius = helperStepsTriesCheck.GetEnteredValue();

            Console.WriteLine("\nPress any key to proceed to next step...");
            Console.ReadLine();

            return new Circle(radius);
        }

        public static void PrintCircleArea(Circle circle)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Circle area is " + circle.GetCircleArea());
        }

        public static Square GetSquare()
        {
            TriesCheckHelper helperStepsTriesCheck = new TriesCheckHelper();
            Console.WriteLine("\nPlease, enter length of a square side and press Enter: ");
            double squareSide = helperStepsTriesCheck.GetEnteredValue();

            Console.WriteLine("Press any key to proceed to next step...");
            Console.ReadLine();

            return new Square(squareSide);
        }

        public static void PrintSquareArea(Square square)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Square area is " + Math.Round(square.GetSquareArea(), 2));
        }
    }
}
