using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteGroup : MonoBehaviour
{
    [SerializeField] private int noteMaxNum = 5;
    [SerializeField] private GameObject notePrefab=null;
    [SerializeField] private GameObject noteSpawn=null;
    [SerializeField] private float noteGap =6.5f;

    [SerializeField] private SpriteRenderer BtnSpriteRenderer = null;
    [SerializeField] private Sprite normalBtnSprite=null;
    [SerializeField] private Sprite selectBtnSprite= null;
    [SerializeField] private TextMeshPro keyCodeTmp;
    [SerializeField] private Animation anim;
    
    private KeyCode keyCode;

    public KeyCode KeyCode
    {
        get
        {
            return keyCode;
        }
    }


    private List<Note> noteList = new List<Note>();
    

    public void Create(KeyCode _keycode)
    {
        this.keyCode = _keycode;
        keyCodeTmp.text = _keycode.ToString();

        for (int i = 0; i < noteMaxNum; i++)
        {
            CreateNote(true);
        }

        InputManager.Instance.AddKeyCode(_keycode);
    }

    private void CreateNote(bool isApple)
    {
        GameObject noteGameObj = Instantiate(notePrefab);
        noteGameObj.transform.SetParent(noteSpawn.transform);
        noteGameObj.transform.localPosition = Vector3.up * noteList.Count * noteGap;

        Note note = noteGameObj.GetComponent<Note>();
        note.SetSprite(isApple);

        noteList.Add(note);
    }
    void Update()
    {
        
    }
    public void OnInput(bool isApple)
    {
        if (noteList.Count > 0)
        {
            Note delNote = noteList[0];
            delNote.DeleteNote();
            noteList.RemoveAt(0);
        }

        for (int i = 0; i < noteList.Count; i++)
            noteList[i].transform.localPosition = Vector3.up * i * noteGap;

        CreateNote(isApple);

        anim.Play();
        BtnSpriteRenderer.sprite = selectBtnSprite;
    }
     public void callAniDone()
    {
        BtnSpriteRenderer.sprite = normalBtnSprite;
    }
}
