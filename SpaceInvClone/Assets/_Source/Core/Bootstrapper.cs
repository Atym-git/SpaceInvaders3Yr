using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private InputListener inputListener;

    private void Awake()
    {
        PlayerMovement playerMovement = new();
        PlayerCombat playerCombat = new();

        Invoker invoker = new Invoker(playerMovement, playerData, playerCombat);

        inputListener.Construct(invoker);
    }
}
