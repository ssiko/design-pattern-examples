using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class BluRayPlayerUS : IBluRayPlayer , IBluRayPlayerUS
    {
        private BluRayDiscUS bluRayDisc;
        private Disc nonBluRayDisc;

        public void InsertDisc(Disc insertedDisc)
        {
            if(bluRayDisc == null && nonBluRayDisc == null)
            {
                try
                {
                    bluRayDisc = (BluRayDiscUS)insertedDisc;
                    nonBluRayDisc = null;
                }
                catch (Exception e)
                {
                    nonBluRayDisc = insertedDisc;
                    bluRayDisc = null;
                }
            }
            else
            {
                Console.WriteLine($"There is already a disc inserted.\n");
            }
        }

        public void EjectDisc()
        {
            bluRayDisc = null;
            nonBluRayDisc = null;

            Console.WriteLine($"+++ Ejected the disc +++\n");
        }

        public void Play()
        {
            if(bluRayDisc != null)
            {
                bluRayDisc.Play();
            }
            else if(nonBluRayDisc != null)
            {
                Console.WriteLine($"The inserted disc is incompatible with this Blu-ray player.\nPlease insert a US Blu-ray Disc!!!\n\n");
            }
            else
            {
                Console.WriteLine($"There is no disc inserted.\n");
            }
        }

        public BluRayDiscUS GetBluRayDisc()
        {
            return bluRayDisc;
        }

        public Disc GetNonBluRayDisc()
        {
            return nonBluRayDisc;
        }
    }
}
