using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGhost : MonoBehaviour
{
    // Move Vars
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    // Jump vars 
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;


    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {

        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Horizontal") * rotationSpeed;
        float rotation = Input.GetAxis("Vertical") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        //transform.Translate(translation, 0, 0);

        // Rotate around our y-axis
        transform.Rotate(translation, rotation, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }
    }

}
