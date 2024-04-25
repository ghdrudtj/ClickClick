using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameE_Score : MonoBehaviour
{
    [SerializeField] private GameObject ScoreTmp;
    [SerializeField] private GameObject TimeTmp;

    public static bool isClear;
    public static bool isOver;
    public bool isGameDone
    {
        get
        {
            if (ScoreTmp.activeSelf || TimeTmp.activeSelf)
                return true;
            else
                return false;
        }
    }
    private void Start()
    {
        ScoreTmp.SetActive(false);
        TimeTmp.SetActive(false);

        if (isClear == true)
        {
            TimeTmp.SetActive(true);
        }
        if (isOver == true)
        {
            ScoreTmp.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
