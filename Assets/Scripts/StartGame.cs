using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    
    public void LoadStartScene()
    {
        Manager.instance.menu = "Game";
        SceneManager.LoadScene("Game");
    }

    public void LoadPreviousScene() 
    {
        if (Manager.instance.menu == "Main_Menu") { LoadMainScene(); }
        else if (Manager.instance.menu == "Options") { LoadOptionsScene(); }
        else if (Manager.instance.menu == "Game") { LoadStartScene(); }
    }
    
    public void LoadOptionsScene()
    {
        Manager.instance.menu = "Options";
        SceneManager.LoadScene("Options");
    }
    
    public void LoadMainScene()
    {
        Manager.instance.menu = "Main_Menu";
        SceneManager.LoadScene("Main_Menu");
    }

    public void LoadProfileScene() 
    {
        SceneManager.LoadScene("Profile");
    }

    public void LoadStoreScene() 
    {
        SceneManager.LoadScene("Store");
    }
}
