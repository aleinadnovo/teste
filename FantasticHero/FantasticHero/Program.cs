using Autofac;
using FantasticHero.Logic.GameZone;
using System;

namespace FantasticHero
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = ContainerConfiguration.Configure();

            using (var scope = configuration.BeginLifetimeScope())
            {
                var app = scope.Resolve<IGameZoneLogic>();
                app.generateGame();
            }

            Console.ReadKey();
        }
    }
}
