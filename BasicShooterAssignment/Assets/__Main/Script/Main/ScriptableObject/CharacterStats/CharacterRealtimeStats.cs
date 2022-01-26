using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class CharacterRealtimeStats :ICharacterStats
{
    
    public float CharacterDamageAbsolute { get; set; }
    public float WeaponDamageAbsolute { get; set; }
    public float CharacterUpgradePercentageModifier { get; set; }
    public float AttackDamageAbsoluteModifier { get; set; }
    public float AttackDamagePercentModifier { get; set; }
}
