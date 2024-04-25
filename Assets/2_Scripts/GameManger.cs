using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManger : MonoBehaviour
{
    public static GameManger lnstance;

    [SerializeField] private int maxScore;
    [SerializeField] private int noteGroupCreateScore = 10;
    public static bool isClear;
    public static bool isOver;

    private static int score;
    private static int time;
    private int nextNoteGroupUnlockCnt;

    [SerializeField] private float maxTime = 30f;

    public bool isGameDone
    {
        get
        {
            if (isClear|| isOver)
                return true;
            else
                return false;
        }
    }

    private void Awake()
    {
        lnstance = this;
    }

    private void Start()
    {
        UIManager.Instance.OnScoreChange(currentScore: score, maxScore);
        NoteManager.Instance.Create();

        StartCoroutine(TimerCoroutine());
        
    }
    
    IEnumerator TimerCoroutine()
    {
        float currentTime = 0f;

        while (currentTime < maxTime)
        {
            currentTime += Time.deltaTime;
            UIManager.Instance.OnTimerChange(currentTime, maxTime);
            yield return null;
            if (isGameDone)
            {
                yield break;
            }
        }
        
        isOver = true;
        SceneManager.LoadScene("GameClear_Scene");
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

            if(maxScore<=score)
            {
                
                SceneManager.LoadScene("GameClear_Scene");
            }


        } else
        {
            score--;
        }
        isClear = true;
        UIManager.Instance.OnScoreChange(currentScore: score, maxScore);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main_Scene");
    }


}
