
    public interface IStatModifierType
    {
        StatsModifierTypeEnum StatsModifierTypeEnum { get; }
        ICharacterStats ChangingStats { get; }
    }
