using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Bridge
{
    public interface IPlayList
    {
        string Title { get; }

        IEnumerable<Song> GetSongs();
    }

    public class JamesPlayList : IPlayList
    {
        public string Title { get; } = "Today's Rap and R&B Hits";

        public IEnumerable<Song> GetSongs()
        {
            yield return new Song { Title = "Cut It (feat. Young Dolph", Artist = "O.T. Genasis" };
            yield return new Song { Title = "You Needed Me", Artist = "Rihanna" };
            yield return new Song { Title = "Exchange", Artist = "Bryson Tiller" };
            yield return new Song { Title = "THat Part (feat. Kayne West)", Artist = "ScHoolboy Q" };
            yield return new Song { Title = "New Level (feat. Future)", Artist = "A$AP Ferg" };
        }
    }
}
