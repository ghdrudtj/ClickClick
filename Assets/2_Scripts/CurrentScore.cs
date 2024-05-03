using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{

    void Start()
    {
        GetComponent<Text>().text = "Score:" + GameManger.score.ToString();
        
    }
    void Update()
    {
        
    }
}
