using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterStats 
{
  int CharacterDamageAbsolute { get; }
  int WeaponDamageAbsolute { get; }
  int CharacterUpgradePercentageModifier { get; }
  int AttackDamageAbsoluteModifier { get; }
  int AttackDamagePercentModifier { get; }
}
