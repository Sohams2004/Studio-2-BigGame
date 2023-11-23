using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AdjustCollider : MonoBehaviour
{



    public float rayRange = 2.0f;
    public GameObject trackingObject;
    [SerializeField] private GameObject sphereProp;
    GameObject newSphere;
    int spherePropCounting;

    public enum ChangeColor
    {
        red,
        blue,
        green,
        white,
        black,
    }
    public ChangeColor changeColor = ChangeColor.white;
    Color newColor = new Color(1, 0, 0, 0.1f);
    private void OnDrawGizmos()
    {

         switch(changeColor)
        {
            case ChangeColor.red: 
            newColor = new Color(1, 0, 0, 0.1f); ;
                break;

            case ChangeColor.blue: 
            newColor = new Color(0, 0, 1, 0.1f);
                break;

            case ChangeColor.green: 
            newColor = new Color(0, 1, 0, 0.1f);
                break;

            case ChangeColor.white: 
            newColor = new Color(1, 1, 1, 0.1f);
                break;

            case ChangeColor.black: 
            newColor = new Color(0, 0, 0, 0.1f);
                break;

        }



        if (newSphere == null)
        {
            spherePropCounting = 0;

        }
        if (spherePropCounting == 0)
        {
            spherePropCounting++;

            newSphere = Instantiate(sphereProp);
            newSphere.transform.parent = trackingObject.transform;


        }
        rayRange =  Mathf.Abs( newSphere.transform.position.x - trackingObject.transform.position.x);
        newSphere.transform.position = trackingObject.transform.position + Vector3.right * rayRange;



        trackingObject.GetComponent<SphereCollider>().radius = rayRange;
        Handles.color = newColor;
        Handles.DrawSolidDisc(trackingObject.transform.position, Vector3.up, rayRange);

    }
}
