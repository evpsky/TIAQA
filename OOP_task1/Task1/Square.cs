namespace OOP_task1
{
    public class Square
    {
        public double SquareSide { get; set; }

        public Square(double squareSide)
        {
            SquareSide = squareSide;
        }

        public double GetSquareArea()
        {
            return SquareSide * SquareSide;
        }
    }
}

