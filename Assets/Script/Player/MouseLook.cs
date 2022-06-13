using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSpeed = 200f;
    public Transform playerBody;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
        
        // Look Y axis
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40f, 30f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //Look X axis
        playerBody.Rotate(Vector3.up * mouseX);

        
        
    }
}