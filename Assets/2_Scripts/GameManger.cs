using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger lnstance;

    [SerializeField] private int maxScore;
    [SerializeField] private int noteGroupCreateScore = 10;

    public static bool isClear;
    public static bool isOver;
    
    public static int score=0;
    public static int bestScore=0;

    public AudioClip notegroupsound;
    public AudioSource notegroup;
    public AudioClip AppleS;
    public AudioSource AppleSound;
    public AudioClip blueS;
    public AudioSource blueSound;

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

    void Start()
    {
        isClear = false;
        isOver = false;

        UIManager.Instance.OnScoreChange(score, maxScore);
        NoteManager.Instance.Create();

        StartCoroutine(TimerCoroutine());
        score = 0;
    }
    void Update()
    {
        
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
        SceneManager.LoadScene("GameClear_Scene 1");
    }

    public void Notegroupsound()
    {
        notegroup.PlayOneShot(notegroupsound);
    }
    public void Applesound()
    {
         AppleSound.PlayOneShot(AppleS);
    }
    public void bluesound()
    {
        blueSound.PlayOneShot(blueS);
    }
        
    public void CalculateScore(bool isCorrect)
    {
        if (isCorrect) 
        {
            score++;
            nextNoteGroupUnlockCnt++;
            Applesound();
            
            if (noteGroupCreateScore <= nextNoteGroupUnlockCnt)
            {
                nextNoteGroupUnlockCnt = 0;
                NoteManager.Instance.CreateNoteGroup();
                
                Notegroupsound();
            }

            if(maxScore<=score)
            {
                isClear = true;
                SceneManager.LoadScene("GameClear_Scene");
            }
            

        } else
        {
            score--;
            bluesound();
        }
        
        UIManager.Instance.OnScoreChange(score, maxScore);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
