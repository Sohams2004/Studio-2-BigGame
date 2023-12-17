using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] GameObject startTransition;

    [SerializeField] AudioSource clickSound;
    private void Start()
    {
        clickSound = FindObjectOfType<AudioSource>();
    }


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            StartCoroutine(StartTransition());

        }

    }
    IEnumerator StartTransition()
    {
        Debug.Log("Transitioned");
        clickSound.Play();
        startTransition.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
        startTransition.SetActive(false);
    }

}
