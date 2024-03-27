using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    private GameManger lnstance;

    private void Awake()
    {
        lnstance = this;
    }
}
