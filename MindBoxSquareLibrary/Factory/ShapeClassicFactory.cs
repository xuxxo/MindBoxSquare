using MindBoxSquareLibrary.Common;
using MindBoxSquareLibrary.DefaultShapes;

namespace MindBoxSquareLibrary.Factory
{
    public class ShapeClassicFactory : IShapeFactory
    {
        public IShape CreateShape(ShapeType shapeType, params double[] parameters)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                {
                    if (parameters.Length != 1) throw new ArgumentException("Кол-во аргументов должно быть равно 1");
                    return new Circle(parameters[0]);
                }
                case ShapeType.Triangle:
                {
                    if (parameters.Length != 3) throw new ArgumentException("Кол-во аргументов должно быть равно 3");
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                }
                default: 
                    throw new ArgumentException("Неизвестный тип фигуры");
            };
        }
    }
}
