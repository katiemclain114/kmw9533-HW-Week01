﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDControl : MonoBehaviour
{

    public float forceAmt = 10;

    Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceAmt);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce((Vector3.back * forceAmt));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceAmt);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce((Vector3.left * forceAmt));
        }
    }
}
