using System;
namespace ShapeApi.Shape
{
    public class Square : Shape
    {
        private readonly uint side;
        public Square(uint side)
        {
            this.side = side;
        }

        public uint Area()
        {
            return side * side;
        }
    }
}
