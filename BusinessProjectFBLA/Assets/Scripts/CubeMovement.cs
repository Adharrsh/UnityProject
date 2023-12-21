using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f;  // Add this line to declare the speed variable
    float HorizontalInput;
    float VerticalInput;

    void Update()
    {
        // Get input from the arrow keys or A and D
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        // Create a movement vector based on input
        Vector3 movement = new Vector3(HorizontalInput, 0f, VerticalInput);

        // Move the cube based on the input
        transform.Translate(movement * speed * Time.deltaTime);
    }
}