using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class urlGrabber : MonoBehaviour
{
    public GameObject panel, urlField,GameMaster,passfield,desktop,passScreen;
    public string urlPass, pcPass;
    InputField url,pass;
    GlobalControl globalControl;
    void Start()
    {
         url = urlField.GetComponent<InputField>();
         pass = passfield.GetComponent<InputField>();
         GameMaster = GameObject.Find("GameMaster");
         globalControl = GameMaster.GetComponent<GlobalControl>();
        if (globalControl.hasEnteredPassword == true)
        {
            passScreen.SetActive(false);
            desktop.SetActive(true);

        }
    }
    void Update()
    {
        if (url.text == urlPass && Input.GetKeyUp(KeyCode.Return))
        {
            url.text = "";
            panel.SetActive(true);
        }
        if (pass.text == pcPass && Input.GetKeyDown(KeyCode.Return))
        {
            passScreen.SetActive(false);
            desktop.SetActive(true);
            globalControl.hasEnteredPassword = true;
        }


    }
}
