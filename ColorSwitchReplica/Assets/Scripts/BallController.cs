using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb; //Rigidbody 2d eriştik
    [SerializeField] private float jumpForce; //Float türünde bir jumpForce değişkeni oluşturduk

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mouse sol click tıklıyor ise;
        {
            rb.velocity = Vector2.up * jumpForce; //Vector2.up ve jumpForce'u çarp ve velocity'e ata
        }
    }
}
