using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
}