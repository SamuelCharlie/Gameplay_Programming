using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SecondPlayerController : MonoBehaviour
{
    PlayerControls controls;
    Vector2 rotate_vector;
    Vector2 move_vector;

    public CharacterController controller;
    private Animator player_animator;

    public float player_speed;
    //public float rotation_speed;
    [SerializeField]private Vector3 player_velocity;
    private Vector3 player_movement;

    [SerializeField] private bool is_grounded;
    [SerializeField] private float ground_distance_check;
    [SerializeField] private LayerMask ground_mask;
    [SerializeField] private float gravity;

    [SerializeField] private float jump_height;
    private bool is_jumping;

    [SerializeField] private float boost_timer;
    [SerializeField] private bool is_boosting;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Move.performed += ctx => move_vector = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move_vector = Vector2.zero;

        controls.Player.Rotate.performed += ctx => rotate_vector = ctx.ReadValue<Vector2>();
        controls.Player.Rotate.canceled += ctx => rotate_vector = Vector2.zero;

        controls.Player.PlayerJump.performed += ctx => Jump();

    }

    void FixedUpdate()
    {
        Move();
        GetComponent<Transform>().Rotate(Vector3.up * rotate_vector.x * 5.0f);

        if(is_boosting)
        {
            boost_timer += Time.deltaTime;
            if (boost_timer >= 3)
            { 
                player_speed = 20;
                boost_timer = 0;
                is_boosting = false;
            }
        }
    }
    private void Move()
    {
        is_grounded = Physics.CheckSphere(transform.position, ground_distance_check, ground_mask);

        if (is_grounded && player_velocity.y < 0)
        {
            player_velocity.y = -2.0f;
        }

        if (is_grounded)
        {
            Debug.Log(new Vector3(move_vector.x, 0.0f, move_vector.y));
            Vector3 movement = new Vector3(move_vector.x, 0.0f, move_vector.y) * player_speed *
            Time.deltaTime;
            player_movement = movement;
            player_movement = transform.TransformDirection(movement);
            transform.Translate(movement, Space.World);

            //player_animator.SetBool("is_jumping", false);
            //is_jumping = false;
            //player_animator.SetBool("is_falling", false);
        }
        //else if (!is_grounded)
        //{
            //player_animator.SetBool("is_jumping", true);
            //is_jumping = true;
            //player_animator.SetBool("is_grounded", false);
            //is_grounded = false;
        //}

        controller.Move(player_movement * player_speed * Time.deltaTime);

        player_velocity.y += gravity * Time.deltaTime;
        controller.Move(player_velocity * Time.deltaTime);

        //if ((is_jumping && player_velocity.y < 0) || player_velocity.y < -2)
        //{
            //player_animator.SetBool("is_falling", true);
        //}
    }

    private void Jump()
    {
        Debug.Log("Jump");
        player_velocity.y = Mathf.Sqrt(jump_height * -2 * gravity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpeedBoost")
        {
            is_boosting = true;
            player_speed = 30;
            Destroy(other.gameObject);
        }
    }

    private void OnEnable()
    {
       controls.Player.Enable();
    }

    private void OnDisable()
    {
       controls.Player.Disable();
    }

    void SendMessage(Vector2 coordinates)
    {
        Debug.Log("Thumb-stick coordinates = " + coordinates);
    }
}
