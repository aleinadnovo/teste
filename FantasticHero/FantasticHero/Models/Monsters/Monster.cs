namespace FantasticHero.Models.Monsters
{
    public class Monster
    {
        public string name { get; set; }

        public MonsterType type { get; set; }

        public Monster()
        {

        }
        public Monster(string name, MonsterType type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
