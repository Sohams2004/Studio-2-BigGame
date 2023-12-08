using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Update()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputy = Input.GetAxis("Jump");
        float inputz = Input.GetAxis("Vertical");
        playerAnimator.SetFloat("zMovement", inputz);
        playerAnimator.SetFloat("xMovement", inputx);



        if (Input.GetKeyDown(KeyCode.Space))
        {
        playerAnimator.SetBool("isJumping",true);

        }
        else playerAnimator.SetBool("isJumping", false);

    }
}
