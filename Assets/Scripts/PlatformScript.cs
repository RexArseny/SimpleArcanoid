using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    Vector3 platformPosition;
    public float platformVelocity;
    public float boundary;

    void Start()
    {
        
    }

    void Update()
    {
        platformPosition = gameObject.transform.position; //Получить позицию платформы
        platformPosition.x += Input.GetAxis("Horizontal") * platformVelocity; //Придать новое направление движения
        transform.position = platformPosition; //Обновить позицию платформы

        //Проверка на выход за границы
        if (platformPosition.x > boundary)
        {
            transform.position = new Vector3(boundary, platformPosition.y, platformPosition.z);
        }
        else if (platformPosition.x < -boundary)
        {
            transform.position = new Vector3(-boundary, platformPosition.y, platformPosition.z);
        }
    }
}