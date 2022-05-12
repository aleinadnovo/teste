using FantasticHero.Models.Heroes;
using System.Collections.Generic;

namespace FantasticHero.Logic.Heroes
{
    public interface IHeroLogic
    {
        List<Hero> getAll();

        Hero choosePlayer(List<Hero> heroes);

        List<Hero> simulateAnotherHeroes(List<Hero> heroes, int numberOfMonsters);

        void add(Hero hero);

        void remove(Hero hero);
    }
}
