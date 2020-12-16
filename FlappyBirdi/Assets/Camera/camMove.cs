using UnityEngine;
using System.Collections;
 
public class camMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject cub;
    public Renderer rend;
    void start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
    void LateUpdate()
    {
        Vector3 p = Player.transform.position;
        p.y = transform.position.y;
        p.z = transform.position.z;
        transform.position = p;
        cub.SetActive(false);
    }
}