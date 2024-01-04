using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwable : MonoBehaviour
{

    public Rigidbody rb;

    public float CurrentThrow = 0f;

  

    public void Throw()
    {
        rb.AddForce(transform.up * CurrentThrow);
    }
}
