using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator player_animator;
    private Rigidbody rb;

    [SerializeField] private float ground_distance_check;
    [SerializeField] private LayerMask ground_mask;

    private float max_speed = 5f;

    void Start()
    {
        player_animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        player_animator.SetFloat("speed", rb.velocity.magnitude / max_speed);

        /*if (rb.velocity.y == 0)
        {
            player_animator.SetBool("is_grounded", true);
            is_grounded = true;
            player_animator.SetBool("is_jumping", false);
            is_jumping = false;
            player_animator.SetBool("is_falling", false);
        }

        if (is_grounded)
        {
            Debug.Log("char anim: " + is_grounded);
        }

        if (rb.velocity.y > 0.1 && !is_grounded)
        {
            player_animator.SetBool("is_jumping", true);
            is_jumping = true;
            player_animator.SetBool("is_grounded", false);
            is_grounded = false;
        }

        if ((is_jumping && rb.velocity.y < 0 && !is_grounded) || (rb.velocity.y < -3f && !is_grounded))
        {
            player_animator.SetBool("is_falling", true);
        }*/
    }
}
