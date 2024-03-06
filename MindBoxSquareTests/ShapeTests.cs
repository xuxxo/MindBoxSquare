using Microsoft.Extensions.DependencyInjection;
using MindBoxSquareLibrary;
using MindBoxSquareLibrary.Common;
using MindBoxSquareLibrary.Factory;

namespace MindBoxSquareTests
{
    public class ShapeTests
    {
        private IShapeFactory _shapeFactory;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();
            services.AddTransient<IShapeFactory, ShapeClassicFactory>();
            var serviceProvider = services.BuildServiceProvider();

            _shapeFactory = serviceProvider.GetRequiredService<IShapeFactory>();
        }

        [Test]
        public void Test_TriangleSquare()
        {
            var triangle = _shapeFactory.CreateShape(ShapeType.Triangle, 6, 8, 10);

            var square = triangle.GetSquare();

            Assert.That(square, Is.EqualTo(24d));
        }

        [Test]
        public void Test_CircleSquare()
        {
            var circle = _shapeFactory.CreateShape(ShapeType.Circle, 5);

            var square = circle.GetSquare();

            var expectedSquare = 78.5398;

            Assert.That(Math.Round(square, 4), Is.EqualTo(expectedSquare));
        }

        [Test]
        public void Test_RightTriangle_True()
        {
            var triangle = _shapeFactory.CreateShape(ShapeType.Triangle, 6, 8, 10);

            var isTriangleRight = triangle.IsTriangleRight();

            Assert.That(isTriangleRight, Is.True);
        }

        [Test]
        public void Test_RightTriangle_False()
        {
            var triangle = _shapeFactory.CreateShape(ShapeType.Triangle, 5, 8, 10);

            var isTriangleRight = triangle.IsTriangleRight();

            Assert.That(isTriangleRight, Is.False);
        }
    }
}