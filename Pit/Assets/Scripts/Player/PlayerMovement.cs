using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 //Variables   
 public CharacterController controller;
 public float speed = 12f;

    


    
    void FixedUpdate()
    {
        //Taking input from the keyboard.
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
    }
}




// Developed by Brandixitor.