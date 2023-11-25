using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    Ray ray;

    [SerializeField] float rayLength = 5f;

    [SerializeField] LayerMask consoleMask;

    [SerializeField] TextMeshProUGUI pressEtext;

    //[SerializeField] Material consoleHighlightMaterial;


    private void Start()
    {
        pressEtext.enabled = false;
    }

    void DetectObjects()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitObject, rayLength, consoleMask))
        {
            Debug.Log(hitObject.collider.gameObject.name);
            pressEtext.enabled = true;
            //consoleHighlightMaterial.color = Color.red;
        }

        else
        {
            pressEtext.enabled = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.forward * rayLength);
    }

    private void Update()
    {
        DetectObjects();
    }
}
