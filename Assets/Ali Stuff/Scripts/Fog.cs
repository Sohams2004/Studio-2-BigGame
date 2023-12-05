using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RenderSettings.fogDensity = .03f;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            RenderSettings.fogDensity = .4f;
        }
    }
}
