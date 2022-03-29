using UnityEngine;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float player_speed = 5;
        float distanceTravelled;

        public Rigidbody rb;
        private Vector3 player_velocity;
        private Vector3 player_movement;
        private Vector2 move_vector;
        private Vector2 rotate_vector;

        PlayerControls controls;
        public CharacterController controller;
        private float gravity;

        private bool in_spline;

        void Awake() 
        {
            controls = new PlayerControls();
            rb = GetComponent<Rigidbody>();

            controls.Player.Move.performed += ctx => move_vector = ctx.ReadValue<Vector2>();
            controls.Player.Move.canceled += ctx => move_vector = Vector2.zero;

            controls.Player.Rotate.performed += ctx => rotate_vector = ctx.ReadValue<Vector2>();
            controls.Player.Rotate.canceled += ctx => rotate_vector = Vector2.zero;

            if (pathCreator != null)
            {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
            }
        }

        void Update()
        {
            Move();

            if (pathCreator != null)
            {
                distanceTravelled += player_speed * Time.deltaTime;
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                //transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, EndOfPathInstruction.Stop);
                //transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
            }
        }

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged()
        {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }

        private void OnTriggerEnter(Collider other)
        {
            in_spline = true;
        }

        private void Move()
        {
            if (player_velocity.x == 0 && player_velocity.y == 0)
            {
                //player_animator.SetTrigger("IsIdle");
            }
            else if (player_velocity.x != 0 || player_velocity.y != 0)
            {
                //player_animator.SetTrigger("IsGrounded");

                Vector3 movement = new Vector3(move_vector.x, 0.0f, move_vector.y) * player_speed *
                Time.deltaTime;
                player_movement = movement;
                player_movement = transform.TransformDirection(movement);
                transform.Translate(movement, Space.World);
            }
            controller.Move(player_movement * player_speed * Time.deltaTime);

            player_velocity.y += gravity * Time.deltaTime;
            controller.Move(player_velocity * Time.deltaTime);
        }
    }
}