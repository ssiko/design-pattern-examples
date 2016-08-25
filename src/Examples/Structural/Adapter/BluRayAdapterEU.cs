using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class BluRayAdapterEU : IBluRayPlayer, IBluRayPlayerEU
    {
        public BluRayPlayerUS player;

        public BluRayAdapterEU(BluRayPlayerUS player)
        {
            this.player = player;
        }

        public void InsertDisc(Disc insertedDisc)
        {
            player.InsertDisc(insertedDisc);
        }

        public void EjectDisc()
        {
            player.EjectDisc();
        }

        public void Start()
        {
            if (player.GetBluRayDisc() != null)
            {
                player.Play();
            }
            else if (player.GetNonBluRayDisc() != null)
            {
                try
                {
                    BluRayDiscEU brEU = (BluRayDiscEU)player.GetNonBluRayDisc();
                    brEU.Start();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"The inserted disc is incompatible with this Blu-ray player.\nPlease insert a US or EU Blu-ray Disc!!!\n\n");
                }
            }
            else
            {
                Console.WriteLine($"There is no disc inserted.\n");
            }
        }
    }
}
