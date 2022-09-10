using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedImpulse : MonoBehaviour
{
    public float impulseForce = 1000f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ADDING SPEED");
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb) rb.AddForce(transform.forward * impulseForce); // direction is hard coded forward
        }
    }
}
