using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*PlayerControls controls;
    Vector2 rotate_vector;
    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Rotate.performed += ctx => rotate_vector = ctx.ReadValue<Vector2>();
        controls.Player.Rotate.canceled += ctx => rotate_vector = Vector2.zero;
    }

    void Update()
    {
        GetComponent<Transform>().Rotate(Vector3.up * rotate_vector.x * 5.0f);
    }*/
}
