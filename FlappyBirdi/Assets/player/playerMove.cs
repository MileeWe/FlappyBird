using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public GameObject dead;
    bool isDead = false;
    public GameObject pipes;
    public Rigidbody rb;
    public Transform tr;
    public bool a = false;
    public float c = 2.0f;

    public void PlayPressed()
    {
        SceneManager.LoadScene("Scene0");
    }

    void OnCollisionEnter(Collision col) 
    { 
        if (col.collider.tag == "Dor")
        {
            //SceneManager.LoadScene(1);
            dead.SetActive(true);
            isDead = true;
            
        }
    }

    public void RePressed()
    {
        isDead = false;
        SceneManager.LoadScene("Scene0");
    }

    void Start()
    {
        dead.SetActive(false);
        rb = GetComponent<Rigidbody>();
        StartCoroutine(GeneratePipes());
    }
    
    IEnumerator GeneratePipes()
    {
        Vector2 position;
        while(true)
        {
            if(c > 0.8F)
            {
                c -= 0.02f;
            }
            position = transform.position;
            position.x += 25.0F; 
            if (a)
            {
                Instantiate(pipes, position, Quaternion.identity);
            }
            
            yield return new WaitForSeconds(c);
        }
    }
    float rot = 0;
    float rot_increment = 2f;
    void Update()
    {
        if(isDead == false)
        {
            Time.timeScale = 1;
            dead.SetActive(false);
        }
        if(isDead)
        {
            Time.timeScale = 0;
        }
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
        if (rot < -80)
        {
            rot = -80;
        }
        if (a)
        {
            transform.rotation = Quaternion.Euler(0,0,rot);
        }
        
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
                rb.AddForce(Vector3.up * (15 - rb.velocity.y), ForceMode.Impulse);
            } 
        }
    }
}
