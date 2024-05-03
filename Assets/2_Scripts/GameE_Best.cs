using UnityEngine;
using UnityEngine.UI;

public class GameE_Best : MonoBehaviour
{
    

    void Start()
    {
        GetComponent<Text>().text="Best Score:" +GameManger.bestScore.ToString();
    }


    void Update()
    {
        
    }
}
