using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;

    public float speed = 13f;//velocidad de movimiento

    public float gravity = -15f;

    public Transform grounCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;
    bool isGropunde;
    public float jumpHeigth = 1;//fuerza del salto
    Vector3 velocity;




    void Update()
    { 
        // Movimiento
        isGropunde = Physics.CheckSphere(grounCheck.position,sphereRadius,groundMask);

      

        if (isGropunde && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        //Accion de saltar
        if(Input.GetKeyDown("space") && isGropunde )
        {
            Debug.Log("juump");
            velocity.y = Mathf.Sqrt(jumpHeigth * -2 * gravity);
        }

        characterController.Move(move * speed * Time.deltaTime) ;

        velocity.y   += gravity*Time.deltaTime;
        characterController.Move(velocity*Time.deltaTime) ;
    }
}
