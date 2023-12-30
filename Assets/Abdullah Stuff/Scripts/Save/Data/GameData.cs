using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public Vector3 player;
    public Vector3 robot1;
    public Vector3 robot2;
    public Vector3 robot3;


    public GameData()
    {

        player = Vector3.zero;
        robot1 = Vector3.zero;
        robot2 = Vector3.zero;
        robot3 = Vector3.zero;


    }


}
