using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class BluRayAdapterUS : IBluRayPlayer, IBluRayPlayerUS
    {
        public BluRayPlayerEU player;

        public BluRayAdapterUS(BluRayPlayerEU player)
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

        public void Play()
        {
            if (player.GetBluRayDisc() != null)
            {
                player.Start();
            }
            else if (player.GetNonBluRayDisc() != null)
            {
                try
                {
                    BluRayDiscUS brUS = (BluRayDiscUS)player.GetNonBluRayDisc();
                    brUS.Play();
                }
                catch(Exception e)
                {
                    Console.WriteLine($"The inserted disc is incompatible with this Blu-ray player.\nPlease insert a EU or US Blu-ray Disc!!!\n\n");
                }                
            }
            else
            {
                Console.WriteLine($"There is no disc inserted.\n");
            }
        }


    }
}
