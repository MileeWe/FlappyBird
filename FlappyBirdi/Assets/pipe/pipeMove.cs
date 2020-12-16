using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed;
    
    void Start()
    {
        Vector3 position = transform.position;
        position.y = Random.Range(-2F, 3F);
        transform.position = position;
        Destroy(gameObject, 6.0F);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
    }
}
