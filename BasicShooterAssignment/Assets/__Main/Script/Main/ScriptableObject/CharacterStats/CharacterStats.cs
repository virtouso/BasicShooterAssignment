using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.CharacterStatsName,
    menuName = ScriptableObjectReferences.CharacterStatsDirectory)]
public class CharacterStats : ScriptableObject, ICharacterStats
{
    [SerializeField] private int _characterDamageAbsolute;
    public int CharacterDamageAbsolute => _characterDamageAbsolute;

    [SerializeField] private int _weaponDamageAbsolute;
    public int WeaponDamageAbsolute => _weaponDamageAbsolute;

    [SerializeField] private int _characterUpgradePercentageModifier;
    public int CharacterUpgradePercentageModifier => _characterUpgradePercentageModifier;

    [SerializeField] private int _attackDamageAbsoluteModifier;
    public int AttackDamageAbsoluteModifier => _attackDamageAbsoluteModifier;

    [SerializeField] private int _attackDamagePercentModifier;
    public int AttackDamagePercentModifier => _attackDamagePercentModifier;
}