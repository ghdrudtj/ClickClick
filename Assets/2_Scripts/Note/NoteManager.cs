using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
   public static NoteManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void onInput(KeyCode keyCode)
    {
        Debug.Log("Keycode = " + keyCode);

    }
        private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            NoteManager.Instance.onInput(KeyCode.A);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            NoteManager.Instance.onInput(KeyCode.S);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            NoteManager.Instance.onInput(KeyCode.D);
        }
    }
}
