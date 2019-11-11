using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int totalNuts;
    int currentNuts = 0;

    public static GameManager x;

    public void Start()
    {
        if (x == null) x = this;
        else Destroy(gameObject);

        totalNuts = GameObject.FindObjectsOfType<NutScript>().Length;

        //Debug.Log(totalNuts);
    }

    public void GotNut()
    {
        currentNuts++;

        CheckIfWin();
    }

    public void CheckIfWin()
    {
        if (currentNuts == totalNuts) Win();
    }

    private void Win()
    {
        Debug.Log("You win!");
    }
}
