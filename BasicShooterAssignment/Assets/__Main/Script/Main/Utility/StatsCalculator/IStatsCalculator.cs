using System.Collections;
using System.Collections.Generic;using System.Runtime.CompilerServices;
using UnityEngine;

public interface IStatsCalculator
{
   float CalculateBaseDamage(  ICharacterStats characterStats);

   float CalculateUpgrade<T>(ICharacterStats characterStats, float baseDamage,
    T modifier)where T: StatModifierTypeBase;
}
