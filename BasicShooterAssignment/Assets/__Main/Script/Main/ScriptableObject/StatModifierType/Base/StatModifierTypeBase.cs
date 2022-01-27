using UnityEngine;

public abstract class StatModifierTypeBase : ScriptableObject
{
    public abstract StatsModifierTypeEnum StatsModifierTypeEnum { get; }
    public abstract UpgradeStats Stats { get; }

    public abstract float Upgrade(float baseDamage);
}