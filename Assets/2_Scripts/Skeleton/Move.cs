using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Move : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim= GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            anim.CrossFade("idle", 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            anim.CrossFade("Attack_1", 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            anim.CrossFade("Attack_2", 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            anim.CrossFade("Death", 0, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            anim.CrossFade("Walk", 0, 0);
        }
    }
}
