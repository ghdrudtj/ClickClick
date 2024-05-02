using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Text Text;
    bool Active = false;
    [SerializeField] private Image image;
    private void Awake()
    {
        image.gameObject.SetActive(false);
    }
    public void textActive()
    {
        if (Active)
        {
            image.gameObject.SetActive(false);
            Active = false;

        }
        else
        {
            image.gameObject.SetActive(true);
            Active = true;
        }
        Text.text = Active ? "X" : "Ό³Έν";
    }
    void Start()
    {
        
    }
   
    void Update()
    {
        
    }
}
