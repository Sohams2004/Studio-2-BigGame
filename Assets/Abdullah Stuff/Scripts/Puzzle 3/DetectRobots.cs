using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteAlways]
public class DetectRobots : MonoBehaviour
{

    void OnEnable()
    {
        MarkFollowers.robotsList.Add(gameObject);
        Debug.Log("Added Robot");
    }

    void OnDisable()
    {
        MarkFollowers.robotsList.Remove(gameObject);
        Debug.Log("Removed Robot");
    }




}
