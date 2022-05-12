using Autofac;
using FantasticHero.Logic.GameZone;
using FantasticHero.Logic.Heroes;
using FantasticHero.Logic.Monsters;

namespace FantasticHero
{
    public static class ContainerConfiguration
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GameZoneLogic>().As<IGameZoneLogic>();
            builder.RegisterType<HeroLogic>().As<IHeroLogic>();
            builder.RegisterType<MonsterLogic>().As<IMonsterLogic>();

            return builder.Build();
        }
    }
}
