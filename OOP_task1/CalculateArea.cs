using System;
using OOP_task1.Helpers;


namespace OOP_task1
{
    class CalculateArea
    {
        public static void AreaOfACircle()
        {
            HelperStepsTriesCheck helperStepsTriesCheck = new HelperStepsTriesCheck();
            Console.WriteLine("\nPlease, enter radius of a circle and press any Enter: ");
            double radius = helperStepsTriesCheck.GetEnteredValue();

            Circle circle = new Circle(radius);
            Console.WriteLine("Circle area is " + Math.Round(circle.GetCircleArea(), 2));

            Console.WriteLine("Press any key to proceed to next step...");
            Console.ReadLine();
        }
        public static void AreaOfASquare()
        {
            HelperStepsTriesCheck helperStepsTriesCheck = new HelperStepsTriesCheck();
            Console.WriteLine("\nPlease, enter length of a square side and press any Enter: ");
            double side = helperStepsTriesCheck.GetEnteredValue();

            Square square = new Square(side);
            Console.WriteLine("Circle area is " + Math.Round(square.GetSquareArea(), 2));

            Console.WriteLine("Press any key to proceed to next step...");
            Console.ReadLine();
        }
    }
}
