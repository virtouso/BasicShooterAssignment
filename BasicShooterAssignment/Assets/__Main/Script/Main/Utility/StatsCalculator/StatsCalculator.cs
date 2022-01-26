using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StatsCalculator : IStatsCalculator
{
    public float CalculateBaseDamage(ICharacterStats characterStats)
    {
        
        return characterStats.CharacterDamageAbsolute
               * (characterStats.CharacterUpgradePercentageModifier+characterStats.AttackDamageAbsoluteModifier)
        *characterStats.AttackDamagePercentModifier;
    }

    public float CalculateUpgrade<T>(ICharacterStats characterStats,float baseDamage, T modifier)where T: StatModifierTypeBase
    {
        return modifier.Upgrade(characterStats,baseDamage);
    }
}
