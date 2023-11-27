using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCamControl : MonoBehaviour
{
    Vector3 direction;

    [SerializeField] private float mouseSense;

    [SerializeField] Transform bot;


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

        bot.Rotate(Vector3.up * mouseX);
        bot.Rotate(Vector3.down * mouseY);
    }

    private void Update()
    {
        CamControl();
    }
}
