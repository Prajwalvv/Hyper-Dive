﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;
    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausePanel.activeInHierarchy)
            {
                PauseGame();
            }
            if (pausePanel.activeInHierarchy)
            {
                ContinueGame();
            }
        }
    }
    public void PauseGame()
    {
        
        Time.timeScale = 1;
        pausePanel.SetActive(false);

        //Disable scripts that still work while timescale is set to 0
    }
    public void ContinueGame()
    {
        
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
} 
