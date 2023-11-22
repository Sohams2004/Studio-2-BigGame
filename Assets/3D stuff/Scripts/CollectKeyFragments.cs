using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeyFragments : MonoBehaviour
{
    [SerializeField] KeyFragmentSpawn keyFragmentSpawn;

    [SerializeField] bool keyFragment1, keyFragment2, keyFragment3;

    [SerializeField] int keyCollected;

    private void Start()
    {
        keyFragmentSpawn = FindObjectOfType<KeyFragmentSpawn>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);

            keyFragmentSpawn.activeFragment = true;

            keyFragment1 = true;

            keyCollected++;
        }    
    }
}
