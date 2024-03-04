using MindBoxSquareLibrary.Common;

namespace MindBoxSquareLibrary.DefaultShapes
{
    public interface IShape
    {
        public ShapeType ShapeType { get; }

        public double GetSquare();

        public List<double> GetShapeParams();
    }
}
