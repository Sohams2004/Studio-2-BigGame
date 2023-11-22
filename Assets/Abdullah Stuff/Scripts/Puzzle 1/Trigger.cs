using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameEvent gameEvent;
    // Start is called before the first frame update
    void Start()
    {


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
            gameEvent.Raise();
        }

    }


}
