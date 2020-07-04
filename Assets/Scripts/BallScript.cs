using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float ballForce = 100.0f; //Задать силу
    bool active = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && active == false)
        {
            Destroy(GameObject.FindGameObjectWithTag("Text")); //Убрать текст
            GetComponent<Rigidbody2D>().velocity = Vector2.up * ballForce; //Применить силу к шару
            active = true; //Защитать от дополнительных нажатий
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
}