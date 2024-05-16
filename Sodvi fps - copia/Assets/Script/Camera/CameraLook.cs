using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensitivity = 180f;

    public Transform playerBody;
    float xRotattion = 0;
    


    void Start()
    {
        Debug.Log("Hola mundo");
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //movimiento de la camara
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotattion -= mouseY;

        xRotattion = Mathf.Clamp(xRotattion, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotattion, 0, 0);

        playerBody.Rotate(Vector3.up*mouseX);

    }
}