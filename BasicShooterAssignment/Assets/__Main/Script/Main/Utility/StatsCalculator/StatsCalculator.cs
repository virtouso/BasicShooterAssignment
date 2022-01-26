using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StatsCalculator<T> : IStatsCalculator<T> where T: StatModifierTypeBase
{
    public float CalculateBaseDamage(ICharacterStats characterStats)
    {
        
        return characterStats.CharacterDamageAbsolute
               * (characterStats.CharacterUpgradePercentageModifier+characterStats.AttackDamageAbsoluteModifier)
        *characterStats.AttackDamagePercentModifier;
    }

    public float CalculateUpgrade(ICharacterStats characterStats, T modifier)
    {
        float baseDamage = CalculateBaseDamage(characterStats);
       return modifier.Upgrade(characterStats,baseDamage);
    }
}
