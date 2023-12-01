using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] State currentState;

    void RunStateMachine()
    {
        State nextState = currentState?.RunState();

        if(nextState != null)
        {
            GoToNextState(nextState);
        }
    }

    void GoToNextState(State nextState)
    {
        nextState = currentState;
    }

    private void Update()
    {
        RunStateMachine();
    }
}
