using UnityEngine;
 
public class camMove : MonoBehaviour
{
    public GameObject Player;
    void LateUpdate()
    {
        Vector3 p = Player.transform.position;
        p.y = transform.position.y;
        p.z = transform.position.z;
        transform.position = p;
    }
}