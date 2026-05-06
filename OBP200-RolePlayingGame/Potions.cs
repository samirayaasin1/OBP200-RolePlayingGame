namespace OBP200_RolePlayingGame
{
    public class Potion : IItem
    {
        private const int HealAmount = 12;

        public void Use(Player player)
        {
            int oldHp = player.Hp;
            player.Hp = Math.Min(player.MaxHp, player.Hp + HealAmount);

            Console.WriteLine($"Du dricker en dryck och återfår {player.Hp - oldHp} HP.");
        }


    }
}

