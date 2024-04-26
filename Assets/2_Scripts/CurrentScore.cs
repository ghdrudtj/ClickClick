using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
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
