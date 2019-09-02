using System;
namespace ShapeApi.Shape
{
    public class Square : Shape
    {
        private readonly int side;
        public Square(int side)
        {
            this.side = side;
        }

        public int Area()
        {
            return side * side;
        }
    }
}
