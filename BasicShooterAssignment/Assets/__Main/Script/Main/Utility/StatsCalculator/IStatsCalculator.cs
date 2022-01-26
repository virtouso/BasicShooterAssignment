using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStatsCalculator
{
   float CalculateBaseDamage(  ICharacterStats characterStats);

   float CalculateUpgrade(ICharacterStats characterStats, float baseDamage,
     ICharacterStats upgrade);
}
