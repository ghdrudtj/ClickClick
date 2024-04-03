using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;
    [SerializeField] private Sprite appleSprite;
    [SerializeField] private Sprite blueberrySprite;
    

    public void Destroy()
    {
        GameObject.Destroy(gameObject);
    }

    public void SetSprite(bool isApple)
    {
        SpriteRenderer.sprite = isApple ? appleSprite : blueberrySprite;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
