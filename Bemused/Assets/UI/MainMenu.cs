using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGamePlayer1()
    {
        //yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level01PL1");

    }
    public void PlayGamePlayer2()
    {
        //yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level01PL2");

    }
    public void QuitGame ()
    {
        Application.Quit();
    }
}