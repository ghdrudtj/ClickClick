using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameE_Best : MonoBehaviour
{
    [SerializeField] private GameObject BestScoreTmp;
    [SerializeField] private GameObject BestTimeTmp;

    public static bool isClear;
    public static bool isOver;
    void Start()
    {
        BestScoreTmp.SetActive(false);
        BestTimeTmp.SetActive(false);

        if (isClear == true)
        {
            BestTimeTmp.SetActive(true);
        }
        if (isOver == true)
        {
            BestScoreTmp.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
