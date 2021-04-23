using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //variables
    public float mouseSensitivity = 15f;
    public
     Transform playerBody;
    float xRotation = 0f;


 
    void Start()
    {
        //Hide mouse cursor;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        //taking mouse input.
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation -= Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}




// Developed by Brandixitor.
