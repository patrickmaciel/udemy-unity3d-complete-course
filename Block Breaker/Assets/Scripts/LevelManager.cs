﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        Brick.breakableCount = 0;
        Application.LoadLevel(name);
        // SceneManager.LoadScene();
    }

    public void QuitRequest()
    {
        Debug.Log("See you soon!");
        Application.Quit();
    }

    public void ReturnToStart()
    {
        Application.LoadLevel("Start");
        // SceneManager.LoadScene
    }

    public void LoadNextLevel()
    {
        Brick.breakableCount = 0;
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void BricksDestroyed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
