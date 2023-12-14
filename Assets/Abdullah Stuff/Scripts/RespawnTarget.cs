using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTarget : MonoBehaviour
{
    public Transform[] respawningPosition;

    // Update is called once per frame
    //void LateUpdate()
    //{
        
    //    if (gameObject.transform.position.y < -3)
    //    {
    //        Transform closetPosition  = respawningPosition[0];
    //        foreach (Transform t in respawningPosition) 
    //        {
                
    //            Vector3 newPosition = (gameObject.transform.position) -t.position;
                
    //            if (newPosition.magnitude < closetPosition.position.magnitude)
    //            {
    //                closetPosition.position = newPosition;
    //            }

    //        }
    //        transform.position = closetPosition.position;



    //    }
    //}
}
