using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterStats 
{
  float CharacterDamageAbsolute { get; set; }
  float WeaponDamageAbsolute { get; set; }
  float CharacterUpgradePercentageModifier { get; set; }
  float AttackDamageAbsoluteModifier { get; set; }
  float AttackDamagePercentModifier { get; set; }
}
