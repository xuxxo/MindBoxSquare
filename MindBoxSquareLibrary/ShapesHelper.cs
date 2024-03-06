using MindBoxSquareLibrary.DefaultShapes;

namespace MindBoxSquareLibrary
{
    public static class ShapesHelper
    {
        public static bool IsTriangleRight(this IShape shape) 
        {
            if (shape == null || shape is not Triangle)
            {
                throw new ArgumentException("Передан не треугольник");
            }

            var sides = shape.GetShapeParams();

            var potentialHypothesis = sides.Max();
            sides.Remove(potentialHypothesis);

            return Math.Pow(potentialHypothesis, 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
