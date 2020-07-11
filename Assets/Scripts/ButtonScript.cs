using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    bool isFullScreen;

    public void PlayPressed()
    {
        SceneManager.LoadScene("MainGame");
        print("It works");
        Debug.Log("You have clicked the button!");
    }

    public void SettingPressed()
    {
        SceneManager.LoadScene("Settings");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

    public void FullScreenToogle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

    public void BackPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}