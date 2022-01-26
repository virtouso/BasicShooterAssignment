using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterStats 
{
  float CharacterDamageAbsolute { get; }
  float WeaponDamageAbsolute { get; }
  float CharacterUpgradePercentageModifier { get; }
  float AttackDamageAbsoluteModifier { get; }
  float AttackDamagePercentModifier { get; }
}
