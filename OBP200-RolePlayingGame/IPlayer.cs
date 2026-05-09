namespace OBP200_RolePlayingGame;

public interface IPlayer
{
    int Hp { get; }
    int MaxHp { get; }
    void Heal(int amount);
}