using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variables
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;

    // Private variables
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the vehicle left and right
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
