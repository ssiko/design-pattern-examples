using System.Collections.Generic;

namespace Examples.Structural.Bridge
{
    public interface IPlayList
    {
        string Title { get; }

        IEnumerable<Song> GetSongs();
    }
}