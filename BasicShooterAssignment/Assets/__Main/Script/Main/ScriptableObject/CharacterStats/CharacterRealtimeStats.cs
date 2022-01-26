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


    public CharacterRealtimeStats(float characterDamageAbsolute, float weaponDamageAbsolute, float characterUpgradePercentageModifier, float attackDamageAbsoluteModifier, float attackDamagePercentModifier)
    {
        CharacterDamageAbsolute = characterDamageAbsolute;
        WeaponDamageAbsolute = weaponDamageAbsolute;
        CharacterUpgradePercentageModifier = characterUpgradePercentageModifier;
        AttackDamageAbsoluteModifier = attackDamageAbsoluteModifier;
        AttackDamagePercentModifier = attackDamagePercentModifier;
    }
}
