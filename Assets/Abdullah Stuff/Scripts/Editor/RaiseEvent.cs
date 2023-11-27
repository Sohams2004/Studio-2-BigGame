using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(GameEvent))]
public class RaiseEvent : Editor
{
    GameEvent selected;
    List<GameEventListenere> listofListenere;

    public override void OnInspectorGUI()
    {
        GUILayout.Label("StartEvent");
        selected = (GameEvent)target;
        if(GUILayout.Button("Raise Event"))
            {
            Debug.Log("Raise "+ selected);
            selected.Raise();       

        }
 
         




    }





}
