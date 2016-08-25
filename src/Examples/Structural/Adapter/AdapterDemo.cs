using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class AdapterDemo: DemoBase
    {
        protected override void DoRun()
        {
            BluRayDiscUS godFatherUS = new GodfatherUS();
            BluRayDiscEU godFatherEU = new GodfatherEU();
            BluRayPlayerUS playerUS = new BluRayPlayerUS();
            BluRayPlayerEU playerEU = new BluRayPlayerEU();

            Console.WriteLine("\n!!!!!!!!!!!!!!! In the US with US Blu-ray Player !!!!!!!!!!!!!!!\n");
            Console.WriteLine("\n##### US Blu-ray Player with US Blu-ray Disc #####\n");
            playerUS.InsertDisc(godFatherUS);
            playerUS.Play();
            playerUS.EjectDisc();

            Console.WriteLine("\n##### US Blu-ray Player with EU Blu-ray Disc #####\n");
            playerUS.InsertDisc(godFatherEU);
            playerUS.Play();
            playerUS.EjectDisc();

            Console.WriteLine("\n##### US Blu-ray Player with no Disc inserted #####\n");
            playerUS.Play();


            Console.WriteLine("\n!!!!!!!!!!!!!!! In the EU with EU Blu-ray Player !!!!!!!!!!!!!!!\n");
            Console.WriteLine("\n##### EU Blu-ray Player with EU Blu-ray Disc #####\n");
            playerEU.InsertDisc(godFatherEU);
            playerEU.Start();
            playerEU.EjectDisc();

            Console.WriteLine("\n##### EU Blu-ray Player with US Blu-ray Disc #####\n");
            playerEU.InsertDisc(godFatherUS);
            playerEU.Start();
            playerEU.EjectDisc();


            Console.WriteLine("\n!!!!!!!!!!!!!!! Bringing EU Blu-ray Player to US !!!!!!!!!!!!!!!\n");
            Console.WriteLine("\n##### EU Blu-ray Player (+US Adapter) With US Blu-ray Disc #####\n");
            BluRayAdapterUS playerEU_USAdapter = new BluRayAdapterUS(playerEU);
            playerEU_USAdapter.InsertDisc(godFatherUS);
            playerEU_USAdapter.Play();
            playerEU_USAdapter.EjectDisc();

            Console.WriteLine("\n##### EU Blu-ray Player (+US Adapter) With EU Blu-ray Disc #####\n");
            playerEU_USAdapter.InsertDisc(godFatherEU);
            playerEU_USAdapter.Play();
            playerEU_USAdapter.EjectDisc();


            Console.WriteLine("\n!!!!!!!!!!!!!!! Bringing US Blu-ray Player to EU !!!!!!!!!!!!!!!\n");
            Console.WriteLine("\n##### US Blu-ray Player (+EU Adapter) With EU Blu-ray Disc #####\n");
            BluRayAdapterEU playerUS_EUAdapter = new BluRayAdapterEU(playerUS);
            playerUS_EUAdapter.InsertDisc(godFatherEU);
            playerUS_EUAdapter.Start();
            playerUS_EUAdapter.EjectDisc();

            Console.WriteLine("\n##### US Blu-ray Player (+EU Adapter) With US Blu-ray Disc #####\n");
            playerUS_EUAdapter.InsertDisc(godFatherUS);
            playerUS_EUAdapter.Start();
            playerUS_EUAdapter.EjectDisc();
        }
    }
}
