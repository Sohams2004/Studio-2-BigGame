using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    [SerializeField] float rotationSpeed;

    void RotateDome()
    {
        gameObject.transform.Rotate(0,1 * rotationSpeed,0); 
    }

    private void Update()
    {
        RotateDome();
    }
}
