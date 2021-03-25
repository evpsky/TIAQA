using System;

namespace OOP_task1
{
    public class Circle
    {
        public double Radius { get; set; } 

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public double GetCircleArea() 
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}

