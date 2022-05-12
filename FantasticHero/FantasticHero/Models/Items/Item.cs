using System.Collections.Generic;

namespace FantasticHero.Models.Items
{
    public class Item
    {
        public List<Weapon> weapons { get; set; }

        public Bag bag { get; set; }
    }
}
