using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.BaseAttackName,
    menuName = ScriptableObjectReferences.BaseAttackDirectory)]
public class StatModifierBaseAttack : StatModifierTypeBase
{
    public override StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.BaseAttack;
    public override float Upgrade(ICharacterStats stats, float baseDamage)
    {
         return (baseDamage+ stats.CharacterDamageAbsolute)
         *stats.CharacterUpgradePercentageModifier;
    }
}