using MindBoxSquareLibrary.Common;

namespace MindBoxSquareLibrary.DefaultShapes
{
    public class Triangle : IShape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public ShapeType ShapeType => ShapeType.Triangle;

        internal Triangle(double side1, double side2, double side3)
        {
            if (side1 + side2 <= side3 ||
                side2 + side3 <= side1 ||
                side3 + side1 <= side2)
            {
                throw new ArgumentException("Треугольник не может иметь такие стороны");

            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetSquare()
        {
            var semiPerimeter = 0.5 * (_side1 + _side2 + _side3);
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
        }


        public List<double> GetShapeParams() => [_side1, _side2, _side3];
    }
}
