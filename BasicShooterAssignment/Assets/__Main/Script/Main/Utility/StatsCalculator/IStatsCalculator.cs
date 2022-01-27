using System.Collections;
using System.Collections.Generic;using System.Runtime.CompilerServices;
using UnityEngine;

public interface IStatsCalculator
{
   float CalculateBaseDamage(  ICharacterStats characterStats);

   float CalculateUpgrade(float baseDamage,StatModifierTypeBase modifier);
}
