using System;
using OOP_task1.Helpers;

namespace OOP_task1.Task2
{
    public static class ShapesChecker
    {
        public static void GetShape(Circle circle, Square square)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|==========================================================|");
            Console.WriteLine("| We calculated areas for circle and square                |");
            Console.WriteLine("| Let's check if circle can fit into square and vice versa!|");
            Console.WriteLine("|    Solve:                                                |");
            Console.WriteLine("|        а) can circle fit inside to square?               |");
            Console.WriteLine("|        б) can square fir inside of circle?               |");
            Console.WriteLine("|==========================================================|");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\nCalculated circle Area: {0}", 15);
            Console.Write("\nCalculated square Area: {0}", 15);
            

            double squareSide = Math.Sqrt(15);
            double circleDiametr = Math.Sqrt(15 / Math.PI) * 2;

            // Check if shapes can fit into each other
            if (squareSide < circleDiametr)
                Console.WriteLine("\na) Square fits to circle");
            else if (squareSide >= circleDiametr)
                Console.WriteLine("\nb) Circle can fit to square");
                Console.ReadKey();
        }
    }
}