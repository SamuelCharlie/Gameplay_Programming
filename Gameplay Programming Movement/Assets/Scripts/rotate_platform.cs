using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_platform : MonoBehaviour
{
    public float rotate_speed_x;
    public float rotate_speed_y;

    void Update()
    {
        if (!PauseMenu.is_paused)
        {
            transform.Rotate(rotate_speed_x, 0, 0);
            transform.Rotate(0, rotate_speed_y, 0);
        }
    }
}
