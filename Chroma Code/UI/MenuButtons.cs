﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject loseUI;

    public void pauseButton()
    {
        if(loseUI.gameObject.activeInHierarchy == false)
        {
            pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void unpauseButton()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
