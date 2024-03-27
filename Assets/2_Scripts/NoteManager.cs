using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
   public static NoteManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void onInput(KeyCode keyCode)
    {
        Debug.Log("Keycode = " + keyCode);

    }
        private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            NoteManager.instance.onInput(KeyCode.A);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            NoteManager.instance.onInput(KeyCode.S);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            NoteManager.instance.onInput(KeyCode.D);
        }
    }
}
