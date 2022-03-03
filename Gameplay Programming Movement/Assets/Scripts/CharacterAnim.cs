using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator player_animator;
    private Rigidbody rb;

    private float max_speed = 5f;
    private bool is_jumping;

    void Start()
    {
        player_animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        player_animator.SetFloat("speed", rb.velocity.magnitude / max_speed);

        if (rb.velocity.y > 0.1)
        {
            is_jumping = true;
            player_animator.SetBool("is_jumping", true);
        }

        if ((is_jumping && rb.velocity.y < 0) || rb.velocity.y < -3f)
        {
            player_animator.SetBool("is_falling", true);
        }
    }
}
