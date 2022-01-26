using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.CharacterStatsName,
    menuName = ScriptableObjectReferences.CharacterStatsDirectory)]
public class CharacterStats : ScriptableObject, ICharacterStats
{
    [SerializeField] private float _characterDamageAbsolute;
    public float CharacterDamageAbsolute => _characterDamageAbsolute;

    [SerializeField] private float _weaponDamageAbsolute;
    public float WeaponDamageAbsolute => _weaponDamageAbsolute;

    [SerializeField] private float _characterUpgradePercentageModifier;
    public float CharacterUpgradePercentageModifier => _characterUpgradePercentageModifier;

    [SerializeField] private float _attackDamageAbsoluteModifier;
    public float AttackDamageAbsoluteModifier => _attackDamageAbsoluteModifier;

    [SerializeField] private float _attackDamagePercentModifier;
    public float AttackDamagePercentModifier => _attackDamagePercentModifier;
}