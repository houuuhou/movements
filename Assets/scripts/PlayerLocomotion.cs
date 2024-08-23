using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocamotion : MonoBehaviour
{
    InputManager inputManager;
    Vector3 moveDirection;
    Transform cameraObject;
    Rigidbody playerRigidbody;
    public float movementSpeed = 6;
    public float rotationSpeed = 10;
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerRigidbody = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }
    private void  HandleMovement()
    {
       moveDirection = cameraObject.forward * inputManager.verticalInput;
        moveDirection = moveDirection + cameraObject.right * inputManager.horizentalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;

        moveDirection = moveDirection * movementSpeed;

        Vector3 movementVelocity = moveDirection;
        playerRigidbody.velocity = movementVelocity;
    }

    private void HandleRotation () {
        Vector3 targetDirection = Vector3.zero;
        targetDirection = cameraObject.forward * inputManager.verticalInput;
        targetDirection = targetDirection + cameraObject.right * inputManager.horizentalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero) 
            targetDirection = transform.forward;
        

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed* Time.deltaTime);
        transform.rotation = playerRotation;
            
    }

    public void HandleAllMovements () {
        HandleRotation();
        HandleMovement();
    }
}
