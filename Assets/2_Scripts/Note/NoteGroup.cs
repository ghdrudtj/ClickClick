using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGroup : MonoBehaviour
{
    [SerializeField] private int noteMaxNum = 5;
    [SerializeField] private GameObject notePrefab;
    [SerializeField] private GameObject noteSpawn;
    [SerializeField] private float noteGap =6.5f;

    [SerializeField] private SpriteRenderer BtnSpriteRenderer;
    [SerializeField] private Sprite normalBtnSprite;
    [SerializeField] private Sprite selectBtnSprite;
    [SerializeField] private Animation anim;
    [SerializeField] private KeyCode keyCode;

    public KeyCode KeyCode
    {
        get
        {
            return keyCode;
        }
    }


    private List<Note> noteList = new List<Note>();
    

    void Start()
    {
        for (int i = 0; i < noteMaxNum; i++)
        {
            SpawnNote(true);
        }

    }

    private void SpawnNote(bool isApple)
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
            delNote.Destroy();
            noteList.RemoveAt(0);
        }

        for (int i = 0; i < noteList.Count; i++)
            noteList[i].transform.localPosition = Vector3.up * i * noteGap;

        SpawnNote(isApple);

        anim.Play();
        BtnSpriteRenderer.sprite = selectBtnSprite;

    }
     public void callAniDone()
    {
        BtnSpriteRenderer.sprite = normalBtnSprite;
    }
   
}
