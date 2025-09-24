using UnityEngine;

public class EnemyHealth
{
    private Score _score;

    public EnemyHealth(Score score)
    {
        _score = score;
    }

    public void TakeDamage(int health, int damage, int score)
    {
        health -= damage;
        if (health <= 0)
        {
            _score.TakeScore(score);
        }
    }
}
