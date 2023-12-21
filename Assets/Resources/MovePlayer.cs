using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlaye : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    private Rigidbody rigidBody;
    //public const int jumpForce = 1200;

    // Start is called before the first frame update
    void Start()
    {
        //Get our rigidbody
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rigidBody.AddForce(movement * movementSpeed);
    }
}
