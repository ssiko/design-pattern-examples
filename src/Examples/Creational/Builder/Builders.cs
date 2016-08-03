using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Creational.Builder
{
    public interface IShapeBoardBuilder
    {
        void SetName(string name);

        void AddCircle(Circle circle);
        void AddSquare(Square square);
        void AddTriangle(Triangle triangle);

        ShapeBoard GetShapeBoard();
    }

    public class RandomzingShapeBuilder : IShapeBoardBuilder
    {
        private readonly ShapeBoard _shapeBoard = new ShapeBoard();

        public void SetName(string name)
        {
            _shapeBoard.Name = name;
        }

        public void AddCircle(Circle circle)
        {
            _shapeBoard.Shapes.Add(circle);
        }

        public void AddSquare(Square square)
        {
            _shapeBoard.Shapes.Add(square);
        }

        public void AddTriangle(Triangle triangle)
        {
            _shapeBoard.Shapes.Add(triangle);
        }

        ShapeBoard IShapeBoardBuilder.GetShapeBoard()
        {
            return _shapeBoard;
        }

        public static IShapeBoardBuilder Create(string name, int size)
        {
            RandomzingShapeBuilder builder = new RandomzingShapeBuilder();
            builder.SetName(name);

            Random randomizer = new Random(100);

            for (int index = 0; index < size; index++)
            {
                if (randomizer.Next() % 3 == 0)
                    builder.AddCircle(new Circle { Name = $"Circle {index}" });
                else if (randomizer.Next() % 3 == 1)
                    builder.AddSquare(new Square { Name = $"Square {index}" });
                else
                    builder.AddTriangle(new Triangle { Name = $"Triangle {index}" });
            }

            return builder;
        }
    }
}

