using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleCharging : MonoBehaviour
{
    public int chargeCounter;
    [Range(1f, 10f)]
    public int voltageNeeded;
    public GameEvent sendEvent;
    bool isFull=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BotVoltage>())
        {
            var currentRobot = other.GetComponent<BotVoltage>();
            AddCharge((int)currentRobot.RobotVoltage+1);
            Debug.Log("Entered");

        }



    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        if (other.GetComponent<BotVoltage>())
        {
            var currentRobot = other.GetComponent<BotVoltage>();
            //charge robot
            AddCharge((1+(int)currentRobot.RobotVoltage) * -1);
        }



    }

    private void AddCharge(int number)
    {
        chargeCounter += number;

        CheckCharges(chargeCounter);


    }
    private void CheckCharges(int number)
    {

        if (number >= voltageNeeded)
        {
            if (sendEvent==null)
            {
                isFull = true;
                Debug.LogWarning("There is no Event to trigger");
                return;
            }
            sendEvent.Raise();
            isFull = true;
        }


    }



}
