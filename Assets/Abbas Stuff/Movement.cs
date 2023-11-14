using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed;
        }
    }
}
