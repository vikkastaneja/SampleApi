using System;
namespace ShapeApi.Shape
{
    public class Rectangle : Shape
    {
        private readonly int side1;
        private readonly int side2;
        public Rectangle(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public int Area()
        {
            return side1 * side2;
        }
    }
}
