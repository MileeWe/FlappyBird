using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    
    public Transform player;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
        if(player.position.x > transform.position.x + 10)
        {
            transform.position += new Vector3 (20,0,0);
            a += 8;
        }
    }
}
