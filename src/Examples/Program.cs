using System;
using System.Linq;
using Examples.Creational.Factory;
namespace Examples
{
    public class Program
    {
        static DemoCreator demoCreator = null;

        public static void Main(string[] args)
        {
            if (args.Contains("reflection"))
                demoCreator = new ReflectionDemoCreator();
            else
                demoCreator = new NumericDemoCreator();

            demoCreator.PrintDemoes();
            Console.Write("Please enter the pattern you wish to run: ");
            DemoBase demo = demoCreator.Create(Console.ReadLine());
            if (demo.Run())
                Main(args);
        }
    }
}
