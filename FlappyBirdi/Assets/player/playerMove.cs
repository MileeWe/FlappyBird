using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public GameObject pipes;
    public Rigidbody rb;
    public Transform tr;
    public bool a = false;
    void OnCollisionEnter(Collision col) 
    { 
        if (col.collider.tag == "Dor")
        {
            SceneManager.LoadScene(0);
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(GeneratePipes());
    }
    
    IEnumerator GeneratePipes()
    {
        Vector2 position;
        while(true)
        {
            position = transform.position;
            position.x += 25.0F;
            Instantiate(pipes, position, Quaternion.identity);
            yield return new WaitForSeconds(2.0F);
        }
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
