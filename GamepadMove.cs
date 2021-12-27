using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadMove : MonoBehaviour
{
    PlayerControls controls;
    public float moveSpeed = 5;

    private Vector2 moveDirection;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.Move.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => moveDirection = Vector2.zero;
    }

    private void Update()
    {
        Vector2 m =
            new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed) * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
