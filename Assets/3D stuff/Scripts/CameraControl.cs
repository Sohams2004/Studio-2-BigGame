using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float mouseSense;

    [SerializeField] Transform player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player = GetComponent<Transform>();
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