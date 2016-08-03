using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Visitor
{
    public class ShapeBoard
    {
        public string Name { get; set; }
        public ICollection<Shape> Shapes { get; } = new List<Shape>();

        public void FillBoard(int size)
        {
            Random randomizer = new Random(100);

            Shapes.Clear();

            for (int index = 0; index < size; index++)
            {
                if (randomizer.Next() % 3 == 0)
                    Shapes.Add(new Circle { Name = $"Circle {index}" });
                else if (randomizer.Next() % 3 == 1)
                    Shapes.Add(new Square { Name = $"Square {index}" });
                else
                    Shapes.Add(new Triangle { Name = $"Triangle {index}" });
            }
        }

        public void RunBoard(IShapeVisitor visitor)
        {
            foreach(Shape shape in Shapes)
            {
                shape.Accept(visitor);
            }
        }
    }
}
