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


    private List<Note> noteList = new List<Note>();
    

    void Start()
    {
        for (int i = 0; i < noteMaxNum; i++) 
        {
            GameObject noteGameObj = Instantiate(notePrefab);
            noteGameObj.transform.SetParent(noteSpawn.transform);
            noteGameObj.transform.localPosition = Vector3.up * noteList.Count * noteGap;
            
            Note note = noteGameObj.GetComponent<Note>();

            noteList.Add(note);
        }
       
    }

   void Update()
    {
        
    }


    public void OnInput(bool isSelect)
    {
        if (isSelect)
        {
            anim.Play();
            BtnSpriteRenderer.sprite = selectBtnSprite;
        }
    }
     public void callAniDone()
    {
        BtnSpriteRenderer.sprite = normalBtnSprite;
    }
   
}
