using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [field: SerializeField]
    public float PlayerMoveSpeed { get; private set; } = 3.0f;
    
    [field: SerializeField]
    public Transform PlayerTransform { get; private set; }
    
    [field: SerializeField]
    public GameObject BulletPrefab { get; private set; }

    [field: SerializeField]
    public Transform BulletRoot { get; private set; }

    [field: SerializeField]
    public float BulletSpeed { get; private set; }
    
    [field: SerializeField]
    public float BulletLifeTime { get; private set; }
    
    [field: SerializeField]
    public LayerMask EnemyLayer { get; private set; }

}
