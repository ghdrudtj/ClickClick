using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearScene : MonoBehaviour
{
    public void Gameplay()
    {
        SceneManager.LoadScene("Start_Scene");
    }

    void Update()
    {
        
    }
}
