using FantasticHero.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FantasticHero.Logic.Heroes
{
    public class HeroLogic : IHeroLogic
    {
        public List<Hero> getAll()
        {
            var resultList = new List<Hero>();

            for (int i = 0; i < CoreFunctions.getRandomValue(); i++)
            {
                var typeOfHero = generateHeroType();

                resultList.Add(new Hero()
                {
                    type = typeOfHero,
                    name = CoreFunctions.generateName("Hero", typeOfHero.ToString()),
                });
            }

            return resultList;
        }

        public Hero choosePlayer(List<Hero> heroes)
        {
            var position = CoreFunctions.getRandomValue(heroes.Count);

            return heroes.ElementAt(position);
        }

        public List<Hero> simulateAnotherHeroes(List<Hero> heroes, int numberOfMonsters)
        {
            var resultList = new List<Hero>();
            var numberOfHeroes = CoreFunctions.getRandomValue(heroes.Count);

            while (numberOfHeroes >= numberOfMonsters)
            {
                numberOfHeroes = CoreFunctions.getRandomValue(heroes.Count);
            }

            int lastRandomPosition = 0;
            for (int i = 0; i < numberOfHeroes; i++)
            {
                var randomPosition = CoreFunctions.getRandomValue(numberOfHeroes);

                while (randomPosition == lastRandomPosition)
                {
                    randomPosition = CoreFunctions.getRandomValue(numberOfHeroes);
                }

                resultList.Add(heroes.ElementAt(randomPosition - 1));
                lastRandomPosition = randomPosition;
            }

            return resultList;
        }

        #region private methods
        private HeroType generateHeroType()
        {
            var values = Enum.GetValues(typeof(HeroType));
            return (HeroType)values.GetValue(CoreFunctions.getRandomValue(values.Length));
        }

        public void add(Hero hero)
        {
            throw new NotImplementedException();
        }

        public void remove(Hero hero)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
