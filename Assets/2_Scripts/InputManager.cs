using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    private List<KeyCode> keyCodeList = new List<KeyCode>();
    bool pauseAction;
    private void Awake()
    {
        Instance = this;
    }
    public void setPauseAction(bool pause)
    {
        this.pauseAction = pause;   
    }

    public void AddKeyCode(KeyCode _keyCode)
    {
        keyCodeList.Add(_keyCode);
    }

    private void Update()
    {
        if (GameManger.lnstance.isGameDone || pauseAction)
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
