using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedUp : MonoBehaviour
{
    public float additionalForce = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ADDING SPEED");
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb) rb.AddForce(transform.forward * additionalForce * Time.fixedDeltaTime); // direction is hard coded
        }
    }
}
