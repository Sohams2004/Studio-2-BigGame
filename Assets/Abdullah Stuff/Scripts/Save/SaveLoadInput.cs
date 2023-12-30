using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadInput : MonoBehaviour
{


    private void OnGUI()
    {

        GUILayout.BeginVertical();
        
        if (GUILayout.Button("SaveFile F5", GUILayout.ExpandWidth(false),GUILayout.Height(100)))
        {

            //saveMethod

            DataManager.instance.SaveGame();


        }
        GUILayout.Space(10);
        if (GUILayout.Button("LoadFile F6", GUILayout.ExpandWidth(false),GUILayout.Height(100)))
        {

            //LoadMethod            

            DataManager.instance.LoadGame();
        }



    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5))
        {
            DataManager.instance.SaveGame();
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            DataManager.instance.LoadGame();

        }






    }


}