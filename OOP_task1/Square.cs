using System;


namespace OOP_task1
{
    public class Square
    {
        private double _squareSide; //a side of a square
        public double SquareArea { get; set; }// getter and setter

        public Square(double squareSide)  // constructor
        {
            SquareArea = _squareSide;
        }
        public double GetSquareArea() // method to calculate square of a figure square
        {
            return SquareArea * SquareArea;
        }
    }
}

