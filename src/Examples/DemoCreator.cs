using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples
{
    public class DemoCreator
    {
        public DemoBase Create(string demo)
        {
            Type t1 = Type.GetType("Examples.Behavioral." + demo + "." + demo + "Demo", false);                           
            Type t2 = Type.GetType("Examples.Structural." + demo + "." + demo + "Demo", false);
            Type t3 = Type.GetType("Examples.Creational." + demo + "." + demo + "Demo", false);

            if (t1 == null && t2 == null && t3 == null)
            {
                Console.Write("Type not found please enter another type: ");
                return Create(Console.ReadLine());
            }
            return (DemoBase)Activator.CreateInstance(t1 != null ? t1 : t2 != null ? t2 : t3 != null ? t3 : null);
        }
    }
}
