namespace OBP200_RolePlayingGame;

public class Player
{
    public int MaxHp { get; private set; }
    public int Hp { get; set; }

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
}
   
    

