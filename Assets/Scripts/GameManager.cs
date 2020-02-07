/*
 * (Levi Schoof)
 * (Game Manager)
 * (Assignment 3)
 * (Handles the staring and ending of the game)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   [HideInInspector] public bool pinkDone;
   [HideInInspector] public bool purpleDone;

    public Text vic1;
    public Text vic2;

    private void Start()
    {
        Time.timeScale = 1;
        pinkDone = false;
        purpleDone = false;

        vic1.enabled = false;
        vic2.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if(Time.timeScale > 0 & pinkDone & purpleDone)
        {
            PlayerWon();
        }
    }

    private void PlayerWon()
    {
        Time.timeScale = 0;

        vic1.enabled = true;
        vic2.enabled = true;
    }
}
