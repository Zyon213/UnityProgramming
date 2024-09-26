using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float planeSpeed = 10.0f;
    private float turnSpeed = 1.0f;
    private float forwardInput;
    private float horzontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horzontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * planeSpeed);
       transform.Rotate(Vector3.up * turnSpeed * horzontalInput);
        transform.Rotate(Vector3.left * turnSpeed * forwardInput);
    
    }
}
