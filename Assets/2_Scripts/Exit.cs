using UnityEngine;

public class Exit : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GameQuit();
    }
    public void GameQuit()
    {
        Application.Quit();
    }
}
