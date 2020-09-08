using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndController : MonoBehaviour
{
    public bool isGameOver = false;


    private void Update()
    {
        IsGameOver();
    }

    private void IsGameOver()
    {
        if (isGameOver)
        {
            print("GameOver!");
        }
    }
}
