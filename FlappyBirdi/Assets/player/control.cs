using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 8;
    // Start is called before the first frame update
    void Start()
    {
        //rb.centerOfMass = new Vector3(1.6f,0.5f,0.5f);
        rb = GetComponent<Rigidbody>();
        //rb.centerOfMass = new Vector3(10000f,0.5f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {  
        rb.AddForce(500*Time.deltaTime,0,0);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0,1000,0);
        }

    }
}
