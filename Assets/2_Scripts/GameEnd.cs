using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private GameObject gameClearObj;
    [SerializeField] private GameObject gameOverObj;
   
    public static bool isClear;
    public static bool isOver;

    public bool isGameDone
    {
        get
        {
            if (gameClearObj.activeSelf || gameOverObj.activeSelf)
                return true;
            else
                return false;
        }
    }
    private void Start()
    {
        gameClearObj.SetActive(false);
        gameOverObj.SetActive(false);

        if(isClear==true)
        {
            gameClearObj.SetActive(true);
        }
        if(isOver==true)
        {
            gameOverObj.SetActive(true);
        }
    }


    void Update()
    {
        
    }
}
