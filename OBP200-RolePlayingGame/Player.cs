namespace OBP200_RolePlayingGame;

public class Player : IPlayer
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int MaxHp { get; private set; }
    public int Hp { get; private set; }

    public int Atk { get; set; }
    public int Def { get; set; }
    public int Gold { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }


    public List<IItem> Inventory { get; private set; } = new List<IItem>();

    public Player(int maxHp, int hp, int atk, int def, int gold)
    {
        MaxHp = maxHp;
        Hp = hp;
        Atk = atk;
        Def = def;
        Gold = gold;
        Xp = 0;
        Level = 1;
    }

    public void UseItem(IItem item)
    {
        item.Use(this);
        Inventory.Remove(item);
    }
    public void TakeDamage(int damage)
    {
        Hp -= damage;
        if (Hp < 0) Hp = 0;
    }

    public void Heal(int amount)
    {
        Hp = Math.Min(MaxHp, Hp + amount);
    }

    public void IncreaseMaxHp(int amount)
    {
        MaxHp += amount;
    }

}


    

