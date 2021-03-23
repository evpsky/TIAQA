using System;
using OOP_task1.Helpers;

namespace OOP_task1.Task2
{
    public class CheckFigureShapes
    {
        public static void GetShape()
        {
            // Preview
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|==========================================================|");
            Console.WriteLine("| We calculated areas for circle and square                |");
            Console.WriteLine("| Let's check if circle can fit into square and vice versa!|");
            Console.WriteLine("|    Solve:                                                |");
            Console.WriteLine("|        а) can circle fit inside to square?               |");
            Console.WriteLine("|        б) can square fir inside of circle?               |");
            Console.WriteLine("|==========================================================|");
            Console.ForegroundColor = ConsoleColor.Green;
            // Get data from user
            HelperStepsTriesCheck helperStepsTriesCheck = new HelperStepsTriesCheck();
            Console.Write("\nEnter circle Area: ");
            double circleArea = helperStepsTriesCheck.GetEnteredValue();
            Console.Write("Enter square Area: ");
            double squareArea = helperStepsTriesCheck.GetEnteredValue();

            double squateSide = Math.Sqrt(squareArea);
            double circleDiametr = Math.Sqrt(circleArea / Math.PI) * 2;
            // Check if shapes can fit into each other
            if (squateSide < circleArea)
                Console.WriteLine("\nSquare fits to circle");
            else if (squateSide >= circleArea)
                Console.WriteLine("\nCircle can fit to square");
                Console.ReadKey();
        }
    }
}