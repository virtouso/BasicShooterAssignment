

using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.BaseAttackName,menuName =ScriptableObjectReferences.BaseAttackDirectory )]
    public class StatModifierBaseAttack: ScriptableObject ,IStatModifierType
    {
        public StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.BaseAttack;
        [SerializeField] private CharacterStats _stats;
        public ICharacterStats ChangingStats => _stats;
    }
