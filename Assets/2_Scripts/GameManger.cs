using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger lnstance;

    [SerializeField] private int maxScore =100;
    private int score;

    private void Awake()
    {
        lnstance = this;
    }

    private void Start()
    {
        UIManager.Instance.OnScoreChange(this.score, maxScore);
    }

    public void CalculateScore(bool isCorrect)
    {
        if (isCorrect) 
        {
            score++;
        } else
        {
            score--;
        }
        
        UIManager.Instance.OnScoreChange(this.score, maxScore);
    }

    

    
}
