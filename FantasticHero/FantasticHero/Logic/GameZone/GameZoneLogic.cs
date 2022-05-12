using FantasticHero.Logic.Heroes;
using FantasticHero.Logic.Monsters;
using FantasticHero.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FantasticHero.Logic.GameZone
{
    class GameZoneLogic : IGameZoneLogic
    {
        private IHeroLogic _heroLogic;
        private IMonsterLogic _monsterLogic;
        private Dictionary<string, bool> TasksStatus = new Dictionary<string, bool>();

        public GameZoneLogic(IHeroLogic heroLogic, IMonsterLogic monsterLogic)
        {
            _heroLogic = heroLogic;
            _monsterLogic = monsterLogic;
        }

        public void generateGame()
        {
            var getHeroes = _heroLogic.getAll();
            var getMonsters = _monsterLogic.getAll();
            var numberOfMonsters = getMonsters.Count();

            var choosePlayer = _heroLogic.choosePlayer(getHeroes.ToList());
            getHeroes = getHeroes.Where(x => x.type != choosePlayer.type).ToList();

            Console.WriteLine(string.Format("#### Player Name : {0} ####", choosePlayer.name));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("START GAME");
            Console.WriteLine(Environment.NewLine);

            startTasks(choosePlayer.name);


            for (int i = 0; i < getMonsters.Count(); i++)
            {
                startTasks(getMonsters.ElementAt(i).name);
            }

            Thread.Sleep(10000);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("#### ADDING NEW HEROES ####");
            Console.WriteLine(Environment.NewLine);

            var anotherHeroes = _heroLogic.simulateAnotherHeroes(getHeroes, numberOfMonsters);

            for (int i = 0; i < anotherHeroes.Count(); i++)
            {
                startTasks(anotherHeroes.ElementAt(i).name);
            }

            while (TasksStatus.Where(x => x.Value == false).Count() > 0)
            {
                Thread.Sleep(3000);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("END GAME");
            Console.WriteLine(Environment.NewLine);
        }

        public Direction setDirection()
        {
            var values = Enum.GetValues(typeof(Direction));
            return (Direction)values.GetValue(CoreFunctions.getRandomValue(values.Length));
        }

        #region private methods
        private async void startTasks(string playerName)
        {
            try
            {
                TasksStatus.Add(playerName, false);

                await SimulateMovements(playerName);

                TasksStatus[playerName] = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("ERROR -->> {0}", ex.Message));
            }
        }

        private async Task SimulateMovements(string name)
        {
            for (int i = 0; i < 2; i++)
            {
                await Task.Factory.StartNew(Console.WriteLine, string.Format("{0} moves to {1}" , name, setDirection().ToString()));
                await Task.Delay(CoreFunctions.getRandomValue(15000));
            }
        }
        #endregion
    }
}
