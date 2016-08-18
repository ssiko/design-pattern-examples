using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class BluRayPlayer: IBluRayPlayer
    {
        public Disc InsertedDisc { get; }

        public BluRayPlayer(Disc insertedDisc)
        {
            InsertedDisc = insertedDisc;
        }

        public void Play()
        {
            if (InsertedDisc.Type == "Blu-ray")
            {
                InsertedDisc.Play();
            }
            else
            {
                Console.WriteLine($"Please insert a Blu-ray Disc!!!\n\n");
            }
                
        }
    }
}
