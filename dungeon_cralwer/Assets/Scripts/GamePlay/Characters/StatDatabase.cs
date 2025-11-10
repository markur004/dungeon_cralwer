using System.Collections.Generic;

public static class StatDatabase
{
    public static readonly Dictionary<Enums.Class, CharacterStats> ClassBaseStats = new()
    {
        { Enums.Class.Warrior, new CharacterStats(120, 10, 4) },
        { Enums.Class.Tank,    new CharacterStats(60, 3, 6) },
        { Enums.Class.Mage,   new CharacterStats(80, 6, 10) },
    };

    public static readonly Dictionary<Enums.Race, CharacterStats> RaceBonusStats = new()
    {
        { Enums.Race.Skeleton, new CharacterStats(10, 2, 2) },
        { Enums.Race.Golem,   new CharacterStats(0, 0, 5) },
        { Enums.Race.Draug,   new CharacterStats(20, 5, -2) },
    };
}
