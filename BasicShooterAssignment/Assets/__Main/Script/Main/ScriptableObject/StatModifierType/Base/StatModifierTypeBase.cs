
    using UnityEngine;

    public abstract  class StatModifierTypeBase:ScriptableObject
    {
     public abstract   StatsModifierTypeEnum StatsModifierTypeEnum { get; }

    public abstract float Upgrade(ICharacterStats stats,float baseDamage);

    }
