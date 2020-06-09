using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class urlGrabber : MonoBehaviour
{
    public GameObject website, urlField,GameMaster,passfield,desktop,passScreen,overScreen,websiteField;
    public string urlPass, pcPass, webPass;
    InputField url,pass, webPassField;
    GlobalControl globalControl;
    void Start()
    {
         url = urlField.GetComponent<InputField>();
         pass = passfield.GetComponent<InputField>();
        webPassField = websiteField.GetComponent<InputField>();
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
            website.SetActive(true);
        }
        if (pass.text == pcPass && Input.GetKeyDown(KeyCode.Return))
        {
            passScreen.SetActive(false);
            desktop.SetActive(true);
            globalControl.hasEnteredPassword = true;
        }
        if (webPassField.text == webPass && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("salut");
            website.SetActive(false);
            overScreen.SetActive(true);
        }


    }
}
