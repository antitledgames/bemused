﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        //yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level01");

    }
    public void QuitGame ()
    {
        Application.Quit();
    }
}