using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [field: SerializeField]
    public float PlayerMoveSpeed { get; private set; } = 3.0f;
}
