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
        if (!PauseMenu.is_paused)
        {
            player_animator.SetFloat("speed", rb.velocity.magnitude / max_speed);
        }
    }
}
