using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SecondPlayerController : CharacterManager
{
    PlayerControls controls;
    Vector2 rotate_vector;
    Vector2 move_vector;

    public Transform target_transform;
    public Transform camera_transform;

    public CharacterController controller;
    public static Rigidbody rb;
    private Animator player_animator;

    public float player_speed;
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

    public static bool is_interacting;
    public static bool in_trigger;
    [SerializeField] private float interaction_timer;

    public bool is_locking_on;
    public bool lock_on_input;
    public bool lock_on_flag;

    public Transform current_lock_on_target;

    List<CharacterManager> available_targets = new List<CharacterManager>();
    public Transform nearest_lock_on_target;
    public float maximum_lock_on_distance = 30;

    void Awake()
    {
        controls = new PlayerControls();
        player_animator = this.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        controls.Player.Move.performed += ctx => move_vector = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move_vector = Vector2.zero;

        controls.Player.Rotate.performed += ctx => rotate_vector = ctx.ReadValue<Vector2>();
        controls.Player.Rotate.canceled += ctx => rotate_vector = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Player.Enable();
        controls.Player.PlayerJump.started += DoJump;
        controls.Player.PlayerAttack.started += DoAttack;
        controls.Player.PlayerInteract.started += DoInteract;
        controls.Player.LockOn.started += DoLockOn;
    }

    private void OnDisable()
    {
        controls.Player.Disable();
        controls.Player.PlayerJump.started -= DoJump;
        controls.Player.PlayerAttack.started -= DoAttack;
        controls.Player.PlayerInteract.started -= DoInteract;
        controls.Player.LockOn.started -= DoLockOn;
    }

    void FixedUpdate()
    {
        if (!PauseMenu.is_paused)
        {
            Move();

            if (!is_locking_on)
            {
                GetComponent<Transform>().Rotate(Vector3.up * rotate_vector.x * 5.0f);
            }
            else if (is_locking_on)
            {
                Vector3 dir = current_lock_on_target.position - transform.position;

                dir.Normalize();
                dir.y = 0;

                Quaternion target_rotation = Quaternion.LookRotation(dir);
                transform.rotation = target_rotation;

                dir = current_lock_on_target.position - camera_transform.position;
                dir.Normalize();

                target_rotation = Quaternion.LookRotation(dir);
                Vector3 euler_angle = target_rotation.eulerAngles;
                euler_angle.y = 0;
                camera_transform.localEulerAngles = euler_angle;
            }


            if (is_boosting)
            {
                boost_timer += Time.deltaTime;
                if (boost_timer >= 3)
                {
                    player_speed = 20;
                    boost_timer = 0;
                    is_boosting = false;
                }
            }

            interaction_timer += Time.deltaTime;
        }
    }
    private void Move()
    {
        is_grounded = Physics.CheckSphere(transform.position, ground_distance_check, ground_mask);

        if (is_grounded && player_velocity.y < 0)
        {
            player_velocity.y = -2.0f;
        }

        if (is_grounded && !DoorAnim.in_cutscene)
        {
            if (player_velocity.x == 0 && player_velocity.y == 0)
            {
                player_animator.SetTrigger("IsIdle");
            }
            else if(player_velocity.x != 0 || player_velocity.y != 0)
            {
                player_animator.SetTrigger("IsGrounded");

                Vector3 movement = new Vector3(move_vector.x, 0.0f, move_vector.y) * player_speed *
                Time.deltaTime;
                player_movement = movement;
                player_movement = transform.TransformDirection(movement);
                transform.Translate(movement, Space.World);
            }
        }

        controller.Move(player_movement * player_speed * Time.deltaTime);

        player_velocity.y += gravity * Time.deltaTime;
        controller.Move(player_velocity * Time.deltaTime);
    }

    private void Jump()
    {
        Debug.Log("Jump");
        player_velocity.y = Mathf.Sqrt(jump_height * -2 * gravity);
        is_jumping = true;
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

    void SendMessage(Vector2 coordinates)
    {
        Debug.Log("Thumb-stick coordinates = " + coordinates);
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        is_jumping = true;

        player_animator.SetTrigger("IsJumping");
        player_velocity.y = Mathf.Sqrt(jump_height * -2 * gravity);
        player_animator.SetTrigger("IsFalling");
    }

    private void DoAttack(InputAction.CallbackContext obj)
    {
        player_animator.SetTrigger("IsAttacking");
    }

    private void DoInteract(InputAction.CallbackContext obj)
    {
        if(in_trigger)
        {
            player_animator.SetTrigger("IsInteracting");

            is_interacting = true;
        }
    }

    public void HandleLockOn()
    {
        float shortest_distance = Mathf.Infinity;

        Collider[] colliders = Physics.OverlapSphere(target_transform.position, 26);

        for (int i = 0; i < colliders.Length; i++)
        {
            CharacterManager character = colliders[i].GetComponent<CharacterManager>();

            if (character != null)
            {
                Vector3 lock_target_direction = character.transform.position - target_transform.position;
                float distance_from_target = Vector3.Distance(target_transform.position, character.transform.position);
                float viewable_angle = Vector3.Angle(lock_target_direction, camera_transform.forward);

                if (character.transform.root != target_transform.transform.root 
                    && viewable_angle > -50 && viewable_angle < 50 
                    && distance_from_target <= maximum_lock_on_distance)
                {
                    available_targets.Add(character);
                }
            }
        }

        for (int k = 0; k < available_targets.Count; k++)
        {
            float distance_from_target = Vector3.Distance(target_transform.position, available_targets[k].transform.position);

            if (distance_from_target < shortest_distance)
            {
                shortest_distance = distance_from_target;
                nearest_lock_on_target = available_targets[k].lock_on_transform;
            }
        }
    }

    private void DoLockOn(InputAction.CallbackContext obj)
    {

        if (is_locking_on)
        {
            is_locking_on = false;
        }
        else if (!is_locking_on)
        {
            is_locking_on = true;
        }

        /*if (lock_on_input && lock_on_flag == false)
        {
            ClearLockOnTargets();
            lock_on_input = false;
            HandleLockOn();

            if (nearest_lock_on_target != null)
            {
                current_lock_on_target = nearest_lock_on_target;
                lock_on_flag = true;
            }
        }
        else if (lock_on_input && lock_on_flag)
        {
            lock_on_input = false;
            lock_on_flag = false;
            ClearLockOnTargets();
        }*/
    }

    public void ClearLockOnTargets()
    {
        available_targets.Clear();
        nearest_lock_on_target = null;
        current_lock_on_target = null; 
    }
}
