using System.Collections;
using System.Collections.Generic;using System.Runtime.CompilerServices;
using UnityEngine;

public interface IStatsCalculator<T> where T: StatModifierTypeBase
{
   float CalculateBaseDamage(  ICharacterStats characterStats);

   float CalculateUpgrade(ICharacterStats characterStats, 
    T modifier);
}
