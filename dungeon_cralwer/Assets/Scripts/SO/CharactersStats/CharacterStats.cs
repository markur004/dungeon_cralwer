[System.Serializable]
public class CharacterStats
{
    public int Health = 100;
    public int Strength = 100;
    public int Agility = 10;

    public CharacterStats() { }

    public CharacterStats(int health, int strength, int agility)
    {
        Health = health;
        Strength = strength;
        Agility = agility;
    }

    public void Add(CharacterStats other)
    {
        Health += other.Health;
        Strength += other.Strength;
        Agility += other.Agility;
    }
}
