using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class StateManager : MonoBehaviour
{
    [Header("index oreder Waiting>followplayer>command")]
    public State[] stateList;
    [SerializeField] private State currentState;
    public BotState botState;
    NavMeshAgent agent;
    public void Awake()
    {
        agent=GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (botState != BotState.followPlayer && agent.remainingDistance <= agent.stoppingDistance)
        {
            botState = BotState.waiting;
        }

        switch(botState)
        {
            case(BotState.waiting):
                RunStateMachine(stateList[0]);
                break;
            case (BotState.followPlayer):
                RunStateMachine(stateList[1]);
                break;
            case (BotState.commanded):
                RunStateMachine(stateList[2]);
                break;


        }


    }

    void RunStateMachine(State robotState)
    {
        currentState = robotState;
        State nextState = robotState?.RunState();

    }


}
