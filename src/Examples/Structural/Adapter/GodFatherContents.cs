using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Structural.Adapter
{
    public class GodfatherContents : IPlayList
    {
        public string Title { get; } = "The Godfather";

        public IEnumerable<Item> GetItems()
        {
            yield return new Item { Title = "1: I Believe In America", Content = "Amerigo Bonasera asks Don Corleone for help." };
            yield return new Item { Title = "2: The Wedding", Content = "Celebrations for Connie and Carlo Wedding." };
            yield return new Item { Title = "3: Johnny Fontane", Content = "Johnny Fontane sings." };
            yield return new Item { Title = "4: Tom Hagen Goes To Hollywood", Content = "Tom Hagen Goes To Hollywood." };
            yield return new Item { Title = "5: Meeting With Sollozzo", Content = "Don Corleone turns down Sollozzo's offer." };
        }
    }
}
