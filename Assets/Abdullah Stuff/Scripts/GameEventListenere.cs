using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListenere : MonoBehaviour
{
    // Start is called before the first frame update
public GameEvent Event;
public UnityEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }
    private void OnDisable()
    {
        Event.UnregisterListener(this); 
    }
    public void OnEventRaised()
    {
        Response.Invoke();

    }

}
