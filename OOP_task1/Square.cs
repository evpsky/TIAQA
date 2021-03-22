using System;


namespace OOP_task1
{
    public class Square
    {
        private double _squareSide; //a side of a square
        public double SquareSide { get; set; }// getter and setter

        public Square(double squareSide)  // constructor
        {
            SquareSide = squareSide;
        }
        public double GetSquareOfFigureSquare() // method to calculate square of a figure square
        {
            return _squareSide * _squareSide;
        }
    }
}

