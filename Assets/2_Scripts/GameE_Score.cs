using UnityEngine;
using UnityEngine.UI;

public class GameE_Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    Text uiText;

    void Start()
    {
        uiText =GetComponent<Text>();
        score = 0;
    }



    void Update()
    {
        uiText.text = score.ToString();
    }
}
