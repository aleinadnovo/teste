using FantasticHero.Models.Items;
using System.Collections.Generic;

namespace FantasticHero.Models.Heroes
{
    public class Hero
    {
        public string name { get; set; }

        public HeroType type { get; set; }

        public Item item { get; set; }
    }
}
