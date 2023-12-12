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
        Debug.Log("casting Ray");
        Physics.Raycast(cameraRay, out  RaycastHit  hitInfo, Mathf.Infinity,~8, QueryTriggerInteraction.Ignore);
        GameObject robot = hitInfo.transform.gameObject;

        if (robot.GetComponent<StateManager>() != null)
        {
            robot.GetComponent<StateManager>().botState = BotState.followPlayer;
            robot.GetComponent<BoidsBehaviour>().enabled = true;
        }
    }
}
