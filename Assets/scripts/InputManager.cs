using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    PlayerControls playerContols;
    public  Vector2 movementInput;
    public Vector2 cameraInput;


    public float horizentalInput;
    public float verticalInput;
    public float cameraInputY;
    public float cameraInputX;


    private void OnEnable()
    {
        if (playerContols == null) {
            playerContols = new PlayerControls();
            playerContols.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerContols.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();

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

        cameraInputY = cameraInput.y;
        cameraInputX = cameraInput.x;
    }

    public void HandleAllInputs()
    {
        handleMovementInput();
    }


}





