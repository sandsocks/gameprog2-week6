using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // playercontrols
    private PlayerControl playerControl;

    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    public void OnEnable()
    {
        if (playerControl == null) 
        {
            playerControl = new PlayerControl();
            //when we hit WASD, record the movement to the variable movementInput
            playerControl.PlayerControls.WASD.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerControl.Enable();
    }
    private void OnDisable()
    {
        playerControl.Disable();
    }

    public void HandleAllInput()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
