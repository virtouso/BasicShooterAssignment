using System.Collections;
using UnityEngine;

public class DefaultEnemy : MonoBehaviour, IEnemy
{
    [SerializeField] private float _health;
    [SerializeField] private SpriteRenderer _sprite;
    public float Health => _health;
    public void ApplyAttack(float appliedDamage)
    {
        _health -= appliedDamage;
        _sprite.color=  new Color (0, 0, 1, 1);
        StartCoroutine(DisableDelayed());
    }

    private IEnumerator DisableDelayed()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
    
}