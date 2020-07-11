using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //Перезагрузка уровня
        {
            SceneManager.LoadScene("MainGame");
        }

        if (Input.GetKeyDown(KeyCode.Escape)) //Выход в меню
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}