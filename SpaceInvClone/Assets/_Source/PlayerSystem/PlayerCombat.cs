using UnityEngine;

public class PlayerCombat
{
    public void Shoot(GameObject bulletPrefab,
                      float bulletSpeed,
                      Transform bulletRoot,
                      float bulletLifeTime,
                      LayerMask enemyLayer)
    {
        GameObject bulletInstance = Object.Instantiate(bulletPrefab,
                                                       bulletRoot.position,
                                                       Quaternion.identity);
        bulletInstance.GetComponent<Bullet>().Construct(bulletLifeTime, enemyLayer);
        bulletInstance.GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * bulletSpeed;
    }
}
