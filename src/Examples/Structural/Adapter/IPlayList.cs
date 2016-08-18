using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public interface IPlayList
    {
        string Title { get; }

        IEnumerable<Item> GetItems();
    }
}
