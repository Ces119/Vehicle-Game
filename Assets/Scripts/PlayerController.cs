using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 10.0f;
    private float turnSpeed = 20.0f;

    private float horizontalInput;
    private float verticalInput;

    private float otherHorizontalInput;
    private float otherVerticalInput;
    // Update is called once per frame
    void Update()
    {
        // For local multiplayer 
        if (gameObject.tag == "Vehicle1")
        {
            // Player Inputs : Arrow Keys for Vehicle1 movement 
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        
            // Moves the vehicle1 forward based on vertical input
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            // Rotates the vehicle1 based on horizantal input   
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }

        if (gameObject.tag == "Vehicle2")
        {
            // Other Player Inputs: ASDW Keys for Vehicle2 movement
            otherHorizontalInput = Input.GetAxis("OtherHorizontal");
            otherVerticalInput = Input.GetAxis("OtherVertical");

                    
            // Moves the vehicle2 forward based on vertical input
            transform.Translate(Vector3.forward * Time.deltaTime * speed * otherVerticalInput);
            // Rotates the vehicle2 based on horizantal input   
            transform.Rotate(Vector3.up, turnSpeed * otherHorizontalInput * Time.deltaTime);
        }

    }
}
