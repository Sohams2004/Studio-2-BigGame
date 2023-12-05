using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameEvent gameEvent;
    // Start is called before the first frame update
private void TriggerMyEvent()
    {
        gameEvent.Raise();

    }



}
