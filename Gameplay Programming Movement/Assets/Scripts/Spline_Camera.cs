using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spline_Camera : MonoBehaviour
{
    public GameObject spline_camera;
    public Transform player_transform;

    void Update()
    {
        spline_camera.transform.LookAt(player_transform);
    }
}
