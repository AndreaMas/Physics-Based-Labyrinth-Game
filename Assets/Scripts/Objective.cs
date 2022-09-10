using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{
    public float transitionTime = 1f;

    void OnTriggerEnter(Collider triggerCollider)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void FixedUpdate()
    {
        transform.Rotate(1, 1, 0, Space.Self);
    }

}
