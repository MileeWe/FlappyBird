using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMove : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Scene0");
    }
    
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
