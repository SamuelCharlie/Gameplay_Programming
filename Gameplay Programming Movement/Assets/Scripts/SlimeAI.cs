using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlimeAI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask what_is_ground, what_is_player;

    public Vector3 walk_point;
    bool walk_point_set;
    public float walk_point_range;

    public float attack_interval;
    bool already_attacked;

    public float sight_range, attack_range;
    public bool player_in_sight_range, player_in_attack_range;
    public float object_health;

    private void Awake()
    {
        player = GameObject.Find("RPG-Character").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        player_in_sight_range = Physics.CheckSphere(transform.position, sight_range, what_is_player);
        player_in_attack_range = Physics.CheckSphere(transform.position, attack_range, what_is_player);

        if (!player_in_sight_range && !player_in_attack_range) PatrolArea();
        if (player_in_sight_range && !player_in_attack_range) ChasePlayer();
        if (player_in_sight_range && player_in_attack_range) AttackPlayer();
    }

    private void PatrolArea()
    {
        if (!walk_point_set) SearchWalkPoint();
        if (walk_point_set) agent.SetDestination(walk_point);

        Vector3 distance_to_walk_point = transform.position - walk_point;
        if (distance_to_walk_point.magnitude < 1.0f) walk_point_set = false;
    }

    private void SearchWalkPoint()
    {
        float random_x = Random.Range(-walk_point_range, walk_point_range);
        float random_z = Random.Range(-walk_point_range, walk_point_range);

        walk_point = new Vector3(transform.position.x + random_x, transform.position.y, transform.position.z + random_z);

        if (Physics.Raycast(walk_point, -transform.up, 2.0f, what_is_ground)) walk_point_set = true;
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player);
        if (!already_attacked)
        {
            //Combat code

            already_attacked = true;
            Invoke(nameof(ResetAttack), attack_interval);
        }
    }

    private void ResetAttack()
    {
        already_attacked = false;
    }

    public void ObjectHit(int damage_dealt)
    {
        object_health -= damage_dealt;

        if (object_health <= 0) Invoke(nameof(DestroyObject), 0.5f);
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
