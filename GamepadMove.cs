using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadMove : MonoBehaviour
{
    //PlayerControls controls;
    public float moveSpeed = 2f;
    private Vector2 moveInput;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 movement = new Vector3(moveInput.x, moveInput.y, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    /* APPROACH 1 */
    /* 
    private void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => moveInput = Vector2.zero;
    } */

    /*     private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    } */


    /* APPROACH 2 */

    /* private void Update()
    {
        Vector2 m = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed) * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    public void onMove(InputAction.CallbackContext ctx) => moveInput = ctx.ReadValue<Vector2>(); */
}
