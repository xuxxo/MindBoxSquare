using MindBoxSquareLibrary.Common;

namespace MindBoxSquareLibrary.DefaultShapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        internal Circle(double _radius)
        {
            this._radius = _radius;
        }

        public ShapeType ShapeType => ShapeType.Circle;

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
