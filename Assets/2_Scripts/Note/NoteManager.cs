using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public static NoteManager Instance;

    [SerializeField] private NoteGroup[] noteGroupsArr;

    private void Awake()
    {
        Instance = this;
    }

    public void OnInput(KeyCode keyCode)
    {
        int randld = Random.Range(0, noteGroupsArr.Length);
        bool isApple = randld == 0 ? true : false;

        foreach (NoteGroup noteGroup in noteGroupsArr)
        {
            if (keyCode == noteGroup.KeyCode)
            {
                noteGroup.OnInput(isApple);
            }
        }

      
    }
}     
