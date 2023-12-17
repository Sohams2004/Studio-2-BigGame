using UnityEngine;
using UnityEngine.SceneManagement;

public class AliEndLevel : MonoBehaviour
{
     [SerializeField] private bool isReached;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Win");

            isReached = true;
        }

        if(other.gameObject.CompareTag("Pet") && isReached)
        {

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1);

            isReached = false;
        }
    }
}
