using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text scoreText;
    public int score = 0;
    void OnTriggerEnter(Collider col) 
    { 
        if (col.tag == "Score")
        {
            score++;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
