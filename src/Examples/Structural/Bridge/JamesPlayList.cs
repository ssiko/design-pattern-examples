using System.Collections.Generic;

namespace Examples.Structural.Bridge
{
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