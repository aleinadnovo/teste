using FantasticHero.Models.Monsters;
using System;
using System.Collections.Generic;

namespace FantasticHero.Logic.Monsters
{
    class MonsterLogic : IMonsterLogic
    {
        public IEnumerable<Monster> getAll()
        {
            var resultList = new List<Monster>();

            for (int i = 0; i < CoreFunctions.getRandomValue(); i++)
            {
                var typeOfMonster = generateType();

                resultList.Add(new Monster()
                {
                    type = typeOfMonster,
                    name = CoreFunctions.generateName("Monster", typeOfMonster.ToString()),
                });
            }

            return resultList;
        }

        public void add(Monster monster)
        {
            throw new NotImplementedException();
        }

        public void remove(Monster Monster)
        {
            throw new NotImplementedException();
        }

        #region private methods
        private MonsterType generateType()
        {
            var values = Enum.GetValues(typeof(MonsterType));
            return (MonsterType)values.GetValue(CoreFunctions.getRandomValue(values.Length));
        }
        #endregion
    }
}
