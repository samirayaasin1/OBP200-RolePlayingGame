namespace OBP200_RolePlayingGame
{
    class Potion : IItem
    {
        public void Use(Player player)
        {
            player.UsePotion();
        }
    }
}

