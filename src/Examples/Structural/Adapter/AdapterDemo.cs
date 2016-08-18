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
            BluRayDisc godFather = new GodfatherBR();
            BluRayPlayer player = new BluRayPlayer(godFather);
            player.Play();
        }
    }
}
