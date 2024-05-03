using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearScene : MonoBehaviour
{
    public void Gameplay()
    {
        SceneManager.LoadScene("Main_Scene");
    }

    void Update()
    {
        
    }
}
