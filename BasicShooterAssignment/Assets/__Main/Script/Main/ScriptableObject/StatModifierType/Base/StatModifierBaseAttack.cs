using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.BaseAttackName,
    menuName = ScriptableObjectReferences.BaseAttackDirectory)]
public class StatModifierBaseAttack : StatModifierTypeBase
{
    public override StatsModifierTypeEnum StatsModifierTypeEnum => StatsModifierTypeEnum.BaseAttack;
    [SerializeField] private CharacterStats _stats;
    public override ICharacterStats ChangingStats => _stats;
}