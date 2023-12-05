using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecalRobot : MonoBehaviour
{
    Ray cameraRay;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            FollowPlayer();
        }
    }

    private void FollowPlayer()
    {
        cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(cameraRay, out RaycastHit hitInfo, Mathf.Infinity);
        GameObject robot = hitInfo.transform.gameObject;

        if (robot.GetComponent<StateManager>() != null)
        {
            robot.GetComponent<StateManager>().botState = BotState.followPlayer;
            robot.GetComponent<BoidsBehaviour>().enabled = true;
        }
    }
}
