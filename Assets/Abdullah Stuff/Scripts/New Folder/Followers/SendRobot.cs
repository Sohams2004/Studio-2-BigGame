using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRobot : MonoBehaviour
{
    public CountRobots countRobots;
    Voltage voltage;
    // Start is called before the first frame update
    void Start()
    { if (countRobots == null)
        {
            countRobots= GameObject.FindAnyObjectByType<CountRobots>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            SendBot(Voltage.Voltag1);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            SendBot(Voltage.Voltag2);

        }
         if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            SendBot(Voltage.Voltag3);

        }
    }
    void SendBot(Voltage findVoltage)
    {
       
        foreach (GameObject robot in countRobots.robotsList)
        {
            var voltageType = robot.GetComponent<BotVoltage>().RobotVoltage;
            if (findVoltage == voltageType)
            {
                // -------Soham Script goes here---------

                
                robot.GetComponent<StateManager>().botState = BotState.commanded;
                robot.GetComponent<CommandFollow>().Command();

                // -------Soham Script goes here---------

                Debug.Log("SendRobot: " + voltageType);
                robot.GetComponent<BotBehaviour>().enabled = false;
                return;

            }
          
            

        }
        Debug.Log("No robot of Type: " + findVoltage);


    }


}
