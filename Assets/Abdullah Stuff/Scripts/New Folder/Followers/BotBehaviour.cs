using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BotBehaviour : MonoBehaviour
{

    CountRobots countRobots;

    // Start is called before the first frame update
    void Awake()
    {
        countRobots = GameObject.FindAnyObjectByType<CountRobots>();
    }
    private void OnEnable()
    {
        countRobots.robotsList.Remove(gameObject);
        countRobots.robotsList.Add(gameObject);

    }
    private void OnDisable()
    {
        countRobots.robotsList.Remove(gameObject);
    }


}
