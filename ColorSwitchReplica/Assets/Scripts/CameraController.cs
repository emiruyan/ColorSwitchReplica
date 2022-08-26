using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform ball;//Camera topu takip edeceği için topun transformunu verdik

    void Update()
    {
        if (ball.position.y > transform.position.y)//ball transformu camera transformdan büyük ise; 
        {
            transform.position = new Vector3(transform.position.x, ball.position.y, transform.position.z); 
        }
    }
}
