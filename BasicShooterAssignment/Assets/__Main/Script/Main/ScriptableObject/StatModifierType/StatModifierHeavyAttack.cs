using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.HeavyAttackName,
    menuName = ScriptableObjectReferences.HeavyAttackDirectory)]
public class StatModifierHeavyAttack : StatModifierTypeBase
{
    [SerializeField] private UpgradeStats _stats;
    public override StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.HeavyAttack;
    public override UpgradeStats Stats => _stats;
    
    public override float Upgrade(float baseDamage)
    {
        return (baseDamage+ _stats.UpgradeAbsoluteDamage)
               *_stats.UpgradePercentageDamage *2;
    }
    
    public StatModifierHeavyAttack(UpgradeStats stats)
    {
        _stats = stats;
    }
    
}