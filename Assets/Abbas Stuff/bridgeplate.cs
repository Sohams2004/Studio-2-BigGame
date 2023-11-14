using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeplate : MonoBehaviour
{
    [SerializeField] GameObject bridge;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("triggered");
        bridge.transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
