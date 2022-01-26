using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour,IMainManager
{

    public IEnemy GetEnemy(Transform transform)
    {
        return _enemies[transform];
    }

    public IUpgradeDrop GetDrop(Transform transform)
    {
        return _drops[transform];
    }
    
    
    
    
    private Dictionary<Transform, IEnemy> _enemies;
    private Dictionary<Transform, IUpgradeDrop> _drops;

    private void FindDrops()
    {
        var drops = GameObject.FindObjectsOfType<UpgradeDrop>();
        _drops = new Dictionary<Transform, IUpgradeDrop>(drops.Length);
        foreach (var item in drops)
        {
            _drops.Add(item.transform, item);
        }

    }

    private void FindEnemies()
    {
        var enemies = GameObject.FindObjectsOfType<DefaultEnemy>();
        _enemies = new Dictionary<Transform, IEnemy>(enemies.Length);
        foreach (var item in enemies)
        {
            _enemies.Add(item.transform, item);
        }

    }
    private void Start()
    {
        FindDrops();
        FindEnemies();
    }

  
}
