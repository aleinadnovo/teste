using FantasticHero.Models.Items;

namespace FantasticHero.Logic.GameZone
{
    public interface IGameZoneLogic
    {
        void generateGame();

        Direction setDirection();
    }
}
