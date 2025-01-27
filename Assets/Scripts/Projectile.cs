using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody Rigidbody;
    public float projectileSpeed = 20f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.AddForce(transform.forward * projectileSpeed);
    }

    void FixedUpdate()
    {

    }
}
