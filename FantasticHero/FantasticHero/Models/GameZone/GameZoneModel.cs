using FantasticHero.Models.Heroes;
using FantasticHero.Models.Monsters;
using System.Collections.Generic;

namespace FantasticHero.Models.GameZone
{
    public class GameZoneModel
    {
        public Hero selectedHero { get; set; }

        public List<Hero> anotherHeroes { get; set; }

        public List<Monster> Monsters { get; set; }
    }
}
