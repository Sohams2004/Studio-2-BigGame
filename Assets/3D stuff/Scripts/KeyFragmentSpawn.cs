using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFragmentSpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> keyFragments = new List<GameObject>();

    [SerializeField] public bool activeFragment;

    private void Start()
    {
        foreach (GameObject item in keyFragments)
        {
            item.SetActive(false);
        }
    }

    void spawnFragments()
    {
        if (activeFragment == true)
        {
            for (int i = 0; i < 1; i++)
            {
                int fragment = Random.Range(0, keyFragments.Count);
                keyFragments[fragment].SetActive(true);

                activeFragment = false;
            }
        }    
    }

    private void Update()
    {
        spawnFragments();
    }
}
