using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    private InputSystem _inputActions;

    private float _verticalMove;

    private Invoker _invoker;

    public void Construct(Invoker invoker)
    {
        _invoker = invoker;
    }

    private void Start()
    {
        _inputActions = new();
        Bind();
    }

    private void Bind()
    {
        InputAction verticalMoveAction = _inputActions.Player.VerticalMove;

        _verticalMove = verticalMoveAction.ReadValue<float>();
        verticalMoveAction.Enable();
    }

    private void Update()
    {
        _invoker.InvokeMove(_verticalMove);
    }
}
