using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlockScript : MonoBehaviour
{
    static int Score = 0;
    public GameObject Text;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Score++;
        Text.GetComponent<Text>().text = "Счет: " + Score.ToString();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //Перезагрузка уровня
        {
            SceneManager.LoadScene("MainGame");
            Score = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape)) //Выход в меню
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}