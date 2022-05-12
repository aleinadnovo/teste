using System;

namespace FantasticHero.Logic
{
    public static class CoreFunctions
    {
        private const int minGeneratorValue = 1;
        private const int maxGeneratorValue = 2;

        public static string generateName(string entity, string type)
        {
            return string.Format("{0} {1} {2}", Guid.NewGuid(), entity, type);
        }

        public static int getRandomValue()
        {
            Random random = new Random();
            return random.Next(minGeneratorValue, maxGeneratorValue);
        }

        public static int getRandomValue(int maxValue)
        {
            Random random = new Random();
            return random.Next(0, maxValue);
        }
    }
}
