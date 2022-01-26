using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.HeavyAttackName,
    menuName = ScriptableObjectReferences.HeavyAttackDirectory)]
public class StatModifierHeavyAttack : StatModifierTypeBase
{
    public override StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.HeavyAttack;

    public override float Upgrade(ICharacterStats stats, float baseDamage)
    {
        return (baseDamage + stats.CharacterDamageAbsolute)
               * stats.CharacterUpgradePercentageModifier * 2;
    }
}