using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewGameEvent", menuName = "ScriptableObjects/EventManager", order = 1)]
public class GameEvent : ScriptableObject
{

    private List<GameEventListenere> listeners = new List<GameEventListenere>();

    public void Raise()
    {
        for(int i = listeners.Count -1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();


        }
    }

    public void RegisterListener(GameEventListenere listenere)
    {
        listeners.Add(listenere);

    }
    public void UnregisterListener(GameEventListenere listenere)
    {
        listeners.Remove(listenere);

    }



}
