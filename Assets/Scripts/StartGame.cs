using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadScene()
    {
        Console.Write("game start!");
        SceneManager.LoadScene("Game");
    }
}
