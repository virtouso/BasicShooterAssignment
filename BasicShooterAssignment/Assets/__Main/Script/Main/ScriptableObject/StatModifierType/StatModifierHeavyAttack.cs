

using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.HeavyAttackName,menuName =ScriptableObjectReferences.HeavyAttackDirectory )]
    public class StatModifierHeavyAttack:StatModifierTypeBase
    {
        public override StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.HeavyAttack;

        [SerializeField] private CharacterStats _stats;
        public override ICharacterStats ChangingStats => _stats;
    }
