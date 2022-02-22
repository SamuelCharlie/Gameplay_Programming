using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnim : MonoBehaviour
{
    public float rotate_speed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotate_speed, 0, 0);
    }
}
