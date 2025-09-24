using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    private InputSystem _inputActions;
    private InputAction _movement;

    private float _verticalMoveF;

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
        _movement = _inputActions.Player.VerticalMove;
        _movement.Enable();

        InputAction playerAttack = _inputActions.Player.Attack;
        playerAttack.performed += Shoot;
        playerAttack.Enable();
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        _invoker.InvokeShoot();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        _verticalMoveF = _movement.ReadValue<float>();
        _invoker.InvokeMove(_verticalMoveF);
    }

    private void OnDisable()
    {
        _inputActions.Player.VerticalMove.Disable();
        _inputActions.Player.Attack.Disable();
    }
}
