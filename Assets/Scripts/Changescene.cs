using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour
{

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public static void LooseScreen()
    {
        SceneManager.LoadScene("LooseScene");
    }

    public static void WinScene()
    {
        SceneManager.LoadScene("WinScene");
    }
}
