using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecalRobot : MonoBehaviour
{
    Ray cameraRay;
    [SerializeField] Camera camera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            FollowPlayer();
        }
    }

    private void FollowPlayer()
    {
        cameraRay = camera.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(cameraRay, out  RaycastHit  hitInfo, 12, ~8, QueryTriggerInteraction.Ignore);
        GameObject robot = hitInfo.transform.gameObject;

        if (robot.GetComponent<StateManager>() != null)
        {
            robot.GetComponent<StateManager>().botState = BotState.followPlayer;
            robot.GetComponent<BotBehaviour>().enabled = true;
        }
    }
}
