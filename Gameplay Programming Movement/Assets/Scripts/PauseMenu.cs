using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause_menu;
    public GameObject inventory;
    private PlayerControls controls;

    public static bool is_paused = false;
    private bool in_inventory = false;

    private void Awake()
    {
        controls = new PlayerControls();
        pause_menu.SetActive(false);
        inventory.SetActive(false);
    }

    private void OnEnable()
    {
        controls.Player.Enable();

        controls.Player.PauseMenu.started += DoPause;
        controls.Player.PlayerInventory.started += DoInventory;
    }

    private void OnDisable()
    {
        controls.Player.Disable();

        controls.Player.PauseMenu.started -= DoPause;
        controls.Player.PlayerInventory.started -= DoInventory;
    }

    private void DoPause(InputAction.CallbackContext obj)
    {
        if (!is_paused)
        {
            Debug.Log("Paused");

            pause_menu.SetActive(true);
            Time.timeScale = 0.0f;
            is_paused = true;
        }
        else if (is_paused)
        {
            Debug.Log("Resume");

            pause_menu.SetActive(false);
            Time.timeScale = 1.0f;
            is_paused = false;
        }
    }

    private void DoInventory(InputAction.CallbackContext obj)
    {
        if (!in_inventory)
        {
            Debug.Log("In Inventory");

            inventory.SetActive(true);
            in_inventory = true;
        }
        else if (in_inventory)
        {
            Debug.Log("Resume Inventory");

            inventory.SetActive(false);
            in_inventory = false;
        }
    }
}
