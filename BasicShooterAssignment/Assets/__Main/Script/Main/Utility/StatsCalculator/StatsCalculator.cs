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

  public  float CalculateUpgrade(float baseDamage,StatModifierTypeBase modifier)
  {
     return modifier.Upgrade(baseDamage);
  }
  
  
  
  
}
