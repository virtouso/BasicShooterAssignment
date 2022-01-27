using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ScriptableObjectReferences.UpgradeStatsName,menuName = ScriptableObjectReferences.UpgradeStatsDirectory)]
public class UpgradeStats : ScriptableObject,IUpgradeStats
{
    [SerializeField] private int _upgradeAbsoluteDamage;
    public int UpgradeAbsoluteDamage => _upgradeAbsoluteDamage;

    [SerializeField] private float _upgradePercentageDamage;
    public float UpgradePercentageDamage => _upgradePercentageDamage;
}
