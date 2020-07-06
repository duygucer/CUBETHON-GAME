using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 4000f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, -( forwardForce * Time.deltaTime));
    }
}
