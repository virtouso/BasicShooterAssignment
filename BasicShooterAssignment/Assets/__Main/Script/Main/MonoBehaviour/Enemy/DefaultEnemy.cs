using UnityEngine;

public class DefaultEnemy : MonoBehaviour, IEnemy
{
    [SerializeField] private float _health;
    [SerializeField] private SpriteRenderer _sprite;
    public float Health => _health;
    public void ApplyAttack(float appliedDamage)
    {
        _health -= appliedDamage;
        _sprite.color= Color.yellow;
    }
}