using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    PlayerControls playerContols;
    public  Vector2 movementInput;
    public float horizentalInput;
    public float verticalInput;

    private void OnEnable()
    {
        if (playerContols == null) {
            playerContols = new PlayerControls();
            playerContols.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();

    }
        playerContols.Enable();
}

    private void OnDisable()
    {
        playerContols.Disable();    
    }

    private void handleMovementInput() {  
    horizentalInput = movementInput.x;
    verticalInput = movementInput.y;
    }

    public void HandleAllInputs()
    {
        handleMovementInput();
    }
}



