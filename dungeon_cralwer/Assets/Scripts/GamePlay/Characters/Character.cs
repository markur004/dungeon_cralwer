using UnityEngine;
[CreateAssetMenu(fileName = "NewCharacter", menuName = "Game/Character/Character")]
public class Character : ScriptableObject
{
    
    [Header("References")]
    [SerializeField] private Enums.Class Class;
    [SerializeField] private Enums.Race Race;
    
    [Header("Item")]
    public Item Item;
    
    [Header("Stats")]
    public CharacterStats Stats;
    
    public Character()
    {
        CharacterStats baseStats = new CharacterStats();
        if (StatDatabase.ClassBaseStats.TryGetValue(Class, out var classStats))
            baseStats.Add(classStats);

        if (StatDatabase.RaceBonusStats.TryGetValue(Race, out var raceStats))
            baseStats.Add(raceStats);

        Stats = baseStats;
    }
}
