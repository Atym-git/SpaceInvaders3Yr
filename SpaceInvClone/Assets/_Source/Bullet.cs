using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _bulletLifeTime;
    private LayerMask _enemyLayer;

    public void Construct(float bulletLifeTime, LayerMask enemyLayer)
    {
        _bulletLifeTime = bulletLifeTime;
        _enemyLayer = enemyLayer;
        SelfDestruct();
        Debug.Log(_bulletLifeTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMaskUtil.ContainsLayer(_enemyLayer, collision.gameObject))
        {
            //ToDo: Deal dmg to enemy
            Debug.Log("Player Attacked enemy");
        }
        Destroy(gameObject);
    }

    private void SelfDestruct()
    {
        Destroy(gameObject, _bulletLifeTime);
    }
}
