using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;
using Unity.VisualScripting;
using Unity.Mathematics;


public class MarkFollowers : MonoBehaviour
{
    public static List<GameObject> robotsList = new List<GameObject>();

    public float lineThicknes = 2.0f;
    public float radius=2f;
    public float radiusThickness = 2f;
    [SerializeField] private GameObject sphereProp;
    GameObject newSphere;
    int spherePropCounting;
    // Start is called before the first frame update

    private void OnDrawGizmos()
    {
        if (newSphere == null)
        {
            spherePropCounting = 0;

        }
        if (spherePropCounting == 0)
        {
            spherePropCounting++;

            newSphere = Instantiate(sphereProp);
            newSphere.transform.parent = gameObject.transform;


        }
        radius = Mathf.Abs(newSphere.transform.position.x - transform.position.x);
        newSphere.transform.position = transform.position + Vector3.right * radius;
        Handles.color = new Color(1, 1, 1, 0.1f);
        Handles.DrawSolidDisc(transform.position, transform.up, radius);
        Handles.color = new Color(1, 1, 0, 0.1f);
        Handles.DrawWireDisc(transform.position, transform.up, radius, radiusThickness);

        if (transform.localScale.z !=1)
        {
            gameObject.GetComponent<SphereCollider>().radius = radius;


        }
        else gameObject.GetComponent<SphereCollider>().radius = radius;


        foreach (GameObject robotsFollowers in robotsList)
        {
            float distanace = Vector3.Distance(robotsFollowers.transform.position, transform.position);
            if (distanace < radius) { 

            float halfway = (transform.position.y - robotsFollowers.transform.position.y);
            Vector3 offset = Vector3.up * halfway;

                Handles.color = new Color(1, 0, 0, 0.5f);
                Handles.DrawBezier(transform.position, robotsFollowers.transform.position,
            transform.position - offset, robotsFollowers.transform.position + offset,
            Color.white, EditorGUIUtility.whiteTexture, lineThicknes);

            }
        }
    }



}
