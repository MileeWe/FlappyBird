using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    public Transform roadMove;
    // Start is called before the first frame update
    /*void OnTriggerEnter(Collider col) 
    { 
        Debug.Log("DorM");
        if (col.tag == "DorM")
        {
            Debug.Log("DorM");
            roadMove.position += new Vector3(158.7F,0,0);
        }
    }*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roadMove.position += new Vector3(-10*Time.deltaTime,0,0);

        if (roadMove.position.x <= -117.8F)
        {
            roadMove.position += new Vector3(158.7F,0,0);
        }
    }
}
