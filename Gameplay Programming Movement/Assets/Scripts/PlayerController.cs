using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private float x_move = 0.0f;
    private float y_move = 0.0f;
    private float x_max_velocity = 40.0f;
    private float y_max_velocity = 40.0f;

    public float player_speed = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue move_value)
    {
        Vector2 move_vector = move_value.Get<Vector2>();

        x_move = move_vector.x;
        y_move = move_vector.y;
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3(x_move, 0.0f, y_move);
        rb.AddForce(move * player_speed);

        if (rb.velocity.x >= x_max_velocity)
        {
            Debug.Log("x too fast");
            rb.velocity = new Vector3(x_max_velocity, rb.velocity.y, rb.velocity.z);
        }

        if (rb.velocity.y >= y_max_velocity)
        {
            Debug.Log("y too fast");
            rb.velocity = new Vector3(rb.velocity.x, y_max_velocity, rb.velocity.z);
        }
    }
}