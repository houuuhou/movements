using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerLocamotion playerLocamotion;
    CameraManager cameraManager;
    // Start is called before the first frame update
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocamotion = GetComponent<PlayerLocamotion>();
        cameraManager = FindAnyObjectByType<CameraManager>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        inputManager.HandleAllInputs(); 
    }
    private void FixedUpdate()
    {
        playerLocamotion.HandleAllMovements();
    }
    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
    }
}
