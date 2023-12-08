using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    //[SerializeField] private float jumpForce = 10f;
    public float jumpHeight = 4.0f;
    public float jumpDuration = 0.5f;

    [SerializeField] private Rigidbody playerRb;

    //[SerializeField] private bool jumpLimit = false;

    private void FixedUpdate()
    {

    }

    /*public void Jump()
    {
        if (Input.GetButton("Jump") && !jumpLimit)
        {
            Debug.Log("jumped");
            float initialJumpVelocity = (2 * jumpHeight) / jumpDuration;

            playerRb.velocity = new Vector2(playerRb.velocity.x, initialJumpVelocity);
            jumpLimit = true;
        }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpLimit = false;
        }
    }*/


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movementVelocity = new Vector2(horizontalInput * movementSpeed, playerRb.velocity.y);
        playerRb.velocity = movementVelocity;

        //Jump();
    }
}
