using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class StatsCalculator_Tests
{
    private IStatsCalculator _statCalculator;

    [SetUp]
    public void SetUp()
    {
        _statCalculator = new StatsCalculator();
    }

    [Test]
    public void CalculateBaseDamageTest()
    {
        CharacterStats stats = new CharacterStats(100,
            200,
            5,
            50,
            6.75f);


        float result = _statCalculator.CalculateBaseDamage(stats);
        Assert.AreEqual(result, 37125);
    }


    [Test]
    public void CalculateUpgrade_Base()
    {
        StatModifierTypeBase modifier = new StatModifierBaseAttack(new UpgradeStats(100, 10));
        
        float result = modifier.Upgrade(37125);

        Assert.AreEqual(372250, result);
    }

    [Test]
    public void CalculateUpgrade_Heavy()
    {
        StatModifierTypeBase modifier = new StatModifierHeavyAttack(new UpgradeStats(50, 5));
        
        float result = modifier.Upgrade(372250);

        Assert.AreEqual(3723000, result);
    }
}