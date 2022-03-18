using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnim : MonoBehaviour
{
    public float rotate_speed = 0.0f;

    void Update()
    {
        if (!PauseMenu.is_paused)
        {
            transform.Rotate(rotate_speed, 0, 0);
        }
    }
}
