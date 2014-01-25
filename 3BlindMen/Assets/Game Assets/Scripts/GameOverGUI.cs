﻿using UnityEngine;
using System.Collections;

public class GameOverGUI : MonoBehaviour {
    bool gameOver = false;

    public bool GameOver
    {
        get { return gameOver; }
    }


    public void ShowGameOver()
    {
        guiText.text = "YOU RAN OUT OF TIME";
    }

    internal void Restart()
    {
        guiText.text = "";
    }

    internal void ShowGameOverForGood()
    {
        guiText.text = "YOU ARE OUT OF LIVES";
        gameOver = true;
    }

    void Update()
    {
        if (Input.anyKeyDown && gameOver)
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
    }
}
