using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3d : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    [SerializeField] private Rigidbody playerRb;

    private void FixedUpdate()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputy = Input.GetAxis("Jump");
        float inputz = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementSpeed * inputx, 0,movementSpeed * inputz) * Time.deltaTime;
        transform.Translate(movement);
    }
}