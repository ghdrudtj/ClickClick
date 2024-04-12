using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    private List<KeyCode> keyCodeList = new List<KeyCode>();

    private void Awake()
    {
        Instance = this;
    }

    public void AddKeyCode(KeyCode _keyCode)
    {
        keyCodeList.Add(_keyCode);
    }

    private void Update()
    {
        if (GameManger.lnstance.isGameDone)
        {
            return;
        }
        foreach (KeyCode keyCode in keyCodeList)
        {
            if (Input.GetKeyDown(keyCode) == true)
            {
                NoteManager.Instance.OnInput(keyCode); 
                break;
            }
        }
    }
}
