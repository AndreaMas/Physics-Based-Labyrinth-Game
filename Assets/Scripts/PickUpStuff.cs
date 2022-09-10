using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PickUpStuff : MonoBehaviour
{
    // size used to keep track of obj dimension, more big more force necessary to move
    public float additionalSpeed = 1f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pickup"))
        {
            collision.transform.parent = transform;

            // increment mass and additional speed for each obj picked up
            additionalSpeed += 125f;
            rb.mass += 0.25f;

        }
    }
}
