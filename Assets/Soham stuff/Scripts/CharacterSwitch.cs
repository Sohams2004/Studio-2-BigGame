using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    [SerializeField] PlayerMovement3d playerMovement3D;
    [SerializeField] CameraControl cameraControl;

    [SerializeField] Camera playerCam;
    [SerializeField] Camera botCam;

    [SerializeField] BotMovement botMovement;

    [SerializeField] bool isSwitched;

    private void Start()
    {
        playerMovement3D = FindObjectOfType<PlayerMovement3d>();
        cameraControl = FindObjectOfType<CameraControl>();
        botMovement = FindObjectOfType<BotMovement>();

        botMovement.enabled = false;
        botCam.enabled = false;
    }

    void ToggleCharacters()
    {
        if(!isSwitched)
        {
            playerMovement3D.enabled = false;
            cameraControl.enabled = false;
            playerCam.enabled = false;

            botMovement.enabled = true;
            botCam.enabled = true;

            isSwitched = true;
        }

        else
        {
            playerMovement3D.enabled = true;
            cameraControl.enabled = true; 
            playerCam.enabled= true;

            botMovement.enabled = false;
            botCam.enabled= false;

            isSwitched = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleCharacters();
        }
    }
}
