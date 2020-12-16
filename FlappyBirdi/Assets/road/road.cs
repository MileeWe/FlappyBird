using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    public Transform roadMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roadMove.position += new Vector3(-10*Time.deltaTime,0,0);
        if (roadMove.position.x == -14)
        {
            roadMove.position = new Vector3(26,0,0);
        }
    }
}
