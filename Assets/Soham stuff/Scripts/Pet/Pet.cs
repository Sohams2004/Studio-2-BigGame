using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pet : MonoBehaviour
{
    [SerializeField] List<PetObserver> observers = new List<PetObserver>();

    public void AddObservers(PetObserver state)
    {
        observers.Add(state);
    }

    public void DeleteObserver(PetObserver state)
    {
        observers.Remove(state);
    }
    
    public void GetObserver(PetState state)
    {
        foreach (PetObserver observer in observers)
        {
            observer.Observe(state);
        }
    }
}
