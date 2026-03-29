namespace OBP200_RolePlayingGame
{
    public class Potion : IItem
    {
        public void Use(Player player)
        {
            player.UsePotion();
        }
    }
}

