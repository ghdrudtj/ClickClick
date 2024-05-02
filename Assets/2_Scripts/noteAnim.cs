using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class noteAnim : MonoBehaviour
{

    private Animator NoteAnim;
    public static noteAnim Instance;


    void Start()
    {
        NoteAnim = GetComponent<Animator>();
    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this; 
        }

        NoteAnim = GetComponent<Animator>();
    }
    public void CreateNoteGroup()
    {
        NoteAnim.Play("NotegroupAnim");
    }
    public void NotesAnim(bool isCorrect) 
    {
        if(isCorrect)
        {
            NoteAnim.Play("Appleanim");
        }
        else
        {
            NoteAnim.Play("blueanim");
        }
    }
        

    void Update()
    {
        
    }

    
}
