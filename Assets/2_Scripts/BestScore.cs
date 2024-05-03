using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    private int currentScore;

    void Start()
    {
        GetComponent<Text>().text = "Score : " + currentScore.ToString();
    }

    void Update()
    {
        
    }
}
