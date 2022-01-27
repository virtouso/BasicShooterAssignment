using System;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour, IPlayerController
{
    [Inject] private IMainManager _mainManager;
    [Inject] private IStatsCalculator _statsCalculator;
    [SerializeField] private CharacterStats _playerDefaultStats;
   // private CharacterRealtimeStats _playerCurrentStats;


    [SerializeField] private float _moveSpeed;
    [SerializeField] private Camera _camera;
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private LayerMask _enemyLayer;
    [SerializeField] private LayerMask _dropLayer;


    private float _damagePower;
    
    private void ApplyBaseDamage(IEnemy enemy,Vector3 displayPosition)
    {
        enemy.ApplyAttack(_damagePower);
        Debug.Log($"applied damage::{_damagePower}");
        _mainManager.DisplayMessage($"applied damage::{_damagePower}",displayPosition);
    }

    private void Upgrade(StatModifierTypeBase statModifier,Vector3 displayPosition)
    {
        _damagePower = _statsCalculator.CalculateUpgrade(_damagePower, statModifier);
        Debug.Log($"New Damage Power::{_damagePower}");
        _mainManager.DisplayMessage($"New Damage Power::{_damagePower}",displayPosition);
    }
    
    
    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 finalMovement = new Vector3(horizontal, vertical).normalized * _moveSpeed;
        transform.Translate(finalMovement);
    }

    private void Look()
    {
        Vector3 position = Input.mousePosition;
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(position);
        Vector3 lookDirection = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        _rigidBody.rotation = angle;
    }


    private void Start()
    {
        _damagePower = _statsCalculator.CalculateBaseDamage(_playerDefaultStats);
    }

    private void Update()
    {
        Move();
        Look();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer ==Mathf.Log( _enemyLayer.value, 2))
        {
            ApplyBaseDamage(_mainManager.GetEnemy(other.transform),other.transform.position);
            Debug.Log("Hit Enemy");
        }
        else if (other.gameObject.layer == Mathf.Log(_dropLayer.value, 2))
        {
            Upgrade(_mainManager.GetDrop(other.transform).StatModifier,other.transform.position);
            _mainManager.GetDrop(other.transform).Consume();
            Debug.Log("Hit Drop");
        }
    }
}