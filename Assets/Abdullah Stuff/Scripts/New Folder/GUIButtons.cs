using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIButtons : MonoBehaviour
{
    /// Start
    /// options
    /// Blahh
    /// exist
    
    private void OnGUI()
    {

        var position = new Rect(0, 0, 50, 50);

        GUI.Button(position, "Start");
        position.y+= 60;
        GUI.Label(position, "Options");
        position.y += 20;
        GUI.Label(position, "Blahh");
        position.y += 20;
        GUI.Label(position, "Exist");
        position.y += 20;
        GUI.Label(position, "Start");



    }

}
