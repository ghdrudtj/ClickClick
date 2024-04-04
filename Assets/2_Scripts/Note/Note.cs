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

    private bool isApple;
    public void Destroy()
    {
        GameObject.Destroy(gameObject);
    }

    public void SetSprite(bool isApple)
    {
        this.isApple = isApple;
        SpriteRenderer.sprite = isApple ? appleSprite : blueberrySprite;
    }

    public void DeleteNote()
    {
        GameManger.lnstance.CalculateScore(isApple);

        Destroy();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
