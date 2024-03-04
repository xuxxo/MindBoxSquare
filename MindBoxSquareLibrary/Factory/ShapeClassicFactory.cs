using MindBoxSquareLibrary.Common;
using MindBoxSquareLibrary.DefaultShapes;

namespace MindBoxSquareLibrary.Factory
{
    public class ShapeClassicFactory : IShapeFactory
    {
        public IShape CreateShape(ShapeType shapeType, params double[] parameters) => 
            shapeType switch
            {
                ShapeType.Circle => new Circle(parameters[0]),
                ShapeType.Triangle => new Triangle(parameters[0], parameters[1], parameters[2]),
                _ => throw new ArgumentException("Неизвестный тип фигуры"),
            };
        
    }
}
