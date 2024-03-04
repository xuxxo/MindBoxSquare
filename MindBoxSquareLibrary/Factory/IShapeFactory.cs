using MindBoxSquareLibrary.Common;
using MindBoxSquareLibrary.DefaultShapes;

namespace MindBoxSquareLibrary.Factory
{
    public interface IShapeFactory
    {
        public IShape CreateShape(ShapeType shapeType, params double[] parameters);
    }
}