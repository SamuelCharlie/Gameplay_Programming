using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PointOfViewSwitch : MonoBehaviour
{
    private PlayerControls camera_controls;

    public GameObject close_cam;
    public GameObject mid_cam;
    public GameObject far_cam;

    public int active_cam;

    private void Awake()
    {
        camera_controls = new PlayerControls();
    }

    private void OnEnable()
    {
        camera_controls.Player.Enable();

        camera_controls.Player.POVSwitch.started += SwitchPlayerCam;
    }

    void Update()
    {
        
    }

    private void SwitchPlayerCam(InputAction.CallbackContext obj)
    {
        switch(active_cam)
        {
            case 1:
                if(close_cam)
                {
                    close_cam.SetActive(false);
                    mid_cam.SetActive(true);

                    active_cam = 2;
                }
                break;
            case 2:
                if (mid_cam)
                {
                    mid_cam.SetActive(false);
                    far_cam.SetActive(true);

                    active_cam = 3;
                }
                break;
            case 3:
                if (far_cam)
                {
                    far_cam.SetActive(false);
                    close_cam.SetActive(true);

                    active_cam = 1;
                }
                break;
        }
    }
}
