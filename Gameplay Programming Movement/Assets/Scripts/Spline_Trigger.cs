using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spline_Trigger : MonoBehaviour
{
    PathCreation.Examples.PathFollower path_follower;
    SecondPlayerController second_player_controller;

    public GameObject player;

    public GameObject current_camera;
    private bool in_spline;

    public GameObject spline_camera;

    private void Awake()
    {
        path_follower = player.GetComponent<PathCreation.Examples.PathFollower>();
    }
    private void OnTriggerExit(Collider other)
    {
        /*if (in_spline)
        {
            in_spline = false;

            path_follower.enabled = false;

            current_camera.SetActive(true);
            spline_camera.SetActive(false);
        }*/

        if (!in_spline) 
        {
            in_spline = true;

            path_follower.enabled = true;
            second_player_controller.enabled = false;

            current_camera.SetActive(false);
            spline_camera.SetActive(true);
        }
    }
}
