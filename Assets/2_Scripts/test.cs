using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class test : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TimerCoroutine());
    }
    IEnumerator TimerCoroutine()
    {
        int counter = 0;
        while (true)
        {
            Debug.Log(counter);
            counter++;
            yield return new WaitForSeconds(1);
        }

    }
}