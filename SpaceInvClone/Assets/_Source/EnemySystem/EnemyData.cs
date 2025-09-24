using UnityEngine;

public class EnemyData : MonoBehaviour
{
    private int _bounty;

    private int _damage;
    private int _health;

    [SerializeField] private EnemyHealth enemyHealth;

    private void OnDisable()
    {
        enemyHealth.TakeDamage(_health, _damage, _bounty);
    }
}
