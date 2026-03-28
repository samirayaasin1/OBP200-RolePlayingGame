namespace OBP200_RolePlayingGame
{
    class Potion : IItem
    {
        public void Use(Players player)
        {
            player.UsePotion();
        }
    }
}

