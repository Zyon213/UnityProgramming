using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float horizontalInput;
    private float verticalInput;
    private float speed = 20.0f;
    private float turnSpeed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        // Get Input values
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // rotate the car
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
