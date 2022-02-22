using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SecondPlayerController : MonoBehaviour
{
    //PlayerControls controls;
    Vector2 move_vector;

    void Awake()
    {
        //controls = new PlayerControls();
        //controls.Player.Buttons.performed += context => SendMessage();
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
       // controls.Player.Enable();
    }

    private void OnDisable()
    {
       // controls.Player.Disable();
    }

    void SendMessage()
    {
        Debug.Log("Button Pressed");
    }
}
