using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseFOV : MonoBehaviour
{
   public Camera mainCamera;
    public float newFOV = 70f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (mainCamera != null)
            {
                mainCamera.fieldOfView = newFOV;
            }
        }
    }
}
