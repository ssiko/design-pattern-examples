using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Creational.Builder
{
    public static class BuilderDemo
    {
        public static void Run()
        {
            Console.WriteLine("Create the 'Randomzing Demo Board'...");

            //Console.WriteLine("Initializing 'Simple Demo Board' with 50 shapes..."); -- NO LONGER NECESSARY !!!
            IShapeBoardBuilder builder = RandomzingShapeBuilder.Create("Randomzing Demo Board", 50);
            ShapeBoard board = builder.GetShapeBoard();

            Console.WriteLine($"Viewing shapes of '{board.Name}'...");
            foreach (Shape shape in board.Shapes)
            {
                Console.WriteLine($"\tViewing shape: {shape.Name}");
            }

            Console.WriteLine("\n\nPress <ENTER> key to continue...");
            Console.ReadLine();
        }
    }
}
