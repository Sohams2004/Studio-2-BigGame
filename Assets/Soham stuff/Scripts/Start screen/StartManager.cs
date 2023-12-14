using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartManager : MonoBehaviour
{
    [SerializeField] GameObject startTransition;
    [SerializeField] GameObject endTransition;

    private void Start()
    {
       // startTransition = GameObject.FindGameObjectWithTag("Start Transition");
       // endTransition = GameObject.FindGameObjectWithTag("End Transition");
    }

    /*void StartGame()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex+1);
        }
    }*/

    void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    IEnumerator StartTransition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Transitioned");
            startTransition.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1);
            endTransition.SetActive(true);
            startTransition.SetActive(false);      
        }
    }

    private void Update()
    { 
        //Invoke("StartGame", 1f);
        QuitGame();
        StartCoroutine(StartTransition());
    }
}
