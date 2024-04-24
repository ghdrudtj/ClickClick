using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScene : MonoBehaviour
{
    public void Gameplay()
    {
        SceneManager.LoadScene("Main_Scene");
    }

    void Update()
    {
        
    }
}
