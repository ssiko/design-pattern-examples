using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Creational.Builder
{
    public class BuilderDemo : DemoBase
    {
        protected override void DoRun()
        {
            Console.WriteLine("Create the 'Randomizing Demo Board'...");

            //Console.WriteLine("Initializing 'Simple Demo Board' with 50 shapes..."); -- NO LONGER NECESSARY !!!
            IShapeBoardBuilder builder = RandomizingShapeBuilder.Create("Randomizing Demo Board", 50);
            ShapeBoard board = builder.GetShapeBoard();

            Console.WriteLine($"Viewing shapes of '{board.Name}'...");
            foreach (Shape shape in board.Shapes)
            {
                Console.WriteLine($"\tViewing shape: {shape.Name}");
            }
        }
    }
}
