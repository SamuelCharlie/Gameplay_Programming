using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SecondPlayerController : MonoBehaviour
{
    PlayerControls controls;
    Vector2 move_vector;
    Vector2 rotate_vector;

    //private Animator player_animator;

    public float player_speed = 10;
    public float rotation_speed = 10;
    private Vector3 player_velocity;

    private enum FacingDirection { North, East, South, West}
    FacingDirection facing = FacingDirection.South;
    private Vector3 prev_player_velocity;

    void Awake()
    {
        //player_animator = GetComponent<Animator>();
        controls = new PlayerControls();

        controls.Player.Move.performed += ctx => move_vector = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move_vector = Vector2.zero;

    }

    void FixedUpdate()
    {
        Debug.Log(new Vector3(move_vector.x, 0.0f, move_vector.y));
        Vector3 movement = new Vector3(move_vector.x, 0.0f, move_vector.y) * player_speed *
        Time.deltaTime;
        transform.Translate(movement, Space.World);

        if (move_vector.x != 0 || move_vector.y != 0)
        {
            //player_animator.SetBool("is_moving", true);
        }
        else if (move_vector.x == 0 || move_vector.y == 0)
        {
            //player_animator.SetBool("is_moving", false);
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

    private void CheckForFacingDirectionChange()
    {
        if (player_velocity == Vector3.zero)
        {
            return;
        }

        if(player_velocity.x == 0 || player_velocity.z == 0)
        {
            ChangeFacingDirection(player_velocity);
        }
        else
        {
            if(prev_player_velocity.x == 0)
            {
                ChangeFacingDirection(new Vector3(player_velocity.x, 0, 0));
            }
            else if (prev_player_velocity.z == 0)
            {
                ChangeFacingDirection(new Vector3(0, 0, prev_player_velocity.z));
            }
            else
            {
                Debug.LogWarning("Unexpected player_velocity value");
                ChangeFacingDirection(player_velocity);
            }
        }
    }

    private void ChangeFacingDirection(Vector3 dir)
    {
        if (dir.z != 0)
        {
            facing = (dir.z > 0) ? FacingDirection.North : FacingDirection.South;
        }
        if (dir.x != 0)
        {
            facing = (dir.x > 0) ? FacingDirection.East : FacingDirection.West;
        }

        transform.localRotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player_velocity), rotation_speed * Time.deltaTime);
    }

    private void LateUpdate()
    {
        if (prev_player_velocity != player_velocity)
        {
            CheckForFacingDirectionChange();
        }
    }
}
