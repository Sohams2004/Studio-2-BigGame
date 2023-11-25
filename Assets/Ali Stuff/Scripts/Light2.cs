using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light2 : MonoBehaviour
{
    public Image imageToChange; // Reference to the UI image

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ChangeImageColor();
        }
    }

    private void ChangeImageColor()
    {
        imageToChange.color = Color.green;
    }
}
