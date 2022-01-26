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

    public float CalculateUpgrade(ICharacterStats characterStats, float baseDamage,float upgradeAbsoluteDamage)
    {
       return (baseDamage+ upgradeAbsoluteDamage)
       *characterStats.CharacterUpgradePercentageModifier;
    }
}
