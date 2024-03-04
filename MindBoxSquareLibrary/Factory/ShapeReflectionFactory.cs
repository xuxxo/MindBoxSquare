using MindBoxSquareLibrary.Common;
using MindBoxSquareLibrary.DefaultShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxSquareLibrary.Factory
{
    public class ShapeReflectionFactory : IShapeFactory
    {
        public IShape CreateShape(ShapeType shapeType, params double[] parameters)
        {
            var type = GetTypeOfShape(shapeType) ?? throw new Exception($"Не найден класс создаваемой фигуры: {shapeType}");

            return Activator.CreateInstance(type, parameters) as IShape ?? throw new Exception($"Не найден конструктор для фигуры {shapeType}");
        }

        private static Type? GetTypeOfShape(ShapeType shapeType)
        {
            return AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                    .Where(type => typeof(IShape).IsAssignableFrom(type) && !type.IsInterface).FirstOrDefault(x => x.Name == shapeType.ToString());
        }


    }
}
