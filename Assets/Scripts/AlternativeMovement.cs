using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
//[RequireComponent(typeof(PickUpStuff))]
public class AlternativeMovement : MonoBehaviour
{
    public float speed = 400f;
    private Rigidbody rb;
    private Vector3 dir;
    private PickUpStuff pickUpStuff;
    private Vector3 touchedPoint;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pickUpStuff = GetComponent<PickUpStuff>();

    }

    // Update handles input
    private void Update()
    {
        // Handle Input
        float inHor = Input.GetAxis("Horizontal");
        float inVer = Input.GetAxis("Vertical");

        dir = Vector3.right * (-inVer) + Vector3.forward * (inHor);
    }

    // FixedUpdate handles movement
    void FixedUpdate()
    {
        // Move towards direction
        //rb.AddTorque(dir.normalized * (speed + pickUpStuff.additionalSpeed) * Time.fixedDeltaTime);
        rb.AddForce(dir.normalized * (speed) * Time.fixedDeltaTime);
    }
}
