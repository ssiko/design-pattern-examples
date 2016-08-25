using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class BluRayPlayerEU : IBluRayPlayer, IBluRayPlayerEU
    {
        private BluRayDiscEU bluRayDisc;
        private Disc nonBluRayDisc;

        public void InsertDisc(Disc insertedDisc)
        {
            if (bluRayDisc == null && nonBluRayDisc == null)
            {
                try
                {
                    bluRayDisc = (BluRayDiscEU)insertedDisc;
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

        public void Start()
        {
            if (bluRayDisc != null)
            {
                bluRayDisc.Start();
            }
            else if (nonBluRayDisc != null)
            {
                Console.WriteLine($"The inserted disc is incompatible with this Blu-ray player.\nPlease insert a EU Blu-ray Disc!!!\n\n");
            }
            else
            {
                Console.WriteLine($"There is no disc inserted.\n");
            }
        }

        public BluRayDiscEU GetBluRayDisc()
        {
            return bluRayDisc;
        }

        public Disc GetNonBluRayDisc()
        {
            return nonBluRayDisc;
        }
    }
}
