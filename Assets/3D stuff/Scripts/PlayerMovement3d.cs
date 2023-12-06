using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement3d : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] float jumpForce;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float gravityScale;

    [SerializeField] bool isGrounded;

    [SerializeField] private Rigidbody playerRb;



    private void FixedUpdate()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputy = Input.GetAxis("Jump");
        float inputz = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(movementSpeed * inputx, 0, movementSpeed * inputz) * Time.deltaTime;
        //transform.Translate(movement);

        playerRb.velocity = (transform.forward * inputz + transform.right * inputx) * movementSpeed * 100 * Time.deltaTime;
        //transform.Rotate((transform.up * inputx) * movementSpeed * Time.deltaTime);
    }

    private void Update()
    {
        Jump();
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }
}
