using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float mouseSense;

    [SerializeField] Transform player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
        player = GetComponent<Transform>();
        Application.targetFrameRate= 60;
    }

    void CamControl()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

        player.Rotate(Vector3.up * mouseX);
        player.Rotate(Vector3.down * mouseY);
    }

    private void Update()
    {
        CamControl();
    }
}