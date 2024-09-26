using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // get the intial postion of the camera
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // add the initial postion of the camera to the current player position
        transform.position = offset + player.transform.position;
    }
}
