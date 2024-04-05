using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

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
        this.keyCodeList.Add(_keyCode);
    }

    private void Update()
    {
        foreach (KeyCode keyCode in this.keyCodeList)
        {
            if (Input.GetKeyDown(keyCode) == true)
            {
                NoteManager.Instance.OnInput(keyCode);
            }
        }
    }
}
