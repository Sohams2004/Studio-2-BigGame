using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[ExecuteAlways]
public class BotBehaviour : MonoBehaviour
{

    CountRobots countRobots;
    public GameObject player; 

    // Start is called before the first frame update
    void Awake()
    {
        countRobots = GameObject.FindAnyObjectByType<CountRobots>();
    }
    private void Update()
    {
        //countRobots.gameObject.GetComponent<Rigidbody>().velocity;

    }
    void SepratingForce()
    {

    }
    void SeekingForce()
    {

    }

    void AddingForce()
    {
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
