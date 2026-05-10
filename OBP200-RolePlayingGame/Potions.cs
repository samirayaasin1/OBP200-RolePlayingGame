namespace OBP200_RolePlayingGame
{
    public class Potion : IItem
    {
        private const int HealAmount = 12;

        public void Use(IPlayer player)
        {
            int oldHp = player.Hp;
            player.Heal(HealAmount);

            Console.WriteLine($"Du dricker en dryck och återfår {player.Hp - oldHp} HP.");
        }


    }
}
