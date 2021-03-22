using System;


namespace OOP_task1
{
    public class Circle
    {
        private double _radius; // radius of a circle
        public double Radius { get; set; } // getter and setter 
        public Circle(double radius) // constructor
        {
            Radius = radius;
        }

        public double GetCircleSquare() // get circle square
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}

