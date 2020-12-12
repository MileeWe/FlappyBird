using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tr;
    public bool a = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space))
        {
            a = true;
        }
        if (a == false)
        {
            tr.position = new Vector3 (-5,10,0); 
        }
        if (a)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                rb.AddForce(Vector3.up * (10 - rb.velocity.y), ForceMode.Impulse);
            }    
        }
    }
}
