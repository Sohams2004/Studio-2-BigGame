using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] int pauseIndex;

    [SerializeField] AudioSource buttonSelectAudio;

    void Start()
    {
        //pausePanel = GameObject.FindGameObjectWithTag("Pause Panel");
        Time.timeScale = 1.0f;
        pausePanel.SetActive(false);
    }

    void Pause()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            pauseIndex++;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && pauseIndex % 2 == 0)
        {
            Time.timeScale = 1f;
            pausePanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseIndex++;
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ButtonSelectSound()
    {
        Debug.Log("Beep");
        buttonSelectAudio.Play();
    }

    private void Update()
    {
        Pause();
    }
}
