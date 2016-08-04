using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Creational.Builder
{
    public class ShapeBoard
    {
        public string Name { get; set; }
        public ICollection<Shape> Shapes { get; } = new List<Shape>();

        //public void FillBoard(int size)
        //public void RunBoard(IShapeVisitor visitor);
    }
}
