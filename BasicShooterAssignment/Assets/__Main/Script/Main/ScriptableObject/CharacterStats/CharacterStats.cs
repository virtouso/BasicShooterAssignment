using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.CharacterStatsName,
    menuName = ScriptableObjectReferences.CharacterStatsDirectory)]
public class CharacterStats : ScriptableObject, ICharacterStats
{
    [SerializeField] private float _characterDamageAbsolute;
    public float CharacterDamageAbsolute
    {
        get => _characterDamageAbsolute;
        set => _characterDamageAbsolute = value;
    }

    [SerializeField] private float _weaponDamageAbsolute;

    public float WeaponDamageAbsolute
    {
        get => _weaponDamageAbsolute;
        set => _weaponDamageAbsolute = value;
    }

    [SerializeField] private float _characterUpgradePercentageModifier;

    public float CharacterUpgradePercentageModifier
    {
        get => _characterUpgradePercentageModifier;
        set => _characterUpgradePercentageModifier = value;
    }

    [SerializeField] private float _attackDamageAbsoluteModifier;

    public float AttackDamageAbsoluteModifier
    {
        get => _attackDamageAbsoluteModifier;
        set => _attackDamageAbsoluteModifier = value;
    }

    [SerializeField] private float _attackDamagePercentModifier;

    public float AttackDamagePercentModifier
    {
        get => _attackDamagePercentModifier;
        set => _attackDamagePercentModifier = value;
    }
        

}