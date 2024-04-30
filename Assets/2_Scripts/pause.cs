using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    [SerializeField] TextAlignment startPauseText;
    bool pauseActive = false;

    
    
    public void pauseBtn()
    {
        if (pauseActive)
        {
            Time.timeScale = 1.0f;
            
            pauseActive = false;

        }
        else
        {
            Time.timeScale = 0;
            
            pauseActive = true;
        }

        InputManager.Instance.setPauseAction(pauseActive);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
