using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public static GameManger lnstance;

    [SerializeField] private int maxScore;
    [SerializeField] private int noteGroupCreateScore = 10;
    [SerializeField] private GameObject gameClearObj;
    [SerializeField] private GameObject gameOverObj;

    private int score;
    private int nextNoteGroupUnlockCnt;

    [SerializeField] private float maxTime = 30f;

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

    

    private void Awake()
    {
        lnstance = this;
    }

    private void Start()
    {
        UIManager.Instance.OnScoreChange(this.score, maxScore);
        NoteManager.Instance.Create();

        gameClearObj.SetActive(false);
        gameOverObj.SetActive(false);   

        StartCoroutine(TimerCoroutine());
    }
    
    IEnumerator TimerCoroutine()
    {
        float currentTime = 0f;

        while (currentTime < maxTime)
        {
            currentTime+=Time.deltaTime;
            UIManager.Instance.OnTimerChange(currentTime, maxTime);
            yield return null;
            if (isGameDone)
            {
                yield break;
            }
        }
        gameOverObj.SetActive(true);
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
                gameClearObj.SetActive(true);
            }


        } else
        {
            score--;
        }
        
        UIManager.Instance.OnScoreChange(this.score, maxScore);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }


}
