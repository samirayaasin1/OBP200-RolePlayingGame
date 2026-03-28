namespace OBP200_RolePlayingGame;

public class Player
{
    public int MaxHp { get; private set; }
    public int Hp { get; private set; }
    public int Potions { get; private set; }

    public Player(int maxHP, int hp, int potions)
    {
        MaxHp = maxHP;
        Hp = hp;
        Potions = potions;
    }

    public void UsePotion()
    {
        if (Potions <= 0)
        {
            Console.WriteLine("du har inga drycker kvar.");
            return;
        }

        int oldHp = Hp;

        Hp = Math.Min(MaxHp, Hp + 12);
        Potions--;
        Console.WriteLine($"du dricker en dryck och återfår {Hp - oldHp} HP.");
    }
}

    

