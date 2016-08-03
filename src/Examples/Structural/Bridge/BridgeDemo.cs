using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Bridge
{
    public static class BridgeDemo
    {
        public static void Run()
        {
            SongPlayer player = new SongPlayer { Name = "Pandora" };
            player.PlayList = new JamesPlayList();
            player.Play();

            Console.WriteLine("\n\nPress <ENTER> key to continue...");
            Console.ReadLine();
        }
    }
}
