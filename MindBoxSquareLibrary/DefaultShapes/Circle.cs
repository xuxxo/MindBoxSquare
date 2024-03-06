using MindBoxSquareLibrary.Common;

namespace MindBoxSquareLibrary.DefaultShapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        internal Circle(double radius)
        {
            _radius = radius;
        }

        public List<double> GetShapeParams()
        {
            return [_radius];
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
