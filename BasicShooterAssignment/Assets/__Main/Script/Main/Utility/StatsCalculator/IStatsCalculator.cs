using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStatsCalculator<T>
{
   T CalculateDamageDealed( ICharacterStats characterStats);
   T CalculateBaseDamage();
}
