using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//strategy
public interface PetObserver 
{
    public void Observe(PetState state);
}
