

using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.HeavyAttackName,menuName =ScriptableObjectReferences.HeavyAttackDirectory )]
    public class StatModifierHeavyAttack:ScriptableObject,IStatModifierType
    {
        public StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.HeavyAttack;

        [SerializeField] private CharacterStats _stats;
        public ICharacterStats ChangingStats => _stats;
    }
