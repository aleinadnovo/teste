using FantasticHero.Models.Monsters;
using System.Collections.Generic;

namespace FantasticHero.Logic.Monsters
{
    public interface IMonsterLogic
    {
        IEnumerable<Monster> getAll();

        void add(Monster monster);

        void remove(Monster Monster);
    }
}