using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.BaseAttackName,
    menuName = ScriptableObjectReferences.BaseAttackDirectory)]
public class StatModifierBaseAttack : StatModifierTypeBase
{
    [SerializeField] private UpgradeStats _stats;
    public override StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.BaseAttack;
    public override UpgradeStats Stats => _stats;
    public override float Upgrade(float baseDamage)
    {
        return (baseDamage+ _stats.UpgradeAbsoluteDamage)
               *_stats.UpgradePercentageDamage;
    }


    public StatModifierBaseAttack(UpgradeStats stats)
    {
        _stats = stats;
    }
}