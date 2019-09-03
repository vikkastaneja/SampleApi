using System;
namespace ShapeApi.Shape
{
    public class Rectangle : Shape
    {
        private readonly uint side1;
        private readonly uint side2;
        public Rectangle(uint side1, uint side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public uint Area()
        {
            return side1 * side2;
        }
    }
}
