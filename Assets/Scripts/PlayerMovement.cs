using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PickUpStuff))]
public class PlayerMovement : MonoBehaviour
{
    public float speedTorque = 1000f;
    public float speedForce = 200f;
    // Required Components
    private Rigidbody rb;
    private PickUpStuff pickUpStuff;
    // Player Input
    private float inputHor;
    private float inputVer;
    // Torque and/or Force
    [SerializeField] private bool usesTorque = true;
    [SerializeField] private bool usesForce = true;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pickUpStuff = GetComponent<PickUpStuff>();

    }

    private void Update()
    {
        // Handle Input
        inputHor = Input.GetAxis("Horizontal");
        inputVer = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Apply Torque and/or Force
        Vector3 dir;
        if (usesTorque)
        {
            dir = (Vector3.right * inputHor + Vector3.forward * inputVer).normalized;
            rb.AddTorque(dir * (speedTorque + pickUpStuff.additionalSpeed * 2) * Time.fixedDeltaTime);
        }
        if (usesForce)
        {
            dir = (Vector3.right * (-inputVer) + Vector3.forward * inputHor).normalized;
            rb.AddForce(dir * (speedForce + pickUpStuff.additionalSpeed) * Time.fixedDeltaTime);
        }
        
    }
}
