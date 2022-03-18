using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    public Animator player_animator;

    public Animator right_door_animator;
    public Animator left_door_animator;

    public GameObject main_camera;
    public GameObject cutscene_camera;

    private bool door_open = false;
    public static bool in_cutscene = false;

    private void OnTriggerStay(Collider other)
    {
        SecondPlayerController.in_trigger = true;

        if (!door_open)
        {
            if (SecondPlayerController.is_interacting && SecondPlayerController.in_trigger)
            {
                player_animator.SetTrigger("IsAttacking");
                StartCoroutine(DoorOpenCutscene());
            }
        }
        if (door_open)
        {
            if (SecondPlayerController.is_interacting && SecondPlayerController.in_trigger)
            {
                player_animator.SetTrigger("IsAttacking");
                StartCoroutine(DoorClosedCutscene());
            }
        }
    }
    IEnumerator DoorOpenCutscene()
    {
        Debug.Log("In cutscene");
        in_cutscene = true;

        main_camera.SetActive(false);
        cutscene_camera.SetActive(true);

        right_door_animator.SetBool("IsOpen", true);
        left_door_animator.SetBool("IsOpen", true);

        SecondPlayerController.is_interacting = false;
        door_open = true;

        yield return new WaitForSeconds(2.5f);

        in_cutscene = false;
        cutscene_camera.SetActive(false);
        main_camera.SetActive(true);
    }

    IEnumerator DoorClosedCutscene()
    {
        in_cutscene = true;

        main_camera.SetActive(false);
        cutscene_camera.SetActive(true);

        right_door_animator.SetBool("IsOpen", false);
        left_door_animator.SetBool("IsOpen", false);

        SecondPlayerController.is_interacting = false;
        door_open = false;

        yield return new WaitForSeconds(2.5f);

        in_cutscene = false;
        cutscene_camera.SetActive(false);
        main_camera.SetActive(true);
    }
}
