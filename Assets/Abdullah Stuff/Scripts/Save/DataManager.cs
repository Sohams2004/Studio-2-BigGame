using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using System.IO;
using Unity.VisualScripting;

public class DataManager : MonoBehaviour
{
    private GameData gameData;
    private List<IData> objectsWithData;
   
    
    public static DataManager instance {  get; private set; }
    private void Awake()
    {
        if (instance != null)
        {
            return;
        } 
        instance = this;
        NewGame();
    }

    private void Start()
    {
        
        this.objectsWithData = FindAllData();
    }

    private List<IData> FindAllData()
    {
        //return list
    IEnumerable<IData> objectsWithData= FindObjectsOfType<MonoBehaviour>().OfType<IData>();
        Debug.Log("Return New List");
        return new List<IData>(objectsWithData);

    }

    public void NewGame()
    {

        this.gameData = new GameData();
    }


    public void SaveGame()
    {
        foreach (IData data in objectsWithData)
        {
            data.SaveData(ref gameData);

        }

        String Json =JsonUtility.ToJson(gameData);
        Debug.Log(Json);
        File.WriteAllText(Application.dataPath+"/saveData.txt", Json);
        Debug.Log(Application.dataPath + "/saveData.txt");



    }
    public void LoadGame()
    {
        if (File.Exists(Application.dataPath + "/saveData.txt"))
        {

            string savedFile = File.ReadAllText(Application.dataPath + "/saveData.txt");
            this.gameData = JsonUtility.FromJson<GameData>(savedFile);


            foreach (IData data in objectsWithData)
            {
                data.LoadData(gameData);

            }
        }
        else return;
    }

    private void OnApplicationQuit()
    {
       // SaveGame();
    }



}
