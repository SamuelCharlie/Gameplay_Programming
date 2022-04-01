using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public List<Transform> waypoints;
    public float platform_move_speed;
    public int target;

    private void Update()
    {
        if (!PauseMenu.is_paused)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[target].position,
                platform_move_speed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        if (transform.position == waypoints[target].position)
        {
            if(target == waypoints.Count -1)
            {
                target = 0;
            }
            else
            {
                target += 1;
            }
        }
    }
}
