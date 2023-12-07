using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCamControl : MonoBehaviour
{
    Vector3 direction;

    [SerializeField] float mouseSense;
    [SerializeField] float xRotation;

    [SerializeField] Transform bot;

    [SerializeField] Camera cam;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        bot = GetComponent<Transform>();
        
        Application.targetFrameRate = 60;
    }

    void CamControl()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -30f, 30f);
        bot.Rotate(Vector3.up * mouseX);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }

    private void Update()
    {
        CamControl();
    }
}
