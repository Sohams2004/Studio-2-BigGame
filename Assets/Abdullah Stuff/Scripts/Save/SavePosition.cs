using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SavePosition : MonoBehaviour, IData
{
    public enum Positions
    {
        player,
        robot1,
        robot2,
        robot3,
    }
    public Positions savePosition;
    public void LoadData(GameData data)
    {

        Transform currentPostion = this.transform;

        switch (savePosition)
        {
            case Positions.player:
                currentPostion.position = data.player;
                break;
            case Positions.robot1:
                currentPostion.position = data.robot1;
                break;
            case Positions.robot2:
                currentPostion.position = data.robot2;
                break;
            case Positions.robot3:
                currentPostion.position = data.robot3;
                break;
        }
       
    }

    public void SaveData(ref GameData data)
    {
        Transform currentPostion = this.transform;

        switch (savePosition)
        {
            case Positions.player:
                data.player = currentPostion.position;

                break;
            case Positions.robot1:
                data.robot1 = currentPostion.position;
                break;
            case Positions.robot2:
                data.robot2 = currentPostion.position;
                break;
            case Positions.robot3:
                data.robot3 = currentPostion.position;
                break;
        }

    }
}


