﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        //yield return new WaitForSeconds(5);
        SceneManager.LoadScene("pc_main");

    }
    public void QuitGame ()
    {
        Application.Quit();
    }
}