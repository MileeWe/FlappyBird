using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public GameObject pipes;
    public Rigidbody rb;
    public Transform tr;

    public GameObject go;

    public bool a = false;
    float distance_to_pipe = 25f;
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
            position.x += distance_to_pipe;
            distance_to_pipe -= 2f;
            if (a)
            {
                Instantiate(pipes, position, Quaternion.identity);
            }
            
            yield return new WaitForSeconds(2.0F);
        }
    }
    float rot = 0;
    float rot_increment = 3f;
    void Update()
    {
        if (rb.velocity.y <= 0 && rot_increment > 0)
        {
            rot_increment = -1;
        }
        if (rb.velocity.y > 0 && rot_increment < 0)
        {
            rot_increment = 3;
        }
        rot+=rot_increment;
        if (rot > 30)
        {
            rot = 30;
        }
        if (rot < -90)
        {
            rot = -90;
        }
        if (a)
        {
            transform.rotation = Quaternion.Euler(0,0,rot);
        }
        
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space))
        {
            a = true;
            //go.SetActive(false);
        }
        if (a == false)
        {
            tr.position = new Vector3 (-5,10,0); 
        }
        if (a)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                rb.AddForce(Vector3.up * (15 - rb.velocity.y), ForceMode.Impulse);
            } 
        }
    }
}
