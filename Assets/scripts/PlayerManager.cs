using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerLocamotion playerLocamotion;
    // Start is called before the first frame update
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocamotion = GetComponent<PlayerLocamotion>();
        
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
}
