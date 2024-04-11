using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger lnstance;

    [SerializeField] private int maxScore;
    [SerializeField] private int noteGroupCreateScore = 10;

    private int score;
    private int nextNoteGroupUnlockCnt;

    [SerializeField] private float maxTime = 10f;

    private void Awake()
    {
        lnstance = this;
    }

    private void Start()
    {
        UIManager.Instance.OnScoreChange(this.score, maxScore);
        NoteManager.Instance.Create();

        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        float currentTime = 0f;
        while (currentTime<maxTime)
        {
            currentTime+=Time.deltaTime;
            UIManager.Instance.OnTimerChange(currentTime, maxTime);
            yield return null;
        }

    }

    public void CalculateScore(bool isCorrect)
    {
        if (isCorrect) 
        {
            score++;
            nextNoteGroupUnlockCnt++;

            if(noteGroupCreateScore <= nextNoteGroupUnlockCnt)
            {
                nextNoteGroupUnlockCnt = 0;
                NoteManager.Instance.CreateNoteGroup();
            }
        } else
        {
            score--;
        }
        
        UIManager.Instance.OnScoreChange(this.score, maxScore);
    }

    

    
}
