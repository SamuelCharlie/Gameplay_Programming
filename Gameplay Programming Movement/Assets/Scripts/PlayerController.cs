using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    float horizontal_move = Input.GetAxis("Horizontal");
    float vertical_move = Input.GetAxis("Vertical");
    public float player_speed = 1.0f;

    private bool player_moving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (player_moving)
        {
            Vector3 movement = new Vector3(horizontal_move, 0.0f, vertical_move);
            rb.MovePosition(movement);
        }
    }
}
